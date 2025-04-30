using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Magazine_Management_System.UserControls
{
    public partial class ArticleCard : UserControl
    {
        //private DataRow row;
        string img;
        string title;
        string date;
        int comments;
        int reacts;
        public ArticleCard(string img,string title,string date,int comments,int reacts)
        {
            InitializeComponent();
            this.img = img;
            this.title = title;
            this.comments = comments;
            this.reacts = reacts;
            this.date = date;
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
    }
}
