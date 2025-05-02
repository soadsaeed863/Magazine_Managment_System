using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Guna.UI2.Native.WinApi;
using System.Xml.Linq;
using System.Web.UI.WebControls;

namespace Magazine_Management_System.UserControls
{
    public partial class UC_Search : UserControl
    {
        DataTable dt = new DataTable();
        int userID;
        public UC_Search(DataTable dt, int userID)
        {
            InitializeComponent();
            this.dt = dt;
            this.userID = userID;
        }

        private void viewArticles() 
        {
            foreach (DataRow row in dt.Rows)
            {
                ArticleCard articleCard = new ArticleCard(Convert.ToInt32(row["id"]), row["photo"].ToString(), row["title"].ToString(), row["published_time"].ToString(), Convert.ToInt32(row["Likes"]), Convert.ToInt32(row["CommentCount"]),this.userID);
                searchResult.Controls.Add(articleCard);
            }
        }

        private void UC_Search_Load(object sender, EventArgs e)
        {
            viewArticles();
        }
    }
}
