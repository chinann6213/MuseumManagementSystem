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
    public partial class NewFeedback : Form
    {
        string table_name;
        string question_name;
        public NewFeedback()
        {
            InitializeComponent();
            string tableName = Microsoft.VisualBasic.Interaction.InputBox("Please enter table name: ", "Create feedback", "form name", -1, -1);
            table_name_txt.Text = tableName;
        }

        public NewFeedback(string tableName)
        {
            InitializeComponent();

            table_name = tableName;

            displayQuestions();         
        }

        private void displayQuestions()
        {
            string path = Directory.GetCurrentDirectory();
            string connstring = @"Provider = Microsoft.ACE.OLEDB.12.0;Data Source=" + path + @"\GameMuseumManagementSystem.accdb";

            // Connect to database
            OleDbConnection conn = new OleDbConnection(connstring);
            conn.Open();

            // Our query on database
            OleDbCommand feedback_cmd = new OleDbCommand("SELECT * FROM " + table_name, conn);

            // Execute select query and display feedback's questions
            OleDbDataReader feedback_reader = feedback_cmd.ExecuteReader(CommandBehavior.SchemaOnly);
            var table = feedback_reader.GetSchemaTable();
            var nameCol = table.Columns["ColumnName"];
            foreach (DataRow row in table.Rows)
            {
                question_list.Items.Add(row[nameCol]);
            }
        }

        private void newbtn_Click(object sender, EventArgs e)
        {
        }

        private void type_cbox_SelectedIndexChanged(object sender, EventArgs e)
        {    
        }

        private void numchoice_cbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            addQuestion();
        }

        private void addQuestion()
        {
            string path = Directory.GetCurrentDirectory();
            string connstring = @"Provider = Microsoft.ACE.OLEDB.12.0;Data Source=" + path + @"\GameMuseumManagementSystem.accdb";

            OleDbConnection conn = new OleDbConnection(connstring); //Create connection
            conn.Open();

            string tableName = "[" + table_name_txt.Text.ToString() + "]";

            try
            {
                OleDbCommand cmmd = new OleDbCommand("", conn);
                cmmd.CommandText = "CREATE TABLE " + tableName + " ( [ID] Counter Primary Key, [" + question_txt.Text + "] Text)";
                if (conn.State == ConnectionState.Open)
                {
                    cmmd.ExecuteNonQuery();
                    MessageBox.Show("Add!");
                }
            }
            catch (OleDbException tableexists)
            {
                OleDbCommand cmd = new OleDbCommand("", conn);
                cmd.CommandText = "ALTER TABLE " + tableName + " ADD [" + question_txt.Text + "] Text";
                if (conn.State == ConnectionState.Open)
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Add!");
                }
            }

            question_list.Items.Add(question_txt.Text);
            feedback_panel.Visible = false;

        }

        private void editbtn_Click(object sender, EventArgs e)
        {
            editQuestion();
        }

        private void editQuestion()
        {
            edit_panel.Visible = true;
            feedback_panel.Visible = false;

            question_name = question_list.GetItemText(question_list.SelectedItem);
            edit_q_txt.Text = question_list.GetItemText(question_list.SelectedItem);
        }

        private void OK_btn_Click(object sender, EventArgs e)
        {
            insertQuestion();
        }

        private void insertQuestion()
        {
            if (question_name != edit_q_txt.Text)
            {
                DialogResult result = MessageBox.Show("Are you sure?", "Confirm Edit", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    string path = Directory.GetCurrentDirectory();
                    string connstring = @"Provider = Microsoft.ACE.OLEDB.12.0;Data Source=" + path + @"\GameMuseumManagementSystem.accdb";

                    OleDbConnection conn = new OleDbConnection(connstring); //Create connection
                    conn.Open();

                    // Add new column
                    OleDbCommand cmmd = new OleDbCommand("", conn);
                    cmmd.CommandText = "ALTER TABLE [" + table_name + "] ADD [" + edit_q_txt.Text + "] TEXT";
                    cmmd.ExecuteNonQuery();

                    // New column = previous column
                    cmmd = new OleDbCommand("", conn);
                    cmmd.CommandText = "UPDATE [" + table_name + "] SET [" + edit_q_txt.Text + "] = [" + question_name + "]";
                    cmmd.ExecuteNonQuery();

                    // Remove previous column
                    cmmd = new OleDbCommand("", conn);
                    cmmd.CommandText = "ALTER TABLE [" + table_name + "] DROP [" + question_name + "]";
                    cmmd.ExecuteNonQuery();

                    MessageBox.Show("Edit successfully.");
                }
                edit_panel.Visible = false;
                question_list.Items.Clear();
                displayQuestions();
            }

        }
        private void removebtn_Click(object sender, EventArgs e)
        {
            removeQuestion();
        }

        private void removeQuestion()
        {
            DialogResult result = MessageBox.Show("Are you sure?", "Confirm Delete", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                string path = Directory.GetCurrentDirectory();
                string connstring = @"Provider = Microsoft.ACE.OLEDB.12.0;Data Source=" + path + @"\GameMuseumManagementSystem.accdb";

                OleDbConnection conn = new OleDbConnection(connstring); //Create connection
                conn.Open();

                // Remove column
                OleDbCommand cmd = new OleDbCommand("", conn);
                string questionToRemove = question_list.GetItemText(question_list.SelectedItem);
                cmd.CommandText = "ALTER TABLE [" + table_name + "] DROP [" + questionToRemove + "]";
                cmd.ExecuteNonQuery();

                MessageBox.Show("Edit successfully.");
            }
            question_list.Items.Clear();
            displayQuestions();
        }
     }
}
