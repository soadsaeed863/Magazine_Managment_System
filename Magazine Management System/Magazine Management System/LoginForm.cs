using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Magazine_Management_System;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
namespace Magazine_Managment_System
{
    public partial class LoginForm : Form
    {
        string ordb = "Data source=orcl;User Id=scott; Password = tiger;";
        OracleConnection conn;
        OracleCommand cmd = new OracleCommand();
        OracleDataAdapter da = new OracleDataAdapter();
        public LoginForm()
        {

            //cmd.Connection = conn;
            //cmd.CommandText = "INSERT INTO Users VALUES (:Name, :Email, :Password, :Role_ID, :PhoneNumber, :SecQues, :ProfilePic)";

            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
        }

        private void label13_Click(object sender, EventArgs e)
        {
            //loginToRegister
            Register register = new Register();
            register.Show();
            this.Close();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Please fill all the fields", "Missing Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (conn = new OracleConnection(ordb))
            {
                conn.Open();
                cmd = new OracleCommand("SELECT u.*, ur.name AS role_name FROM users u, userroles  ur WHERE u.role_id = ur.id AND u.name = :Name AND u.password = :pass", conn);
                cmd.Parameters.Add(":Name", textBox1.Text.Trim());
                cmd.Parameters.Add(":pass", textBox2.Text);

                OracleDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    MessageBox.Show("Login Successful", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (dr["role_name"].ToString() == "Admin")
                    
                        new Admin().Show();
                    
                    else
                        new UserForm(Convert.ToInt32(dr["id"])).Show(); 
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Invalid Email or Password", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {
            Application.Exit();
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


        private void Login_Load(object sender, EventArgs e)
        {
            textBox2.PasswordChar = '*';
            textBox5.PasswordChar = '*';
            textBox7.PasswordChar = '*';
            pictureBox1.Visible = true;
            pictureBox2.Visible = false;
            pictureBox3.Visible = true;
            pictureBox4.Visible = false;
            pictureBox5.Visible = true;
            pictureBox6.Visible = false;
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
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Pass(textBox5, pictureBox3, pictureBox4);
        }

        // pictureBox2 = closed eye for textBox2
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Pass(textBox5, pictureBox3, pictureBox4);


        }
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Pass(textBox7, pictureBox5, pictureBox6);
        }

        // pictureBox2 = closed eye for textBox2
        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Pass(textBox7, pictureBox5, pictureBox6);
        }
        //forget password
        private void label2_Click(object sender, EventArgs e)
        {
            if (panel3.Visible == true)
            {
                panel3.Visible = false;

            }
            else
            {
                panel3.Visible = true;

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox6.Text == "" || textBox5.Text == "" || textBox7.Text == "")
            {
                MessageBox.Show("Please fill all the fields", "Missing Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (textBox6.Text.Length != 3)
            {
                MessageBox.Show("please enter last 3 digit of your national id", "Invalid secQues", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (textBox7.Text.Trim().Length < 8)
            {
                MessageBox.Show("Password must be at least 8 characters long", "Invalid Password Format", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (textBox5.Text != textBox7.Text)
            {
                MessageBox.Show("Password does not match", "Invalid Password", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            using (OracleConnection newConn = new OracleConnection(ordb))
            {
                newConn.Open();

                OracleCommand cmd = new OracleCommand();
                cmd.Connection = newConn;

                cmd.CommandText = "UPDATE Users SET Password = :newPass WHERE Name = :name AND SecQues = :secQues";
                cmd.Parameters.Add("newPass", textBox7.Text);
                cmd.Parameters.Add("name", textBox1.Text.Trim());
                cmd.Parameters.Add("secQues", textBox6.Text);

                int rowsUpdated = cmd.ExecuteNonQuery();
                if (rowsUpdated > 0)
                {
                    MessageBox.Show("Password updated successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    panel3.Visible = false;
                }
                else
                {
                    MessageBox.Show("Invalid username or security answer", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

     
    }
}


