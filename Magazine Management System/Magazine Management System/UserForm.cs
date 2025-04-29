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
        public UserForm()
        {
            InitializeComponent();
            profilePicture.Click += new EventHandler(profilePicture_Click);
            homeIcon.Click += new EventHandler(homeIcon_Click);
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
            UC_ArticleDetails homeControl = new UC_ArticleDetails();
            homeControl.Dock = DockStyle.Fill;
            containerPanel.Controls.Clear();
            containerPanel.Controls.Add(homeControl);
        }

    }
}
