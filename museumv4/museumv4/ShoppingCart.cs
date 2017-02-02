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
    public partial class ShoppingCart : Form
    {
        string Souv_ID;
        float total_price = 0;
        private string member_ID;
        public ShoppingCart(string member_id)
        {
            this.member_ID = member_id;
            InitializeComponent();
        }

        private void Shopping_cart_Load(object sender, EventArgs e)
        {
            string path = Directory.GetCurrentDirectory();
            
            string connstring = @"Provider = Microsoft.ACE.OLEDB.12.0;Data Source=" + path + @"\GameMuseumManagementSystem.accdb";

            using (OleDbConnection conn = new OleDbConnection(connstring)) //Create connection
            {
                conn.Open();
                int count_row;
                using (OleDbCommand cmd = new OleDbCommand("SELECT count(*) FROM ShoppingCart", conn))
                {
                    count_row = (int) cmd.ExecuteScalar();
                }
                if(count_row>0)
                {
                    using (OleDbCommand cmd = new OleDbCommand("SELECT * FROM ShoppingCart", conn))//Create command
                    {
                        using (OleDbDataReader reader = cmd.ExecuteReader())
                        {
                            cart_list.Columns.Add("Souvenir Name", 200);
                            cart_list.Columns.Add("Quantity", 100);
                            cart_list.Columns.Add("Total Price", 100);
                            cart_list.View = View.Details;

                            while (reader.Read())
                            {
                                Souv_ID = reader["Cart_Souv_Name"].ToString();
                                cart_list.Items.Add(new ListViewItem(new String[] { Souv_ID, reader["Quantity"].ToString(), reader["Cart_Souv_Price"].ToString() }));
                                total_price = total_price + int.Parse(reader["Cart_Souv_Price"].ToString());
                            }
                        }
                    }
                    using (OleDbCommand cmd = new OleDbCommand("SELECT Souv_ID FROM Souvenir where Souv_Name=@name", conn))
                    {
                        cmd.Parameters.AddWithValue("@name", Souv_ID);
                        using (OleDbDataReader reader = cmd.ExecuteReader())
                        {
                            reader.Read();
                            Souv_ID = reader["Souv_ID"].ToString();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Empty Cart");
                    this.Close();
                    this.Dispose();
                }
                
            }

            totalprice_lbl.Text = String.Format(System.Globalization.CultureInfo.CurrentCulture, "{0:C2}", total_price);
        }

        private void proceed_btn_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
            Payment frm = new Payment(Souv_ID,member_ID,total_price.ToString());
            frm.Show();
        }

        private void discard_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
