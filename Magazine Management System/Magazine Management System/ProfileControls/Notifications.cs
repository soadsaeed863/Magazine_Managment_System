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
using System.Security.Policy;
using System.Xml.Linq;
namespace Magazine_Management_System.ProfileControls
{
    public partial class Notifications : UserControl
    {
        string ordb = "Data Source = ORCL ; User Id = scott ; Password = tiger;";
        OracleConnection connNotifi;
        public Notifications()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            container.AutoScroll = true;
            container.VerticalScroll.Enabled = true;
            container.VerticalScroll.Visible = true;
        }

        private void Notifications_Load(object sender, EventArgs e)
        {
            List<int> Fav = new List<int>();
            connNotifi = new OracleConnection();
            connNotifi.ConnectionString = ordb;
            connNotifi.Open();
            OracleCommand cmd = connNotifi.CreateCommand();
            cmd.Connection = connNotifi;
            cmd.CommandText = "GetNoti";
            cmd.Parameters.Add("id", 2);
            cmd.Parameters.Add("NotificationInfo", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
            cmd.CommandType = CommandType.StoredProcedure;
            OracleDataReader dr = cmd.ExecuteReader();
            int y = 10;

            while (dr.Read())
            {

                Panel card = new Panel();
                if (dr[4].ToString() == "0")
                  card.BackColor = Color.AntiqueWhite;
                else
                  card.BackColor = Color.PapayaWhip;
                card.Size = new Size(770, 140);
                card.Location = new Point(10, y);

                    Label Label1 = new Label();
                    Label1.Text = "A new article has been published titled:";
                    Label1.Font = new Font("Microsoft Tai Le", 12, FontStyle.Bold);
                    Label1.Location = new Point(20, 10);
                    Label1.AutoSize = true;


                    Label ArticleName = new Label();
                    ArticleName.Text = dr[1].ToString();
                    ArticleName.Font = new Font("Microsoft Tai Le", 11, FontStyle.Regular);
                    ArticleName.Location = new Point(20, 35);
                    ArticleName.Size = new Size(300, 25);


                    Label Label2 = new Label();
                    Label2.Text = "from the section:";
                    Label2.Font = new Font("Microsoft Tai Le", 12, FontStyle.Bold);
                    Label2.Location = new Point(20, 65);
                    Label2.AutoSize = true;


                    Label SectioneName = new Label();
                    SectioneName.Text = dr[2].ToString();
                    SectioneName.Font = new Font("Microsoft Tai Le", 11, FontStyle.Regular);
                    SectioneName.Location = new Point(20, 90);
                    SectioneName.Size = new Size(200, 25);


                    Label NotifiDate = new Label();
                    NotifiDate.Text = dr[3].ToString();
                    NotifiDate.Font = new Font("Microsoft Tai Le", 11, FontStyle.Regular);
                    NotifiDate.Location = new Point(600, 10);
                    NotifiDate.Size = new Size(150, 25);



                    Button Articlebutton = new Button();
                    Articlebutton.Text = "Show Details";
                    Articlebutton.Size = new Size(100, 30);
                    Articlebutton.Location = new Point(600, 90);
                    Articlebutton.Cursor = Cursors.Hand;
                    Articlebutton.Font = new Font("Microsoft Tai Le", 10, FontStyle.Bold);
                    int id = Convert.ToInt32(dr[5]);
                    Articlebutton.Click += (s, ev) =>
                    {
                        OracleCommand cmd2 = new OracleCommand();
                        cmd2.Connection = connNotifi;
                        cmd2.CommandText = "Update Notifications set IsRead = :isRead where NOTIFICATIONID = :id";
                        cmd2.Parameters.Add("isRead", 1);
                        cmd2.Parameters.Add("id", id);
                        cmd2.CommandType = CommandType.Text;
                        cmd2.ExecuteNonQuery();
                        //Form2 f2 = new Form2(); 
                        //    //f2.Show();
                    };

                    card.Controls.Add(Label1);
                    card.Controls.Add(ArticleName);
                    card.Controls.Add(Label2);
                    card.Controls.Add(SectioneName);
                    card.Controls.Add(NotifiDate);
                    card.Controls.Add(Articlebutton);
               

                container.Controls.Add(card);
                y += card.Height + 10;

            }
        }
    }
}

