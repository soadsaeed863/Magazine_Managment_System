using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Magazine_Management_System.UserControls;
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
            txtSearch.Enter += new EventHandler(txtSearch_Enter);
            txtSearch.Leave += new EventHandler(txtSearch_Leave);
            searchPanel.Paint += searchPanel_Paint;
            txtSearch.Text = "Search";
            txtSearch.ForeColor = Color.Gray;
            searchIcon.BackColor = Color.Transparent;
            searchIcon.Parent = searchPanel;
            this.userID = userID;
        }
        private void profilePicture_Click(object sender, EventArgs e)
        {
            UC_UserProfile profileControl = new UC_UserProfile(this.userID);

            profileControl.Dock = DockStyle.Fill;
            containerPanel.Controls.Clear();
            containerPanel.Controls.Add(profileControl);
        }

        private void homeIcon_Click(object sender, EventArgs e)
        {

                UC_Home homeControl = new UC_Home(this.userID);
                homeControl.Dock = DockStyle.Fill;
                containerPanel.Controls.Clear();
                containerPanel.Controls.Add(homeControl);
        }
        private void UserForm_FormClosing(object sender, FormClosingEventArgs e)
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

        private void txtSearch_Enter(object sender, EventArgs e)
        {
            if (txtSearch.Text == "Search")
            {
                txtSearch.Text = "";
                txtSearch.ForeColor = Color.Black;
            }
        }

        private void txtSearch_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                txtSearch.Text = "Search";
                txtSearch.ForeColor = Color.Gray;
            }
        }

        private void searchPanel_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            Rectangle rect = searchPanel.ClientRectangle;

            using (GraphicsPath path = new GraphicsPath())
            {
                int radius = 20;
                path.AddArc(rect.Left, rect.Top, radius, radius, 180, 90);
                path.AddArc(rect.Right - radius, rect.Top, radius, radius, 270, 90);
                path.AddArc(rect.Right - radius, rect.Bottom - radius, radius, radius, 0, 90);
                path.AddArc(rect.Left, rect.Bottom - radius, radius, radius, 90, 90);
                path.CloseFigure();

                searchPanel.Region = new Region(path);
                using (Pen pen = new Pen(Color.LightGray, 1))
                {
                    e.Graphics.DrawPath(pen, path);
                }
            }
        }

        private void UserForm_Shown(object sender, EventArgs e)
        {
            this.ActiveControl = null;
        }
        private void searchIcon_Click(object sender, EventArgs e)
        {
            
        }

        private void searchIcon_Click_1(object sender, EventArgs e)
        {
            string search_text = txtSearch.Text.Trim();
            conn = new OracleConnection(ordb);
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SearchArticles";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("search_value", OracleDbType.Varchar2).Value = search_text;
            cmd.Parameters.Add("out_cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

            OracleDataAdapter adapter = new OracleDataAdapter(cmd);
            DataTable dtable = new DataTable();
            adapter.Fill(dtable);
            UC_Search searchArea = new UC_Search(dtable,this.userID);
            searchArea.Dock = DockStyle.Fill;
            containerPanel.Controls.Clear();
            containerPanel.Controls.Add(searchArea);
        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            UC_Home homeControl = new UC_Home(this.userID);
            homeControl.Dock = DockStyle.Fill;
            containerPanel.Controls.Clear();
            containerPanel.Controls.Add(homeControl);
        }
    }
}
