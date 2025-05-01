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

namespace Magazine_Management_System.UserControls
{
    public partial class UC_Home : UserControl
    {
        OracleConnection conn;
        string ordb = "Data Source=orcl;User Id=scott;Password=tiger;";
        public UC_Home()
        {
            InitializeComponent();
        }

        private void UC_Home_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
            LoadSectionsFromDatabase();
        }

        List<Button> allSectionButtons = new List<Button>();
        int shown_count = 0;
        int maxShownInit = 5;
        private void LoadSectionsFromDatabase()
        {


            using (OracleConnection con = new OracleConnection(ordb))
            {
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = "SELECT ID, name FROM Sections";
                cmd.CommandType = CommandType.Text;

                OracleDataReader dreader = cmd.ExecuteReader();

                while (dreader.Read())
                {
                    string sectionName = dreader["name"].ToString();

                    Button sectionButton = new Button();
                    sectionButton.Text = sectionName;
                    sectionButton.AutoSize = false;
                    sectionButton.Width = 150;
                    sectionButton.Height = 40;
                    sectionButton.Margin = new Padding(10);
                    sectionButton.FlatStyle = FlatStyle.Flat;
                    sectionButton.BackColor = Color.White;
                    sectionButton.Font = new Font("Segoe UI", 10, FontStyle.Bold);
                    sectionButton.Click += SectionButton_Click;




                    allSectionButtons.Add(sectionButton);
                }

                dreader.Close();
                conn.Close();
            }
            ShowInitialSections();
        }
        private void ShowInitialSections()
        {
            section_flow.Controls.Clear();
            shown_count = 0;

            for (int i = 0; i < Math.Min(maxShownInit, allSectionButtons.Count); i++)
            {
                section_flow.Controls.Add(allSectionButtons[i]);
                shown_count++;
            }

            if (allSectionButtons.Count > maxShownInit)
            {
                Button seeMoreBtn = new Button();
                seeMoreBtn.Text = "See More";
                seeMoreBtn.Width = 150;
                seeMoreBtn.Height = 40;
                seeMoreBtn.Click += SeeMoreBtn_Click;

                section_flow.Controls.Add(seeMoreBtn);
            }
        }
        private void SeeMoreBtn_Click(object sender, EventArgs e)
        {
            section_flow.Controls.Clear();
            foreach (var btn in allSectionButtons)
            {
                section_flow.Controls.Add(btn);
            }


        }
        private void SectionButton_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            string sectionName = clickedButton.Text;

            // Sections
            LoadSectionArticles(sectionName);
        }

        private void LoadSectionArticles(string sectionName)
        {
            MessageBox.Show(sectionName);
            //will modified
        }
        public void DisplaySearchResults(DataTable articlesTable)
        {
            //flowLayoutPanelArticles.Controls.Clear();

            foreach (DataRow row in articlesTable.Rows)
            {
                //UC_ArticleCard articleCard = new UC_ArticleCard();

                
                Image image = LoadImageFromPath(row["ImagePath"].ToString());
                string title = row["Title"].ToString();
                string description = row["Description"].ToString();
                string date = Convert.ToDateTime(row["PublishDate"]).ToString("dd/MM/yyyy");
                int commentCount = Convert.ToInt32(row["CommentCount"]);
                int likeCount = Convert.ToInt32(row["Likes"]);

                //articleCard.SetData(image, title, description, date, commentCount, likeCount);
                //    flowLayoutPanelArticles.Controls.Add(articleCard);
                //}
            }
        }
        private Image LoadImageFromPath(string path)
        {
            if (File.Exists(path))
            {
                return Image.FromFile(path);
            }
            else
            {
                // Optional: return a default image or null
                return null;
            }
        }
    }
}
