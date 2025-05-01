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

namespace Magazine_Management_System
{
    public partial class Admin : Form
    {
        OracleDataAdapter adapter;
        DataSet articlestable;
        OracleCommandBuilder builder;
        public Admin()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        //add section
        private void button6_Click(object sender, EventArgs e)
        {
            string connStr = "Data Source=orcl;User Id=scott;Password=tiger;";
            string newSection = textBox1.Text.Trim();

            if (string.IsNullOrEmpty(newSection))
            {
                MessageBox.Show("Please enter a section name.");
                return;
            }

            using (OracleConnection conn = new OracleConnection(connStr))
            {
                conn.Open();
                string insertQuery = "INSERT INTO Sections (name) VALUES (:name)";

                using (OracleCommand cmd = new OracleCommand(insertQuery, conn))
                {
                    cmd.Parameters.Add(new OracleParameter("name", newSection));

                    try
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Section added successfully.");
                    }
                    catch (OracleException ex)
                    {
                        MessageBox.Show("Error adding section: " + ex.Message);
                    }
                }
            }
        }


            private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        //display sections on radio button choose
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            string conn = "Data Source=orcl;User Id=scott;Password=tiger;";
            string query = "SELECT name FROM Sections";

            OracleDataAdapter adapter = new OracleDataAdapter(query, conn);
            DataSet sectionstable = new DataSet();
            adapter.Fill(sectionstable);

