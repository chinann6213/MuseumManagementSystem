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
    public partial class Ticket : Form
    {
        private string member_ID;
        private DateTime visit_date;
        private int numAdult;
        private int numChild;
        public Ticket(string member_id, DateTime visit, int adult, int child)
        {
            InitializeComponent();
            member_ID = member_id;
            visit_date = visit;
            numAdult = adult;
            numChild = child;
        }

        private void Purchase_Load(object sender, EventArgs e)
        {
            string path = Directory.GetCurrentDirectory();
            string connstring = @"Provider = Microsoft.ACE.OLEDB.12.0;Data Source=" + path + @"\GameMuseumManagementSystem.accdb";

            OleDbConnection conn = new OleDbConnection(connstring); //Create connection
            conn.Open();

            OleDbCommand getAdultInfo = new OleDbCommand("SELECT * FROM Purchase WHERE ([Member_ID]=@loginMember) and ([Purchase_Date]=@nowDate) and ([Ticket_ID]=@adult)", conn);
            getAdultInfo.Parameters.AddWithValue("@loginMember", member_ID);
            getAdultInfo.Parameters.AddWithValue("@nowDate", DateTime.Today.Date);
            getAdultInfo.Parameters.AddWithValue("@adult", 1);

            OleDbCommand getChildInfo = new OleDbCommand("SELECT * FROM Purchase WHERE ([Member_ID]=@loginMember) and ([Purchase_Date]=@nowDate) and ([Ticket_ID]=@child)", conn);
            getChildInfo.Parameters.AddWithValue("@loginMember", member_ID);
            getChildInfo.Parameters.AddWithValue("@nowDate", DateTime.Today.ToString());
            getChildInfo.Parameters.AddWithValue("@child", 2.ToString());

            OleDbDataReader reader = getAdultInfo.ExecuteReader();
            reader.Read();

            OleDbDataReader child = getChildInfo.ExecuteReader();
            child.Read();

            mem_idlbl.Text = member_ID;
            order_datelbl.Text = visit_date.Year.ToString()+"/"+visit_date.Month.ToString()+"/"+visit_date.Day.ToString();
            num_adultlbl.Text = numAdult.ToString();
            num_childlbl.Text = numChild.ToString();
            total_pricelbl.Text = String.Format(System.Globalization.CultureInfo.CurrentCulture, "{0:C2}", (numAdult * 10 + numChild * 5).ToString());
            conn.Dispose();
            reader.Dispose();
            child.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }
    }
}
