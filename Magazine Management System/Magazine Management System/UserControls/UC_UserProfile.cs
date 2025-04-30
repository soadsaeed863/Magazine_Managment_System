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
using System.IO;
using System.Drawing;
using Magazine_Management_System.ProfileControls;
namespace Magazine_Management_System.UserControls
{
    public partial class UC_UserProfile : UserControl
    {
        string ordb = "Data Source = ORCL ; User Id = scott ; Password = tiger;";
        OracleConnection conn;
        public UC_UserProfile()
        {
            InitializeComponent();
 
        }
        private void addProfileCon(System.Windows.Forms.UserControl uc)
        {
            uc.Dock = DockStyle.Fill;
            container.Controls.Clear();
            container.Controls.Add(uc);
            uc.BringToFront();
        }
        private void UC_UserProfile_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection();
            conn.ConnectionString = ordb;
            conn.Open();
            OracleCommand cmd =  new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select Name,ProfilePic from Users where id =: id";
            cmd.Parameters.Add("id", 2);
            cmd.CommandType = CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                UserName.Text = dr[0].ToString();
                string imagePath = dr[1].ToString();
                if (!string.IsNullOrEmpty(imagePath) && File.Exists(imagePath))
                {
                    pic.Image = Image.FromFile(imagePath);
                }

            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Edit edit = new Edit();
            addProfileCon(edit);
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Fav fav = new Fav();
            addProfileCon(fav);
        }

        private void Notification_Click(object sender, EventArgs e)
        {
            Notifications noti = new Notifications();
            addProfileCon(noti);
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            Delete delete = new Delete();
            addProfileCon(delete);
        }
    }
}
