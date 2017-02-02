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
    public partial class Payment : Form
    {
        //ticket attribute
        private string member_ID;
        private DateTime visit_date;
        private int numAdult;
        private int numChild;
        private string paymentType;

        //souvenir attribute
        private string Souv_ID;
        private string Total_Price;

        static string path = Directory.GetCurrentDirectory();
        static string connstring = @"Provider = Microsoft.ACE.OLEDB.12.0;Data Source=" + path + @"\GameMuseumManagementSystem.accdb";
        public Payment()
        {
            InitializeComponent();
            paymentType = "Souvenir";
        }

        //overload constructor for member page
        public Payment(string member_id)
        {
            InitializeComponent();
            member_ID = member_id;
        }

        //overload constructor for ticket
        public Payment(string member_id, DateTime visit, int adult, int child)
        {
            InitializeComponent();
            member_ID = member_id;
            visit_date = visit;
            numAdult = adult;
            numChild = child;
            paymentType = "Ticket";
        }

        //overload construtor for souvenir
        public Payment(string id,string member_id,string price)
        {
            InitializeComponent();
            Souv_ID = id;
            member_ID = member_id;
            Total_Price = price;
            paymentType = "Souvenir";
        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void payment_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Value = DateTime.Today;
            dateTimePicker1.Enabled = false;
        }

        private void okbtn_Click(object sender, EventArgs e)
        {
            confirmPayment();
        }

        private void confirmPayment()
        {
            if (paymentType == "Ticket")
            {
                using (OleDbConnection conn = new OleDbConnection(connstring)) //Create connection
                {
                    conn.Open();

                    using (OleDbCommand adult = new OleDbCommand("INSERT INTO Purchase (Ticket_ID, Member_ID, Purchase_Date, Ticket_Quantity, Total_Price) VALUES (@tic_id, @mem_id, @date, @quantity, @total_price);", conn)) //Create command
                    {
                        OleDbCommand child = new OleDbCommand("INSERT INTO Purchase (Ticket_ID, Member_ID, Purchase_Date, Ticket_Quantity, Total_Price) VALUES (@tic_id, @mem_id, @date, @quantity, @total_price);", conn); //Create command

                        OleDbCommand getAdultTicID = new OleDbCommand("SELECT Ticket_ID from Ticket WHERE ([Ticket_Type]=@adult)", conn);
                        getAdultTicID.Parameters.AddWithValue("@adult", "adult");
                        OleDbCommand getChildTicID = new OleDbCommand("SELECT Ticket_ID from Ticket WHERE ([Ticket_Type]=@child)", conn);
                        getChildTicID.Parameters.AddWithValue("@child", "children");

                        OleDbDataReader readAdultTic = getAdultTicID.ExecuteReader();
                        readAdultTic.Read();
                        OleDbDataReader readChildTic = getChildTicID.ExecuteReader();
                        readChildTic.Read();

                        adult.Parameters.AddWithValue("@tic_id", readAdultTic["Ticket_ID"]);
                        adult.Parameters.AddWithValue("@mem_id", member_ID);
                        adult.Parameters.AddWithValue("@date", DateTime.Today.Date);
                        adult.Parameters.AddWithValue("@quantity", numAdult);
                        adult.Parameters.AddWithValue("@price", (numAdult * 10));
                        adult.ExecuteNonQuery();
                        int purchase_id;
                        adult.CommandText = "select @@identity";
                        purchase_id = (int)adult.ExecuteScalar();
                        OleDbCommand financeadult = new OleDbCommand("INSERT INTO Finance (Finance_Type, Finance_Date, Purchase_ID) VALUES (@type, @date, @id);", conn);
                        financeadult.Parameters.AddWithValue("@type", "Ticket");
                        financeadult.Parameters.AddWithValue("@date", DateTime.Today);
                        financeadult.Parameters.AddWithValue("@id", purchase_id);
                        financeadult.ExecuteNonQuery();


                        child.Parameters.AddWithValue("@tic_id", readChildTic["Ticket_ID"]);
                        child.Parameters.AddWithValue("@mem_id", member_ID);
                        child.Parameters.AddWithValue("@date", DateTime.Today.Date);
                        child.Parameters.AddWithValue("@quantity", numChild);
                        child.Parameters.AddWithValue("@price", (numChild * 5));
                        child.ExecuteNonQuery();
                        child.CommandText = "select @@identity";
                        purchase_id = (int)child.ExecuteScalar();
                        OleDbCommand financechild = new OleDbCommand("INSERT INTO Finance (Finance_Type, Finance_Date, Purchase_ID) VALUES (@type, @date, @id);", conn);
                        financechild.Parameters.AddWithValue("@type", "Ticket");
                        financechild.Parameters.AddWithValue("@date", DateTime.Today);
                        financechild.Parameters.AddWithValue("@id", purchase_id);
                        financechild.ExecuteNonQuery();
                        child.Dispose();
                        getAdultTicID.Dispose();
                        getChildTicID.Dispose();
                        readAdultTic.Dispose();
                        readChildTic.Dispose();
                        financeadult.Dispose();
                        financechild.Dispose();
                    }

                }
                this.Close();
                this.Dispose();
                Ticket frm = new Ticket(member_ID, visit_date, numAdult, numChild);
                frm.Show();
            }

            else if (paymentType == "Souvenir")
            {
                using (OleDbConnection conn = new OleDbConnection(connstring))
                {
                    conn.Open();
                    using (OleDbCommand cmd = new OleDbCommand("insert into [Order] ([Order_Date],[Souv_ID],[Member_ID],[Total_Price]) values (?,?,?,?)", conn))
                    {
                        cmd.Parameters.AddWithValue("@date", DateTime.Today);
                        cmd.Parameters.AddWithValue("@souv_id", Souv_ID);
                        cmd.Parameters.AddWithValue("@id", member_ID);
                        cmd.Parameters.AddWithValue("@price", Total_Price);
                        cmd.ExecuteNonQuery();
                        int order_id;
                        cmd.CommandText = "select @@identity";
                        order_id = (int)cmd.ExecuteScalar();
                        using (OleDbCommand financeorder = new OleDbCommand("INSERT INTO Finance (Finance_Type, Finance_Date, Order_ID) VALUES (@type, @date, @id);", conn))
                        {
                            financeorder.Parameters.AddWithValue("@type", "Souvenir");
                            financeorder.Parameters.AddWithValue("@date", DateTime.Today);
                            financeorder.Parameters.AddWithValue("@id", order_id);
                            financeorder.ExecuteNonQuery();
                        }

                    }
                }
                this.Close();
                this.Dispose();
                Order frm = new Order();
                frm.Show();
            }
        }
    }
}
