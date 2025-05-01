using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.HtmlControls;
using System.Windows.Forms;
using Magazine_Managment_System.UserControls;

namespace Magazine_Management_System.UserControls
{
    public partial class ArticleCard : UserControl
    {
        private bool isMouseHovering = false;  // لتتبع ما إذا كان الماوس فوق الـ UserControl أم لا

        //private DataRow row;
        int id;
        string img;
        string title;
        string date;
        int comments;
        int reacts;
        public ArticleCard(int id,string img, string title, string date, int comments, int reacts)
        {
            InitializeComponent();

            this.img = img;
            this.title = title;
            this.comments = comments;
            this.reacts = reacts;
            this.date = date;
            this.id = id;

            this.MouseEnter += _MouseEnter;
            this.MouseLeave += _MouseLeave;
            this.Click += _Click;
            this.Cursor = Cursors.Hand;

            articleImg.MouseEnter += _MouseEnter;
            articleImg.MouseLeave += _MouseLeave;
            articleImg.Click += _Click;

            titleLbl.MouseEnter += _MouseEnter;
            titleLbl.MouseLeave += _MouseLeave;
            titleLbl.Click += _Click;

            dateLbl.MouseEnter += _MouseEnter;
            dateLbl.MouseLeave += _MouseLeave;
            dateLbl.Click += _Click;

            commentsLbl.MouseEnter += _MouseEnter;
            commentsLbl.MouseLeave += _MouseLeave;
            commentsLbl.Click += _Click;

            reactsLbl.MouseEnter += _MouseEnter;
            reactsLbl.MouseLeave += _MouseLeave;
            reactsLbl.Click += _Click;

            panel1.MouseEnter += _MouseEnter;
            panel1.MouseLeave += _MouseLeave;
            panel1.Click += _Click;


        }

        public void viewDetails()
        {
            titleLbl.AutoEllipsis = true;

            //articleImg.Image = Image.FromFile(this.img);
            titleLbl.Text = this.title;
            dateLbl.Text = this.date;
            reactsLbl.Text = this.reacts.ToString();
            commentsLbl.Text = this.comments.ToString();
        }
        private void ArticleCard_Load(object sender, EventArgs e)
        {
            viewDetails();
        }
        private void _MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.LightGray;
        }

        private void _MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }

        private void _Click(object sender, EventArgs e)
        {
            //var parentForm = this.FindForm();
            //if (parentForm == null) return;

            //var containerPanel = parentForm.Controls["containerPanel"] as Panel;
            //if (containerPanel == null) return;

            //// نحاول نلاقيه بالأسم
            //var articleDetailsControl = containerPanel.Controls["UC_ArticleDetails"];

            //// لو مش موجود نضيفه
            //if (articleDetailsControl == null)
            //{
            //    articleDetailsControl = new UC_ArticleDetails(this.id);
            //    articleDetailsControl.Name = "UC_ArticleDetails";
            //    articleDetailsControl.Dock = DockStyle.Fill;
            //    containerPanel.Controls.Add(articleDetailsControl);
            //}

            //// نخفي باقي الكنترولات
            //foreach (Control ctrl in containerPanel.Controls)
            //    ctrl.Visible = false;

            //articleDetailsControl.Visible = true;


            UserForm parentForm = (UserForm)this.FindForm();
            UC_ArticleDetails articleDetails = new UC_ArticleDetails(this.id);
            articleDetails.Dock = DockStyle.Fill;
            parentForm.containerPanel.Controls.Clear();
            parentForm.containerPanel.Controls.Add(articleDetails);
        }


    }
}
