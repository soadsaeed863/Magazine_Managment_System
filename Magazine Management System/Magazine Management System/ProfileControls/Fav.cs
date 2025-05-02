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
namespace Magazine_Management_System.ProfileControls
{
    public partial class Fav : UserControl
    {
        int userID;
        string ordb = "Data Source = ORCL ; User Id = scott ; Password = tiger;";
        OracleConnection connFav;
        public Fav(int userID)
        {
            InitializeComponent();
            this.userID = userID;
        }

        private void Fav_Load(object sender, EventArgs e)
        {
            List<int> Fav = new List<int>();
            connFav = new OracleConnection();
            connFav.ConnectionString = ordb;
            connFav.Open();
            OracleCommand cmd = connFav.CreateCommand();
            cmd.Connection = connFav;
            cmd.CommandText = "GetFav";
            cmd.Parameters.Add("id", this.userID);
            cmd.Parameters.Add("articleinfo", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
            cmd.CommandType = CommandType.StoredProcedure;
            OracleDataReader dr = cmd.ExecuteReader();
            int y = 10;
            while (dr.Read())
            {
                Panel card = new Panel();
                card.BorderStyle = BorderStyle.FixedSingle;
                card.BackColor = Color.DeepPink;
                card.Size = new Size(780, 170);
                card.Location = new Point(10, y);

                PictureBox ArticlePic = new PictureBox();
                string path = dr[2].ToString();
                ArticlePic.Size = new Size(200, 150);
                ArticlePic.Location = new Point(10, 10);
                ArticlePic.SizeMode = PictureBoxSizeMode.StretchImage;
                if (!string.IsNullOrEmpty(path) && File.Exists(path))
                {
                    ArticlePic.Image = Image.FromFile(path);
                }

                Label titleLabel = new Label();
                titleLabel.Text = dr[0].ToString();
                titleLabel.Font = new Font("Segoe UI", 10, FontStyle.Bold);
                titleLabel.Location = new Point(220, 20);
                titleLabel.AutoSize = true;

                Label publisher = new Label();
                publisher.Text = dr[1].ToString();
                publisher.Font = new Font("Segoe UI", 10, FontStyle.Bold);
                publisher.Location = new Point(220, 60);
                publisher.AutoSize = true;

                Button openFormButton = new Button();
                openFormButton.Text = "Show Article";
                openFormButton.Size = new Size(100, 30);
                openFormButton.Location = new Point(220, 100);
                openFormButton.Cursor = Cursors.Hand;

                //openFormButton.Click += (s, ev) =>
                //{
                //    //Form2 f2 = new Form2(); 
                //    //f2.Show(); 
                //};

                card.Controls.Add(openFormButton);

                card.Controls.Add(titleLabel);
                card.Controls.Add(publisher);
                card.Controls.Add(ArticlePic);

                continer.Controls.Add(card);
                y += card.Height + 10;
               
            }
        }

        private void continer_Paint(object sender, PaintEventArgs e)
        {
            //continer.AutoScroll = true;
            //continer.VerticalScroll.Enabled = true;
            //continer.VerticalScroll.Visible = true;
        }
    }
}
