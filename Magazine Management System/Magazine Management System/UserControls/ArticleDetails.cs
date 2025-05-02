using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
using static System.Collections.Specialized.BitVector32;


namespace Magazine_Management_System.UserControls
{
    public partial class ArticleDetails : UserControl
    {
        int articleID;
        int userID;
        bool saved = false;
        string ordb = "Data Source=orcl;User Id=scott;Password=tiger;";
        OracleConnection conn;
        public ArticleDetails(int articleID,int userID)
        {
            InitializeComponent();
            this.articleID = articleID;
            this.userID = userID;
        }

        private void UC_ArticleDetails_Load(object sender, EventArgs e)
        {
            loadDetails();
            saved= isSaved();
            isReacted();
            conn = new OracleConnection();
            conn.ConnectionString = ordb;
            conn.Open();
            OracleCommand cmd = conn.CreateCommand();
            cmd.Connection = conn;
            cmd.CommandText = "GetComments";
            cmd.Parameters.Add("articleid", this.articleID);
            cmd.Parameters.Add("result", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
            cmd.CommandType = CommandType.StoredProcedure;
            OracleDataReader dr = cmd.ExecuteReader();
            int y = 10;
            while (dr.Read())
            {
                Panel card = new Panel();
                card.BorderStyle = BorderStyle.FixedSingle;
                card.BackColor = ColorTranslator.FromHtml("#EAEAEA");
                card.Size = new Size(400, 100);
                card.Location = new Point(10, y);
                card.Padding = new Padding(10);

                Label userName = new Label();
                userName.Text = dr[0].ToString();
                userName.Font = new Font("Segoe UI", 10, FontStyle.Bold);
                userName.Location = new Point(10, 10);
                userName.AutoSize = true;

                Label commenttext = new Label();
                commenttext.Text = dr[1].ToString();
                commenttext.Font = new Font("Segoe UI", 14, FontStyle.Regular);
                commenttext.Location = new Point(10, 35);
                commenttext.AutoSize = true;

                Label commentDate = new Label();
                commentDate.Text = dr[2].ToString();
                commentDate.Font = new Font("Segoe UI", 12, FontStyle.Italic);
                commentDate.Location = new Point(10, 60);
                commentDate.AutoSize = true;

                card.Controls.Add(userName);
                card.Controls.Add(commenttext);
                card.Controls.Add(commentDate);

                commentFlow.Controls.Add(card);
                y += card.Height + 10;

            }
            conn.Close();
        }
        private void loadDetails() 
        {
            conn = new OracleConnection(ordb);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "GetArticle";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("articleID", this.articleID);
            cmd.Parameters.Add("result", OracleDbType.RefCursor,ParameterDirection.Output);
            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Title.Text = dr["title"].ToString();
                artImg.Image = Image.FromFile(dr["photo"].ToString());
                publisherName.Text = dr["publisher_name"].ToString();
                Date.Text = dr["published_time"].ToString();
                contentLbl.Text = dr["content"].ToString();
                reactlbl.Text = dr["reacts"].ToString();
                commentsCount.Text = dr["comments"].ToString();
            }
                conn.Close();
        }
        private bool isSaved()
        {
            bool saved = false;
            conn = new OracleConnection(ordb);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select user_id from favorites where user_id =:userID AND article_id = :articleID";
            cmd.Parameters.Add("userID", this.userID);
            cmd.Parameters.Add("articleID", this.articleID);
            cmd.CommandType = CommandType.Text;
            OracleDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                save.Image = Properties.Resources.saved;
                saved = true;
            }
            return saved;
            conn.Dispose();
        }

        private void isReacted()
        {
            conn = new OracleConnection(ordb);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select user_id from reactions where user_id =:userID AND article_id = :articleID";
            cmd.Parameters.Add("userID", this.userID);
            cmd.Parameters.Add("articleID", this.articleID);
            cmd.CommandType = CommandType.Text;
            OracleDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                reactlbl.ForeColor = Color.Red;
            }
            conn.Dispose();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;

            bool isSaved = false;
            if (!saved)
            {
                cmd.CommandText = "INSERT INTO favorites (user_id, article_id) VALUES (:userID, :articleID)";
                isSaved = true;
                this.saved = true;
            }
            else
            {
                cmd.CommandText = "DELETE FROM favorites WHERE user_id = :userID AND article_id = :articleID";
                saved = false;
            }
            cmd.Parameters.Add("userID", this.userID);
            cmd.Parameters.Add("articleID", this.articleID);
            int result = cmd.ExecuteNonQuery();
            conn.Close();
            if (result != -1 && isSaved)
            {
                save.Image = Properties.Resources.saved;  
            }
            else if (result != -1 && !isSaved)
            {
                save.Image = Properties.Resources.unsaved;  
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;

            bool isReacted = false;
            if (reactlbl.ForeColor == Color.Red)
            {
                cmd.CommandText = "DELETE FROM reactions WHERE user_id = :userID AND article_id = :articleID";
                reactlbl.ForeColor = Color.Black;
                reactlbl.Text = (Convert.ToInt32(reactlbl.Text) - 1).ToString(); 
            }
            else
            {
                cmd.CommandText = "INSERT INTO reactions (user_id, article_id) VALUES (:userID, :articleID)";
                isReacted = true;
                reactlbl.ForeColor = Color.Red;
                reactlbl.Text = (Convert.ToInt32(reactlbl.Text) + 1).ToString();  
            }
            cmd.Parameters.Add("userID", this.userID);
            cmd.Parameters.Add("articleID", this.articleID);

            int result = cmd.ExecuteNonQuery();
            conn.Close();
        }
        private void comment_Click(object sender, EventArgs e)
        {
            string comment = textBox1.Text.Trim();
            if (string.IsNullOrEmpty(comment))
            {
                MessageBox.Show("Please enter a comment before submitting.");
            }
            else 
            {
                conn = new OracleConnection(ordb);
                conn.Open();
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = "INSERT INTO comments (id, user_id, article_id, commenttext, comment_time) VALUES (comment_seq.NEXTVAL, :userid, :articleid, :commenttext, :commenttime)";
                cmd.Parameters.Add("userid", this.userID);
                cmd.Parameters.Add("articleid", this.articleID);
                cmd.Parameters.Add("commenttext", comment);
                cmd.Parameters.Add("commenttime", DateTime.Now);


                cmd.ExecuteNonQuery();
                conn.Close();
                commentsCount.Text = (Convert.ToInt32(commentsCount.Text) + 1).ToString();
                textBox1.Clear();
                MessageBox.Show("Comment added successfully.");

            }
        }
    }
}
