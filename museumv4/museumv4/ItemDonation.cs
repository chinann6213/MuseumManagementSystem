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
    public partial class ItemDonation : Form
    {
        string name;
        public ItemDonation(string name)
        {
            InitializeComponent();
            this.name = name;
        }

        //Get value from database
        public string GetValue(OleDbCommand cmd, string column_name)
        {
            cmd.CommandText = "select " + column_name + " from ItemDonation where ([Item_Name]=@name)";
            cmd.Parameters.AddWithValue("@name", name);
            using (OleDbDataReader reader = cmd.ExecuteReader())
            {
                reader.Read();
                return reader[column_name].ToString();
            }
        }
        //end GetValue()

        //when the class load
        private void Item_Donation_Load(object sender, EventArgs e)
        {
            string path = Directory.GetCurrentDirectory();
            string connstring = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + path + @"\GameMuseumManagementSystem.accdb";
            using (OleDbConnection conn = new OleDbConnection(connstring))
            {
                using (OleDbCommand cmd = new OleDbCommand())
                {
                    cmd.Connection = conn;
                    conn.Open();
                    nametxt.Text = name;
                    detailtxt.Text = GetValue(cmd, "Item_Detail");
                }
            }
        } //end load()

        //cancel button clicked
        private void discardbtn_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }//end cancel button

    }
}
