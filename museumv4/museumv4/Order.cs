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
    public partial class Order : Form
    {
        public Order()
        {
            InitializeComponent();
        }

        private void Order_Load(object sender, EventArgs e)
        {
            string path = Directory.GetCurrentDirectory();

            string connstring = @"Provider = Microsoft.ACE.OLEDB.12.0;Data Source=" + path + @"\GameMuseumManagementSystem.accdb";

            using (OleDbConnection conn = new OleDbConnection(connstring)) //Create connection
            {
                conn.Open();

                using (OleDbCommand cmd = new OleDbCommand("SELECT * FROM ShoppingCart", conn)) //Create command
                {
                    using (OleDbDataReader reader = cmd.ExecuteReader())
                    {
                        order_list.Columns.Add("Souvenir Name", 200);
                        order_list.Columns.Add("Quantity", 100);
                        order_list.Columns.Add("Total Price", 100);
                        order_list.View = View.Details;
                        float total_price = 0;
                        while (reader.Read())
                        {
                            order_list.Items.Add(new ListViewItem(new String[] { reader["Cart_Souv_Name"].ToString(), reader["Quantity"].ToString(), reader["Cart_Souv_Price"].ToString() }));
                            total_price = total_price + int.Parse(reader["Cart_Souv_Price"].ToString());
                        }
                        totalprice_lbl.Text = String.Format(System.Globalization.CultureInfo.CurrentCulture, "{0:C2}", total_price);

                        using (OleDbCommand deletecart = new OleDbCommand("delete from ShoppingCart", conn)) //Create command
                            deletecart.ExecuteNonQuery();
                    }
                }
            }
                
        }
    }
}
