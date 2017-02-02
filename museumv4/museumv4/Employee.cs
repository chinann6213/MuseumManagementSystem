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
    public partial class Employee : Form
    {
        string function = "view"; //indicate which function view , insert or edit
        string name = "";//collection name
        ListBox listbox;//pass in listbox to force update
        ListBox listbox2;//pass in listbox to force update
        string Admin_ID;

        //default constructor
        public Employee(string function, string name,ref ListBox listbox,string admin_id,ref ListBox listbox2)
        {
            InitializeComponent();
            this.function = function;
            this.name = name;
            this.listbox = listbox;
            this.listbox2 = listbox2;
            Admin_ID = admin_id;
        }
        //end default constructor

        //Get value from database
        public string GetValue(OleDbCommand cmd, string column_name)
        {
            cmd.CommandText = "select " + column_name + " from Employee where ([Emp_Name]=@name)";
            cmd.Parameters.AddWithValue("@name", name);
            using (OleDbDataReader reader = cmd.ExecuteReader())
            {
                reader.Read();
                return reader[column_name].ToString();
            }
        }
        //end GetValue()

        private void employee_details_Load(object sender, EventArgs e)
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
                            nametxt.Text = name;
                            wrktxt.Text = GetValue(cmd, "Emp_WorkingHrs");
                            if(GetValue(cmd,"Last_CheckIn").Equals(""))
                            {
                                indate.Format = DateTimePickerFormat.Custom;
                                indate.CustomFormat = " ";
                            }
                            if(GetValue(cmd, "Last_CheckOut").Equals(""))
                            {
                                outdate.Format = DateTimePickerFormat.Custom;
                                outdate.CustomFormat = " ";
                            }
                            break;
                        case "insert":
                            this.Text = "Insert Employee";
                            nametxt.ReadOnly = false;
                            wrktxt.Text = "0";
                            wrktxt.ReadOnly = false;
                            indate.Format = DateTimePickerFormat.Custom;
                            indate.CustomFormat = " ";
                            outdate.Format = DateTimePickerFormat.Custom;
                            outdate.CustomFormat = " ";
                            confirmbtn.Visible = true;
                            break;
                        case "edit":
                            this.Text = "Edit Employee";
                            nametxt.ReadOnly = false;
                            wrktxt.Text = "0";
                            wrktxt.ReadOnly = false;
                            indate.Format = DateTimePickerFormat.Custom;
                            indate.CustomFormat = " ";
                            outdate.Format = DateTimePickerFormat.Custom;
                            outdate.CustomFormat = " ";
                            confirmbtn.Visible = true;
                            break;
                    }
                }
            }
        }

        //confirm button clicked
        private void confirmbtn_Click(object sender, EventArgs e)
        {
            confirmEditInsert();
        }

        private void confirmEditInsert()
        {
            bool error = false;
            string path = Directory.GetCurrentDirectory();
            string connstring = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + path + @"\GameMuseumManagementSystem.accdb";
            if (nametxt.Text.Equals(""))
                error = true;
            if (wrktxt.Text.Equals(""))
                error = true;
            int n;
            bool isNumeric = int.TryParse(wrktxt.Text, out n);
            if (!isNumeric)
                error = true;
            if (!error)
            {
                int check = 0;
                using (OleDbConnection conn = new OleDbConnection(connstring))
                {
                    using (OleDbCommand cmd = new OleDbCommand())
                    {
                        cmd.Connection = conn;
                        conn.Open();
                        cmd.CommandText = "select count(*) from Employee where Emp_Name=@name";
                        cmd.Parameters.AddWithValue("@name", nametxt.Text);
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
                                cmd.CommandText = "insert into Employee ([Emp_Name],[Emp_WorkingHrs],[Admin_ID]) values (?,?,?)";
                                cmd.Parameters.AddWithValue("@name", nametxt.Text);
                                cmd.Parameters.AddWithValue("@wrkhrs", wrktxt.Text);
                                cmd.Parameters.AddWithValue("@id", Admin_ID);
                                cmd.ExecuteNonQuery();
                                listbox.Items.Add(nametxt.Text);
                                listbox.Update();
                                listbox2.Items.Add(nametxt.Text);
                                listbox2.Update();
                                this.Close();
                                this.Dispose();
                            }
                            else
                            {
                                MessageBox.Show("This employee already existed");
                            }

                        }
                        else
                        {
                            cmd.CommandText = "update Employee set Emp_Name=@name,Emp_WorkingHrs=@wrkhrs,Admin_ID=@id where Emp_Name=@default";
                            cmd.Parameters.AddWithValue("@name", nametxt.Text);
                            cmd.Parameters.AddWithValue("@wrkhrs", wrktxt.Text);
                            cmd.Parameters.AddWithValue("@id", Admin_ID);
                            cmd.Parameters.AddWithValue("@default", name);
                            cmd.ExecuteNonQuery();
                            int index = listbox.FindString(name);
                            listbox.Items[index] = nametxt.Text;
                            listbox.Update();
                            listbox2.Items[index] = nametxt.Text;
                            listbox2.Update();
                            this.Close();
                            this.Dispose();
                        }
                    }
                }
            }
            else
            {
                if (!isNumeric)
                    MessageBox.Show("Please fill a integer in working hour");
                else
                    MessageBox.Show("Please fill up all information");
            }

        }

        private void cancelbtn_Click_1(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }
    }
}
