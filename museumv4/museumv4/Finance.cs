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
    public partial class Finance : Form
    {
        //Get value from database with specific value
        public string GetValue(OleDbCommand cmd, string table_name, string column_name, string target, string target_column)
        {
            cmd.CommandText = "select " + column_name + " from " + table_name + " where ([" + target_column + "]=" + target + ")";
            using (OleDbDataReader reader = cmd.ExecuteReader())
            {
                reader.Read();
                return reader[column_name].ToString();
            }
        }
        //end GetValue()

        private List<string> GetGridData(string column_name)
        {
            List<string> datalist = new List<string>();
            string path = Directory.GetCurrentDirectory();
            string connstring = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + path + @"\GameMuseumManagementSystem.accdb";
            using (OleDbConnection conn = new OleDbConnection(connstring))
            {
                using (OleDbCommand cmd = new OleDbCommand())
                {
                    cmd.Connection = conn;
                    conn.Open();
                    cmd.CommandText = "select " + column_name + " from Finance";
                    using (OleDbDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            datalist.Add(reader[column_name].ToString());
                        }
                    }
                }
            }
            return datalist;
        }

        private string get_revenuespent(string type, string id)
        {
            string result = "";
            string path = Directory.GetCurrentDirectory();
            string connstring = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + path + @"\GameMuseumManagementSystem.accdb";
            using (OleDbConnection conn = new OleDbConnection(connstring))
            {
                using (OleDbCommand cmd = new OleDbCommand())
                {
                    cmd.Connection = conn;
                    conn.Open();
                    if (type.Equals("Souvenir"))
                    {
                        string target_id = GetValue(cmd, "Finance", "Order_ID", id, "Finance_ID");
                        result = GetValue(cmd, "[Order]", "Total_Price", target_id, "Order_ID");
                    }
                    if (type.Equals("Donation"))
                    {
                        string target_id = GetValue(cmd, "Finance", "Item_ID", id, "Finance_ID");
                        result = GetValue(cmd, "ItemDonation", "Selling_Price", target_id, "Item_ID");
                    }
                    if (type.Equals("Ticket"))
                    {
                        string target_id = GetValue(cmd, "Finance", "Purchase_ID", id, "Finance_ID");
                        result = GetValue(cmd, "Purchase", "Total_Price", target_id, "Purchase_ID");
                    }
                    if (type.Equals("Loan"))
                    {
                        string target_id = GetValue(cmd, "Finance", "Loan_ID", id, "Finance_ID");
                        result = GetValue(cmd, "Loan", "Loan_Price", target_id, "Loan_ID");
                    }

                }
            }
            return result;
        }

        //function to set the datagridview in finance
        private void SetGridView()
        {
            List<List<string>> griddata = new List<List<string>>();
            List<string> id = GetGridData("Finance_ID");
            List<string> date = GetGridData("Finance_Date");
            List<string> type = GetGridData("Finance_Type");
            griddata.Add(id);
            griddata.Add(date);
            griddata.Add(type);
            //MessageBox(id[])
            int profit = 0;
            for (int i = 0; i < id.Count(); i++)
            {
                if (type[i].Equals("Donation"))
                {
                    string spent = get_revenuespent(type[i], id[i]);
                    profit -= Int32.Parse(spent);
                    dataGridView1.Rows.Add(id[i], date[i], type[i], profit);
                }
                else
                {
                    string revenue = get_revenuespent(type[i], id[i]);
                    profit += Int32.Parse(revenue);
                    dataGridView1.Rows.Add(id[i], date[i], type[i], profit);
                }
            }
            textBox1.Text = profit.ToString();
        }
        //end SetGridView();

        public Finance(DataGridView spent,DataGridView revenue)
        {
            InitializeComponent();
            SetGridView();
            
        }

        private void printbtn_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }
    }
}
