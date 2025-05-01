using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
using System.Text.RegularExpressions;
namespace Magazine_Managment_System
{
    public partial class Form1: Form
    {
        string ordb = "Data source=orcl;User Id=scott; Password = tiger;";
        OracleConnection conn;
        byte[] imageBytes;
        public Form1()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            
            InitializeComponent();
        }

        private void label13_Click(object sender, EventArgs e)
        {
            //RegisterToLogin
            LoginForm login = new LoginForm();
            login.Show();
            this.Close();
        }
        //import btn
        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string imagePath = openFileDialog.FileName;

                if (string.IsNullOrWhiteSpace(imagePath) ||
                    !(imagePath.EndsWith(".jpg", StringComparison.OrdinalIgnoreCase) ||
                      imagePath.EndsWith(".jpeg", StringComparison.OrdinalIgnoreCase) ||
                      imagePath.EndsWith(".png", StringComparison.OrdinalIgnoreCase)))
                {
                    MessageBox.Show("Please import a valid profile picture (.jpg, .jpeg, .png)", "Invalid Image", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                guna2CirclePictureBox1.ImageLocation = imagePath;
                guna2CirclePictureBox1.Image = new Bitmap(imagePath);

                using (FileStream fs = new FileStream(imagePath, FileMode.Open, FileAccess.Read))
                {
                    using (BinaryReader br = new BinaryReader(fs))
                    {
                        imageBytes = br.ReadBytes((int)fs.Length);
                    }
                }

                if (imageBytes.Length == 0)
                {
                    MessageBox.Show("Image Doesn't Imported", "Invalid Image", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        private void Pass(TextBox txtBx, PictureBox openEye, PictureBox closedEye)
        {
            if (txtBx.PasswordChar == '*')
            {
                txtBx.PasswordChar = '\0';
                openEye.Visible = false;
                closedEye.Visible = true;
            }
            else
            {
                txtBx.PasswordChar = '*';
                openEye.Visible = true;
                closedEye.Visible = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //comboBox1.SelectedIndex = 0;
            conn = new OracleConnection(ordb);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select Name from userRoles";
            cmd.CommandType = CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr[0]);
            }
        
            pictureBox1.Visible = true; 
            pictureBox2.Visible = false;
            pictureBox3.Visible = true; 
            pictureBox4.Visible = false;
            dr.Close();
        }

        // role comboBox
        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Admin")
            {
                textBox7.Visible = true;
                label8.Visible = true;
            }
            else
            {
                textBox7.Visible = false;
                label8.Visible = false;
            }
        }
        //sign up btn
        private void button1_Click(object sender, EventArgs e)
        {
           if(textBox1.Text == "" || textBox4.Text == "" || textBox8.Text == "" || textBox5.Text == "" || comboBox1.Text == ""||textBox2.Text==""||textBox6.Text=="")
            {
                MessageBox.Show("Please fill all the fields", "Invalid Fields", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (textBox7.Visible == true && textBox7.Text == "")
            {
                MessageBox.Show("Please fill all the fields", "Invalid Field", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string em = textBox4.Text.Trim();

           
            if (!System.Text.RegularExpressions.Regex.IsMatch(em, @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$"))
            {
                MessageBox.Show("Please enter a valid Email Address.", "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if(textBox2.Text.Trim().Length < 8)
            {
                MessageBox.Show("Password must be at least 8 characters long", "Invalid Password Format", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (textBox2.Text != textBox8.Text)
            {
                MessageBox.Show("Password and Confirm Password do not match", "Doesn't match", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (textBox5.Text.Length != 11)
            {
                MessageBox.Show("Phone Number not in its right format", "Invalid Phone Number", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            //if (!(guna2CirclePictureBox1.ImageLocation.EndsWith(".jpg", StringComparison.OrdinalIgnoreCase) 
            //    ||guna2CirclePictureBox1.ImageLocation.EndsWith(".jpeg", StringComparison.OrdinalIgnoreCase) 
            //    ||guna2CirclePictureBox1.ImageLocation.EndsWith(".png", StringComparison.OrdinalIgnoreCase)))
            //{
            //    MessageBox.Show("Please import a valid profile picture (.jpg, .jpeg, .png)");
            //    return;
            //}
            if (textBox6.Text.Length != 3)
            {
                MessageBox.Show("please enter last 3 digit of your national id", "Invalid secQues", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (textBox7.Visible == true && textBox7.Text.Trim() != "Secure!Admin#917")
            {
                MessageBox.Show("Invalid Secret Key, Only Admins can register with correct key.", "Invalid key", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "INSERT INTO Users (id, Name, Email, Password, Role_ID, PhoneNumber, SecQues, ProfilePic) VALUES (users_seq.NEXTVAL, :Name, :Email, :Password, :Role_ID, :PhoneNumber, :SecQues, :ProfilePic)";
            cmd.Parameters.Add(":Name", textBox1.Text);
            cmd.Parameters.Add(":Email", textBox4.Text);
            cmd.Parameters.Add(":Password", textBox2.Text);
            cmd.Parameters.Add(":Role_ID", comboBox1.SelectedIndex);
            cmd.Parameters.Add(":PhoneNumber", textBox5.Text);
            cmd.Parameters.Add(":SecQues", textBox6.Text);
            cmd.Parameters.Add(":ProfilePic", OracleDbType.Blob).Value = imageBytes;
            //if (imageBytes == null)
            //{
            //    MessageBox.Show("Please upload a profile picture first!", "Not imported image", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return;
            //}
            //MessageBox.Show(Image.)
            int r = cmd.ExecuteNonQuery();

            if (r != -1)
            {
                MessageBox.Show($"{textBox1.Text} Registered Successfully");
                //RegisterToLogin
                LoginForm login = new LoginForm();
                login.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Error in Registration", "Invalid Data entry", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        // X label
        private void label10_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Pass(textBox2, pictureBox1, pictureBox2);
        }

        // pictureBox2 = closed eye for textBox2
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Pass(textBox2, pictureBox1, pictureBox2);
        }

        // pictureBox3 = open eye for textBox8
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Pass(textBox8, pictureBox3, pictureBox4);
        }

        // pictureBox4 = closed eye for textBox8
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Pass(textBox8, pictureBox3, pictureBox4);
        }



    }
}
