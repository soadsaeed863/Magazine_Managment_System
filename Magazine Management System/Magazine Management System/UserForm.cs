using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Magazine_Management_System.UserControls;
using Magazine_Managment_System.UserControls;
using Oracle.DataAccess.Client;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Magazine_Management_System
{
    public partial class UserForm : Form
    {
        string ordb = "Data Source=orcl;User Id=scott;Password=tiger;";
        OracleConnection conn;
        int userID;
        public UserForm(int userID)
        {
            InitializeComponent();
            profilePicture.Click += new EventHandler(profilePicture_Click);
            homeIcon.Click += new EventHandler(homeIcon_Click);
            this.userID = userID;
        }
        private void profilePicture_Click(object sender, EventArgs e)
        {
            UC_UserProfile profileControl = new UC_UserProfile();

            profileControl.Dock = DockStyle.Fill;
            containerPanel.Controls.Clear();
            containerPanel.Controls.Add(profileControl);
        }

        private void homeIcon_Click(object sender, EventArgs e)
        {
            UC_Section homeControl = new UC_Section(1,2);
            homeControl.Dock = DockStyle.Fill;
            containerPanel.Controls.Clear();
            containerPanel.Controls.Add(homeControl);
        }
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void logoutbtn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            this.FindForm().Visible = false;
            MainForm mainForm = new MainForm();
            mainForm.Show();
        }

        private void homeIcon_Click_1(object sender, EventArgs e)
        {

        }

        private void profilePicture_Click_1(object sender, EventArgs e)
        {

        }
    }
}
