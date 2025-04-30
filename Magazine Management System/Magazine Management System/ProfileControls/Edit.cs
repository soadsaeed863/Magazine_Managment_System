using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Magazine_Management_System.ProfileControls
{
    public partial class Edit : UserControl
    {
        string ordb = "Data Source = ORCL ; User Id = scott ; Password = tiger;";
        OracleConnection connEdit;
        public Edit()
        {
            InitializeComponent();
        }

        private void Edit_Load(object sender, EventArgs e)
        {
            connEdit = new OracleConnection();
            connEdit.ConnectionString = ordb;
            connEdit.Open();
            OracleCommand cmd = connEdit.CreateCommand();
            cmd.Connection = connEdit;
            cmd.CommandText = "select PASSWORD,ProfilePic,PHONENUMBER,SECQUES from Users where id =: id";
            cmd.Parameters.Add("id", 2);
            cmd.CommandType = CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                Password.Text = dr[0].ToString();
                confirm.Text= dr[0].ToString();
                URL.Text = dr[1].ToString();
                PhoneNum.Text = dr[2].ToString();
                SecQu.Text = dr[3].ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Password.Text.Trim().Length < 8)
            {
                MessageBox.Show("Password must be at least 8 characters long", "Invalid Password Format", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (Password.Text != confirm.Text)
            {
                MessageBox.Show("Password and Confirm Password do not match", "Doesn't match", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (PhoneNum.Text.Length != 11)
            {
                MessageBox.Show("Phone Number not in its right format", "Invalid Phone Number", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            OracleCommand cmd = connEdit.CreateCommand();
            cmd.Connection = connEdit;
            cmd.CommandText = "Update Users set PASSWORD =:pass,ProfilePic =:url,PHONENUMBER=:phone,SECQUES =:secret  where id =: id";
            cmd.Parameters.Add("pass", Password.Text);
            cmd.Parameters.Add("url", URL.Text);
            cmd.Parameters.Add("phone", PhoneNum.Text);
            cmd.Parameters.Add("secret", SecQu.Text);
            cmd.Parameters.Add("id", 2);

            int r = cmd.ExecuteNonQuery();
            if (r != -1)
            {
                MessageBox.Show("Your Info has updated");
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.AutoScroll = true;
            panel1.VerticalScroll.Enabled = true;
            panel1.VerticalScroll.Visible = true;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Password_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
