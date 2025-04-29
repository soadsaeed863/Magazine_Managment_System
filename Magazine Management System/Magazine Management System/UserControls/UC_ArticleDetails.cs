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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
namespace Magazine_Managment_System.UserControls
{
    public partial class UC_ArticleDetails : UserControl
    {

        string ordb = "Data source=orcl;User Id=hr; Password=hr;";
        OracleConnection conn;
        public UC_ArticleDetails()
        {
            InitializeComponent();
        }


        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "GetMagazineByID";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("p_article_id", comboBox1.SelectedItem.ToString());
            cmd.Parameters.Add("p_publisher_name", OracleDbType.Varchar2, ParameterDirection.Output);
            cmd.Parameters.Add("p_section_id", OracleDbType.Int32, ParameterDirection.Output);
            cmd.Parameters.Add("p_title", OracleDbType.Varchar2, ParameterDirection.Output);
            cmd.Parameters.Add("p_published_time", OracleDbType.Date, ParameterDirection.Output);
            cmd.Parameters.Add("p_content", OracleDbType.Varchar2, ParameterDirection.Output);

            cmd.ExecuteNonQuery();

            comboBox1.Text = cmd.Parameters["p_article_id"].Value.ToString();
            comboBox2.Text = cmd.Parameters["p_title"].Value.ToString();
            comboBox5.Text = cmd.Parameters["p_content"].Value.ToString();
            comboBox4.Text = cmd.Parameters["p_publisher_name"].Value.ToString();
            comboBox3.Text = cmd.Parameters["p_section_id"].Value.ToString();
            comboBox3.Text = cmd.Parameters["p_published_Time"].Value.ToString();


        }


        private void UC_ArticleDetails_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
        }




        private void button2_Click(object sender, EventArgs e)
        {
            string cmdstring = "insert into Articles Values(:aId,:Title,:cont,:pn,:psi,TO_DATE(:pubTime, 'DD-MON-RR'),0,0,0)";
            OracleCommand cmdSelect = new OracleCommand(cmdstring, conn);
            cmdSelect.Parameters.Add(":aId", comboBox1.Text);
            cmdSelect.Parameters.Add(":Title", comboBox2.Text);
            cmdSelect.Parameters.Add(":cont", comboBox5.Text);
            cmdSelect.Parameters.Add(":pn", comboBox4.Text);
            cmdSelect.Parameters.Add(":psi", comboBox3.Text);
            cmdSelect.Parameters.Add(":pubTime", comboBox6.Text);
            int r = cmdSelect.ExecuteNonQuery();
            if (r != -1)
            {
                MessageBox.Show("Added Successfully");
            }
        }


        private void button3_Click(object sender, EventArgs e)
        {

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "GetAllArticles";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("p_cursor", OracleDbType.RefCursor, ParameterDirection.Output);
            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox2.Items.Add(dr[0]);

                comboBox1.Text = dr[1].ToString();
                comboBox2.Text = dr[3].ToString();
                comboBox3.Text = dr[4].ToString();
                comboBox4.Text = dr[2].ToString();
                comboBox5.Text = dr[7].ToString();
                comboBox6.Text = dr[6].ToString();
            }
            dr.Close();
        }






        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}