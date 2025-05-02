
﻿using Oracle.DataAccess.Client;
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
using System.Web.UI.HtmlControls;

namespace Magazine_Management_System.UserControls
{
    public partial class UC_Home : UserControl
    {
        OracleConnection conn;
        string ordb = "Data Source=orcl;User Id=scott;Password=tiger;";
        int userID;
        public UC_Home(int userID)
        {
            InitializeComponent();
            this.userID = userID;
        }

        private void UC_Home_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
            LoadSectionsFromDatabase();
            LoadLatestArticles();
        }

        List<Button> allSectionButtons = new List<Button>();
        int shown_count = 0;
        int maxShownInit = 5;
        private void LoadSectionsFromDatabase()
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
            Button clickedButton = (Button)sender ;
            string sectionName = clickedButton.Text;
            UserForm userForm = (UserForm)this.ParentForm;
            UC_Section section = new UC_Section(sectionName, this.userID);
            section.Dock = DockStyle.Fill;
            userForm.containerPanel.Controls.Clear();
            userForm.containerPanel.Controls.Add(section);
        }
        private void LoadLatestArticles()
        {

            conn = new OracleConnection(ordb);
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "GetLatestArticles";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(" result_cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
            OracleDataAdapter adapter = new OracleDataAdapter(cmd);
            DataTable dtable = new DataTable();
            adapter.Fill(dtable);
            conn.Close();
            foreach (DataRow row in dtable.Rows)
            {
                ArticleCard articleCard = new ArticleCard(Convert.ToInt32(row["id"]), row["Photo"].ToString(), row["title"].ToString(), row["published_time"].ToString(), Convert.ToInt32(row["Likes"]), Convert.ToInt32(row["CommentCount"]), this.userID);
                latestArticlesPanel.Controls.Add(articleCard);
            }
        }
    }
}
