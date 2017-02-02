using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;

namespace museumv4
{
    public partial class Feedback : Form
    {
        public Feedback()
        {
            InitializeComponent();
        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void feedback_Load(object sender, EventArgs e)
        {
            string path = Directory.GetCurrentDirectory();
            string connstring = @"Provider = Microsoft.ACE.OLEDB.12.0;Data Source=" + path + @"\GameMuseumManagementSystem.accdb";

            // Connect to database
            OleDbConnection conn = new OleDbConnection(connstring);
            conn.Open();

            // Non-feedback tables
            string[] tableNames = new string[13] {"Admin", "Collection", "Employee",
            "Event", "Finance", "ItemDonation", "Loan", "Member", "Order", "Purchase",
            "ShoppingCart", "Souvenir", "Ticket"};

            // Retrieve tables name only
            string[] restrictionValues = new string[4] { null, null, null, "TABLE" };
            DataTable schemaInformation = conn.GetSchema("Tables", restrictionValues);

            // Loop through tables       
            foreach (DataRow row in schemaInformation.Rows)
            {
                String tableName = row.ItemArray[2].ToString();
                // Display feedback table (if it is not part of non-feedback tables)
                if (Array.IndexOf(tableNames, tableName) == -1)
                    feedbacklist.Items.Add(tableName);
            }
        }

        private void submitbtn_Click(object sender, EventArgs e)
        {
            viewFeedback();
        }

        private void viewFeedback()
        {
            string path = Directory.GetCurrentDirectory();
            string connstring = @"Provider = Microsoft.ACE.OLEDB.12.0;Data Source=" + path + @"\GameMuseumManagementSystem.accdb";

            // Connect to database
            OleDbConnection conn = new OleDbConnection(connstring);
            conn.Open();

            // Our query on database
            OleDbCommand feedback_cmd = new OleDbCommand("SELECT * FROM " + feedbacklist.SelectedItem, conn);

            question_list_view.Columns.Add("Question", 200);
            question_list_view.Columns.Add("Answer", 200);
            question_list_view.View = View.Details;

            // Execute select query and display feedback's questions
            OleDbDataReader feedback_reader = feedback_cmd.ExecuteReader(CommandBehavior.SchemaOnly);
            var table = feedback_reader.GetSchemaTable();
            var nameCol = table.Columns["ColumnName"];
            foreach (DataRow row in table.Rows)
            {
                question_list_view.Items.Add(new ListViewItem(new String[] { row[nameCol].ToString() }));
            }
            // TODO: add input for answer
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
