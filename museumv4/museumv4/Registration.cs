using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// @author Kia Kin > START
using System.Data.OleDb;
using System.IO;
// END <

namespace museumv4
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        // @author Kia Kin > START
        // Used in Main.cs for Guest
        private void okbtn_Click(object sender, EventArgs e)
        {
            confirmRegister();
        }

        private void confirmRegister()
        {
            String name = nametxt.Text;
            String email = emailtxt.Text;
            String password = pwtxt.Text;
            String confirmPw = confirmtxt.Text;
            int ampersandIndex = emailtxt.Text.IndexOf("@");
            int dotcomIndex = emailtxt.Text.LastIndexOf(".com");

            // Empty fields
            if (String.IsNullOrWhiteSpace(name) || String.IsNullOrWhiteSpace(email)
                || String.IsNullOrWhiteSpace(password) || String.IsNullOrWhiteSpace(confirmPw))
                MessageBox.Show("Some fields are empty.", "Register");
            // 1. @ is not followed by .com
            // 2. @ or .com is not typed
            else if (!(ampersandIndex < dotcomIndex))
                MessageBox.Show("Email field contains an improper value.", "Register");
            // Empty before @
            else if (ampersandIndex == 0)
                MessageBox.Show("Email field contains an improper value.", "Register");
            // Empty between @ and .com
            else if (email.Substring(ampersandIndex, dotcomIndex - ampersandIndex).Length <= 1)
                MessageBox.Show("Email field contains an improper value.", "Register");
            // Password different than confirm password
            else if (password != confirmPw)
                MessageBox.Show("Password does not match the confirm password.", "Register");
            else
            {
                string path = Directory.GetCurrentDirectory();
                string connstring = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + path + @"\GameMuseumManagementSystem.accdb";

                // Connect to database
                OleDbConnection conn = new OleDbConnection(connstring);
                conn.Open();

                // Our query on database
                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandText = "INSERT INTO Member (Member_Name, Member_Password, Member_Email) VALUES (@name, @password, @email);";
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@password", password);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Connection = conn;

                // Execute insert query 
                cmd.ExecuteNonQuery();

                // Close connection
                conn.Close();

                MessageBox.Show("Register successfully.", "Register");
                this.Close();
                this.Dispose();
            }
        }
        // END < 
    }
}
