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
    public partial class Event : Form
    {
        string function = "view"; //indicate which function view , insert or edit
        string name = "";//event title
        ListBox listbox;//pass in listbox to force update 
        string Admin_ID;

        //default constructor
        public Event(string function, string name,ref ListBox listbox,string admin_id)
        {
            InitializeComponent();
            this.function = function;
            this.name = name;
            this.listbox = listbox;
            Admin_ID = admin_id;
        }
        //end default constructor

        //Get value from database
        public string GetValue(OleDbCommand cmd, string column_name)
        {
            cmd.CommandText = "select " + column_name + " from Event where ([Event_Title]=@name)";
            cmd.Parameters.AddWithValue("@name", name);
            using (OleDbDataReader reader = cmd.ExecuteReader())
            {
                reader.Read();
                return reader[column_name].ToString();
            }
        }
        //end GetValue()

        //when the class load
        private void event_detail_Load(object sender, EventArgs e)
        {
            string path = Directory.GetCurrentDirectory();
            string connstring = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + path + @"\GameMuseumManagementSystem.accdb";
            using (OleDbConnection conn = new OleDbConnection(connstring))
            {
                using (OleDbCommand cmd = new OleDbCommand())
                {
                    cmd.Connection = conn;
                    conn.Open();
                    switch (function)
                    {
                        case "view":
                            titletxt.Text = name;
                            date.Text = GetValue(cmd, "Event_Date");
                            detailtxt.Text = GetValue(cmd, "Event_Detail");
                            break;
                        case "insert":
                            this.Text = "Insert Event";
                            titletxt.ReadOnly = false;
                            date.Enabled = true;
                            detailtxt.ReadOnly = false;
                            confirmbtn.Visible = true;
                            break;
                        case "edit":
                            this.Text = "Edit Event";
                            titletxt.ReadOnly = false;
                            date.Enabled = true;
                            detailtxt.ReadOnly = false;
                            confirmbtn.Visible = true;
                            break;
                    }
                }
            }
        }//end load()

        //confirm button clicked
        private void confirmbtn_Click_1(object sender, EventArgs e)
        {
            confirmEditInsert();
        }//end confirm button click

        private void confirmEditInsert()
        {
            bool error = false;
            if (titletxt.Text.Equals(""))
                error = true;
            if (detailtxt.Text.Equals(""))
                error = true;
            if (date.Value > DateTime.Today)
                error = true;
            if (!error)
            {
                int check = 0;
                string path = Directory.GetCurrentDirectory();
                string connstring = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + path + @"\GameMuseumManagementSystem.accdb";
                using (OleDbConnection conn = new OleDbConnection(connstring))
                {
                    using (OleDbCommand cmd = new OleDbCommand())
                    {
                        cmd.Connection = conn;
                        conn.Open();
                        cmd.CommandText = "select count(*) from Event where Event_Title=@name";
                        cmd.Parameters.AddWithValue("@name", titletxt.Text);
                        check = (int)cmd.ExecuteScalar();
                    }
                }
                using (OleDbConnection conn = new OleDbConnection(connstring))
                {
                    using (OleDbCommand cmd = new OleDbCommand())
                    {
                        cmd.Connection = conn;
                        conn.Open();
                        if (function.Equals("insert"))
                        {
                            if (check == 0)
                            {
                                cmd.CommandText = "insert into Event ([Event_Title],[Event_Date],[Event_Detail],[Admin_ID]) values (?,?,?,?)";
                                cmd.Parameters.AddWithValue("@title", titletxt.Text);
                                cmd.Parameters.AddWithValue("@date", date.Value.Date.ToString());
                                cmd.Parameters.AddWithValue("@detail", detailtxt.Text);
                                cmd.Parameters.AddWithValue("@id", Admin_ID);
                                cmd.ExecuteNonQuery();
                                listbox.Items.Add(titletxt.Text);
                                listbox.Update();
                                this.Close();
                                this.Dispose();
                            }
                            else
                            {
                                MessageBox.Show("This event already existed");
                            }
                        }
                        else
                        {
                            cmd.CommandText = "update Event set Event_Title=@title,Event_Date=@date,Event_Detail=@detail,Admin_ID=@id " +
                                              "where Event_Title=@default";
                            cmd.Parameters.AddWithValue("@title", titletxt.Text);
                            cmd.Parameters.AddWithValue("@date", date.Value.Date.ToString());
                            cmd.Parameters.AddWithValue("@detail", detailtxt.Text);
                            cmd.Parameters.AddWithValue("@id", Admin_ID);
                            cmd.Parameters.AddWithValue("@default", name);
                            cmd.ExecuteNonQuery();
                            int index = listbox.FindString(name);
                            listbox.Items[index] = titletxt.Text;
                            listbox.Update();
                            this.Close();
                            this.Dispose();
                        }
                    }
                }
            }
            else
            {
                if (date.Value > DateTime.Today)
                    MessageBox.Show("The date must be smaller than today");
                else
                    MessageBox.Show("Please fill up all information");
            }
        }

        //cancel button clicked
        private void cancelbtn_Click_1(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }//end cancel button
    }
}
