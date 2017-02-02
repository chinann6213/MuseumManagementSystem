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
using System.Data.OleDb;

namespace museumv4
{
    public partial class Loan : Form
    {
        private string Loan_ID;
        public Loan(string loan_id)
        {
            InitializeComponent();
            this.Loan_ID = loan_id;
        }

        private void Loan_Load(object sender, EventArgs e)
        {
            string path = Directory.GetCurrentDirectory();
            string connstring = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + path + @"\GameMuseumManagementSystem.accdb";
            using (OleDbConnection conn = new OleDbConnection(connstring))
            {
                using (OleDbCommand cmd = new OleDbCommand())
                {
                    cmd.Connection = conn;
                    conn.Open();
                    cmd.CommandText = "select * from Loan where Loan_ID=@id";
                    cmd.Parameters.AddWithValue("@id", Loan_ID);
                    using (OleDbDataReader reader = cmd.ExecuteReader())
                    {
                        reader.Read();
                        memberidtxt.Text = reader["Member_ID"].ToString();
                        collidtxt.Text = reader["Coll_ID"].ToString();
                        periodtxt.Text = reader["Loan_Period"].ToString();
                        purposetxt.Text = reader["Loan_Purpose"].ToString();
                        pricetxt.Text = reader["Loan_Price"].ToString();
                    }
                }
            }
        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }
    }
}