            comboBox2.DataSource = sectionstable.Tables[0];
            comboBox2.DisplayMember = "name";
        }



        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            string conn = "Data source= orcl ; user id= scott ;password = tiger";
            string query = "SELECT * FROM Articles ORDER BY Id ASC";
            adapter = new OracleDataAdapter(query, conn);
            articlestable = new DataSet();
            adapter.Fill(articlestable);
            dataGridView2.DataSource = articlestable.Tables[0];
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView2.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        //add article
        private void button10_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView2.EndEdit();
                this.BindingContext[articlestable.Tables[0]].EndCurrentEdit();

                if (builder == null)
                    builder = new OracleCommandBuilder(adapter);

                List<(int sectionId, string title)> addedArticles = new List<(int, string)>();
                foreach (DataRow row in articlestable.Tables[0].Rows)
                {
                    if (row.RowState == DataRowState.Added)
                    {
                        int sectionId = Convert.ToInt32(row["Section_Id"]);
                        string articleTitle = row["Title"].ToString();

                        row["Published_Time"] = DateTime.Today;

                        addedArticles.Add((sectionId, articleTitle));
                    }
                }


                adapter.Update(articlestable.Tables[0]);

                articlestable.AcceptChanges();

                foreach (var (sectionId, title) in addedArticles)
                {
                    SendNotificationToFollowers(sectionId, title);
                }

                LoadNotifications();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        #region load notification on add article
        private void LoadNotifications()
        {
            string conn = "Data source=orcl; user id=scott; password=tiger";
            string query = "SELECT * FROM Notifications ORDER BY NotificationTime DESC";

            using (OracleConnection connection = new OracleConnection(conn))
            {
                OracleDataAdapter adapter = new OracleDataAdapter(query, connection);
                DataTable table = new DataTable();
                adapter.Fill(table);

                dataGridView2.DataSource = null;
                dataGridView2.DataSource = table;
            }
        }

        private void SendNotificationToFollowers(int sectionId, string articleTitle)
        {
            string connStr = "Data source=orcl; user id=scott; password=tiger";

            using (OracleConnection conn = new OracleConnection(connStr))
            {
                conn.Open();

                using (OracleTransaction transaction = conn.BeginTransaction())
                {
                    try
                    {
                        // 1. Get all followers of the section
                        string followersQuery = "SELECT user_id FROM Followed_Sections WHERE section_id = :sid";
                        OracleCommand followersCmd = new OracleCommand(followersQuery, conn);
                        followersCmd.Transaction = transaction;
                        followersCmd.Parameters.Add("sid", OracleDbType.Int32).Value = sectionId;

                        DataTable followersTable = new DataTable();
                        using (OracleDataAdapter adapter = new OracleDataAdapter(followersCmd))
                        {
                            adapter.Fill(followersTable);
                        }

                        // 2. Get next NotificationId
                        string maxIdQuery = "SELECT NVL(MAX(NotificationId), 0) FROM Notifications";
                        OracleCommand maxIdCmd = new OracleCommand(maxIdQuery, conn);
                        maxIdCmd.Transaction = transaction;
                        int nextId = Convert.ToInt32(maxIdCmd.ExecuteScalar()) + 1;

                        // 3. Insert notifications for each follower
                        string insertQuery = @"INSERT INTO Notifications 
                      (NotificationId, UserId, Notification_content, NotificationTime, IsRead) 
                      VALUES 
                      (:id, :userId, :content, :time, :isRead)";

                        OracleCommand insertCmd = new OracleCommand(insertQuery, conn);
                        insertCmd.Transaction = transaction;
                        insertCmd.Parameters.Add("id", OracleDbType.Int32);
                        insertCmd.Parameters.Add("userId", OracleDbType.Int32);
                        insertCmd.Parameters.Add("content", OracleDbType.Varchar2, 500);
                        insertCmd.Parameters.Add("time", OracleDbType.Date);
                        insertCmd.Parameters.Add("isRead", OracleDbType.Int32);

                        foreach (DataRow row in followersTable.Rows)
                        {
                            insertCmd.Parameters["id"].Value = nextId++;
                            insertCmd.Parameters["userId"].Value = row["user_id"];
                            insertCmd.Parameters["content"].Value = $"New article published: {articleTitle}";
                            insertCmd.Parameters["time"].Value = DateTime.Now;
                            insertCmd.Parameters["isRead"].Value = 0;

                            insertCmd.ExecuteNonQuery();
                        }

                        transaction.Commit();
                        MessageBox.Show($"{followersTable.Rows.Count} notification(s) sent successfully.");
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show("Error while sending notifications: " + ex.Message);
                        throw;
                    }
                }
            }
        }
        #endregion

        //update article
        private void button12_Click(object sender, EventArgs e)
        {
            builder = new OracleCommandBuilder(adapter);
            adapter.Update(articlestable.Tables[0]);

            MessageBox.Show("Updated and saved.");
        }

        //delete article
        private void button11_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
                try
                {
                    int rowIndex = dataGridView2.SelectedRows[0].Index;
                    DataRow row = articlestable.Tables[0].Rows[rowIndex];
                    row.Delete();
                    builder = new OracleCommandBuilder(adapter);
                    adapter.Update(articlestable.Tables[0]);

                    articlestable.Tables[0].AcceptChanges();
                    dataGridView2.DataSource = articlestable.Tables[0];

                    MessageBox.Show("Deleted and saved successfully.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error during deletion: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("No row selected!");
            }
        }

        //auto add date for article
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //dataGridView2.Rows[e.RowIndex].Cells["Published_Time"].Value = DateTime.Today;
        }



        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //delete section
        private void button8_Click(object sender, EventArgs e)
        {
            string connStr = "Data Source=orcl;User Id=scott;Password=tiger;";
            string selectedSection = comboBox2.Text;

            if (string.IsNullOrEmpty(selectedSection))
            {
                MessageBox.Show("Please select a section to delete.");
                return;
            }

            using (OracleConnection conn = new OracleConnection(connStr))
            {
                conn.Open();
                string deleteQuery = "DELETE FROM Sections WHERE name = :name";

                using (OracleCommand cmd = new OracleCommand(deleteQuery, conn))
                {
                    cmd.Parameters.Add(new OracleParameter("name", selectedSection));
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Section deleted successfully.");
                    }
                    else
                    {
                        MessageBox.Show("Section not found or couldn't be deleted.");
                    }
                }
            }

            // Reload ComboBox with remaining sections
            string reloadQuery = "SELECT name FROM Sections";
            OracleDataAdapter adapter = new OracleDataAdapter(reloadQuery, connStr);
            DataSet sectionstable = new DataSet();
            adapter.Fill(sectionstable);

            comboBox2.DataSource = sectionstable.Tables[0];
            comboBox2.DisplayMember = "name";
        }

        //display articles for comments on radio button select
        // display articles for comments on radio button select
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                string connStr = "Data Source=orcl;User Id=scott;Password=tiger;";
                string query = "SELECT Id, Title FROM Articles"; // جلب ID و Title من الجدول

                OracleDataAdapter adapter = new OracleDataAdapter(query, connStr);
                DataSet articlesTable = new DataSet();
                adapter.Fill(articlesTable);

                comboBox4.DataSource = articlesTable.Tables[0];
                comboBox4.DisplayMember = "Title"; 
                comboBox4.ValueMember = "Id";  
            }
        }




        //load articles - comments for selected article
        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
             if (comboBox4.SelectedValue == null)
            {
                MessageBox.Show("Please select a valid article.");
                return;
            }

            int selectedArticleId;
            if (!int.TryParse(comboBox4.SelectedValue.ToString() , out selectedArticleId))
            {
                
                return;
            }

            string connStr = "Data Source=orcl;User Id=scott;Password=tiger;";
            string query = "SELECT Commenttext FROM Comments WHERE Article_id = :Article";

            try
            {
                using (OracleConnection conn = new OracleConnection(connStr))
                {
                    OracleDataAdapter adapter = new OracleDataAdapter(query, conn);
                    adapter.SelectCommand.Parameters.Add(new OracleParameter("Article", selectedArticleId));

                    DataSet commentsTable = new DataSet();
                    adapter.Fill(commentsTable);

                    if (commentsTable.Tables.Count == 0 || commentsTable.Tables[0].Rows.Count == 0)
                    {
                        MessageBox.Show("No comments found for the selected article.");
                        comboBox3.DataSource = null;
                        return;
                    }

                    comboBox3.DataSource = commentsTable.Tables[0];
                    comboBox3.DisplayMember = "Commenttext";
                    comboBox3.ValueMember = "Commenttext";  
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while loading comments: " + ex.Message);
            }
        }


        //delete comment
        private void button7_Click(object sender, EventArgs e)
        {
            string connStr = "Data Source=orcl;User Id=scott;Password=tiger;";

            // Ensure something is selected in comboBox3
            if (comboBox3.SelectedItem == null)
            {
                MessageBox.Show("Please select a comment to delete.");
                return;
            }

            // Get the selected CommentText (from the DisplayMember of comboBox3)
            string selectedCommentText = comboBox3.Text;

            using (OracleConnection conn = new OracleConnection(connStr))
            {
                conn.Open();
                string deleteQuery = "DELETE FROM Comments WHERE CommentText = :commentText";

                using (OracleCommand cmd = new OracleCommand(deleteQuery, conn))
                {
                    cmd.Parameters.Add(new OracleParameter("commentText", selectedCommentText));
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Comment deleted successfully.");
                    }
                    else
                    {
                        MessageBox.Show("Comment not found or couldn't be deleted.");
                    }
                }
            }

            // Reload the comments for the selected article in comboBox3
            comboBox4_SelectedIndexChanged(null, null);
        }

        //display users on radio button select
        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked)
            {
                string connStr = "Data Source=orcl;User Id=scott;Password=tiger;";
                string query = "SELECT id, name FROM Users"; // تعديل الاستعلام ليجلب الاسم

                using (OracleConnection conn = new OracleConnection(connStr))
                {
                    OracleDataAdapter adapter = new OracleDataAdapter(query, conn);
                    DataSet userTable = new DataSet();
                    adapter.Fill(userTable);

                    comboBox5.DataSource = userTable.Tables[0];
                    comboBox5.DisplayMember = "name";   // عرض الاسم في الكومبو بوكس
                    comboBox5.ValueMember = "id";       // الاحتفاظ بالـ id كمفتاح
                }
            }
        }


        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //delete selected user
        private void button9_Click(object sender, EventArgs e)
        {
            // Ensure a UserID is selected in comboBox5
            if (comboBox5.SelectedValue == null)
            {
                MessageBox.Show("Please select a User to delete.");
                return;
            }

            // Get the selected UserID from comboBox5
            int selectedUserID = Convert.ToInt32(comboBox5.SelectedValue);

            // Prompt the user for confirmation before deleting
            DialogResult result = MessageBox.Show("Are you sure you want to delete this user?", "Confirm Deletion", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                string connStr = "Data Source=orcl;User Id=scott;Password=tiger;";

                using (OracleConnection conn = new OracleConnection(connStr))
                {
                    conn.Open();

                    // Query to delete the selected user from the User table
                    string deleteQuery = "DELETE FROM Users WHERE id = :userID";

                    using (OracleCommand cmd = new OracleCommand(deleteQuery, conn))
                    {
                        cmd.Parameters.Add(new OracleParameter("id", selectedUserID));

                        // Execute the delete command
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("User deleted successfully.");

                            // Reload the comboBox5 to reflect changes
                            radioButton4_CheckedChanged(null, null);  // This will refresh the comboBox5
                        }
                        else
                        {
                            MessageBox.Show("User not found or couldn't be deleted.");
                        }
                    }
                }
            }
        }

        private void dataGridView2_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            e.Row.Cells["Published_Time"].Value = DateTime.Today;

        }
    }
}
