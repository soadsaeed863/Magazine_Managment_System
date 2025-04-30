using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Magazine_Management_System.ProfileControls
{
    public partial class Delete : UserControl
    {
        string ordb = "Data Source = ORCL ; User Id = scott ; Password = tiger;";
        OracleConnection connDel;
        public Delete()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //connDel = new OracleConnection();
            //connDel.ConnectionString = ordb;
            //connDel.Open();
            //OracleCommand cmd = new OracleCommand();
            //cmd.Connection = connDel;
            //cmd.CommandText = "Delete from Users where id =: id";
            //cmd.Parameters.Add("id", 1);
            //cmd.CommandType = CommandType.Text;
            //int r = cmd.ExecuteNonQuery();
            //if (r != -1)
            //{
            this.Visible = false;
            this.FindForm().Visible = false;
            MainForm mainForm = new MainForm();
            mainForm.Show();
            //}
        }
    }
}
