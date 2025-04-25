using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using Magazine_Managment_System.UserControls;

namespace Magazine_Managment_System
{
    public partial class UserForm : Form
    {
        public UserForm()
        {
            InitializeComponent();
            profilePicture.MouseClick += new MouseEventHandler(profilePicture_MouseClick);
            homeIcon.Click += new EventHandler(homeIcon_Click);


        }
        private void profilePicture_MouseClick(object sender, MouseEventArgs e)
        {
            UC_UserProfile profileControl = new UC_UserProfile(); 

            profileControl.Dock = DockStyle.Fill;
            containerPanel.Controls.Clear();
            containerPanel.Controls.Add(profileControl);
        }
        private void homeIcon_Click(object sender, EventArgs e)
        {
            UC_Home homeControl = new UC_Home();  
            homeControl.Dock = DockStyle.Fill; 
            containerPanel.Controls.Clear(); 
            containerPanel.Controls.Add(homeControl); 
        }
    }
}
