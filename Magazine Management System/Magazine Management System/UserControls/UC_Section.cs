using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
using static System.Collections.Specialized.BitVector32;

namespace Magazine_Management_System.UserControls
{
    public partial class UC_Section : UserControl
    {
        string ordb = "Data Source=orcl;User Id=scott;Password=tiger;";
        OracleConnection conn;
        int userID =2;
        int sectionId =1;
        string setionName="Fashon";
        int followers = 0;
        int articles = 0;
        //private DataSet ds;
        //int rows=0;
        //int columns=0;
        public UC_Section()
        {
            InitializeComponent();
        }
        public void viewArticles()
        {
            int comments = 0;
            int reacts = 0;
            conn = new OracleConnection(ordb);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            OracleCommand reactscmd = new OracleCommand();
            OracleCommand commentscmd = new OracleCommand();
            cmd.Connection = conn;
            reactscmd.Connection = conn;
            commentscmd.Connection = conn;
            cmd.CommandText = "select id,photo,title,published_time from articles where section_id = :secId";
            cmd.Parameters.Add("secId", sectionId);
            cmd.CommandType = CommandType.Text;
            reactscmd.CommandType = CommandType.Text;
            commentscmd.CommandType = CommandType.Text;

            OracleDataReader reader = cmd.ExecuteReader();
            OracleDataReader reactsReader;
            OracleDataReader commentsReader;
            while (reader.Read())
            {
                reactscmd.CommandText = "select count(*) from reactions where article_id = :artId";
                reactscmd.Parameters.Clear();
                reactscmd.Parameters.Add("artId", reader[0]);
                commentscmd.CommandText = "select count(*) from comments where article_id = :artId";
                commentscmd.Parameters.Clear();
                commentscmd.Parameters.Add("artId", reader[0]);
                reactsReader = reactscmd.ExecuteReader();
                commentsReader = commentscmd.ExecuteReader();
                while (reactsReader.Read())
                {
                    reacts = Convert.ToInt32(reactsReader[0]);
                }
                while (commentsReader.Read())
                {
                    comments = Convert.ToInt32(commentsReader[0]);
                }
                ArticleCard articleCard = new ArticleCard(reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reacts, comments);
                flowLayoutPanel1.Controls.Add(articleCard);
            }
            conn.Close();
        }
        private void UC_Section_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select id from sections where name = :secName";
            cmd.Parameters.Add("secName", setionName);
            cmd.CommandType = CommandType.Text;
            OracleDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                this.sectionId = Convert.ToInt32(reader[0]);
            }
            secNameLbl.Text = setionName;

            cmd.CommandText = "select count (*) from followed_sections where section_id = :secId";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("secId", sectionId);
            cmd.CommandType = CommandType.Text;
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                this.followers = Convert.ToInt32(reader[0]);
            }
            cmd.CommandText = "select count (*) from articles where section_id = :secId";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("secId", sectionId);
            cmd.CommandType = CommandType.Text;
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                this.articles = Convert.ToInt32(reader[0]);
            }
            conn.Dispose();

            secDetailsLbl.Text = $"{followers} Followers . {articles} articles";
            viewArticles();
            checkFollow();
        }
        public void checkFollow() 
        {
            conn = new OracleConnection(ordb);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select user_id from followed_sections where user_id =:userid AND section_id = :secId";
            cmd.Parameters.Add("userid", userID);
            cmd.Parameters.Add("secId", sectionId);
            cmd.CommandType = CommandType.Text;
            OracleDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                followbtn.Text = "UnFollow";
            }
            conn.Dispose();
        }

        private void followbtn_Click(object sender, EventArgs e)
        {
            bool follow = false;
            conn = new OracleConnection(ordb);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            // delete
            if (followbtn.Text == "UnFollow")
            {
                cmd.CommandText = "delete from  followed_sections where user_id =:userid AND section_id = :secId";
                this.followers--;
                secDetailsLbl.Text = $"{this.followers} Followers . {this.articles} articles";
            }
            // insert
            else 
            {
                cmd.CommandText = "insert into  followed_sections (user_id, section_id) values (:userid,:secId)";
                this.followers++;
                secDetailsLbl.Text = $"{this.followers} Followers . {this.articles} articles";
                follow = true;
            }
            cmd.Parameters.Add("userid", userID);
            cmd.Parameters.Add("secId", sectionId);
            cmd.CommandType = CommandType.Text;
            int result = cmd.ExecuteNonQuery();
            if (result != -1&& follow)
            {
                followbtn.Text = "UnFollow";
            }
            else 
            {
                followbtn.Text = "Follow";
            }
            conn.Dispose();
        }
    }
}
