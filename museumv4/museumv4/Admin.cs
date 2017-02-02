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
    public partial class Admin : Form
    {
        static string path = Directory.GetCurrentDirectory();
        static string connstring = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + path + @"\GameMuseumManagementSystem.accdb";
        string Admin_ID;
        //default constructor
        public Admin(string admin_ID)
        {
            InitializeComponent();
            Admin_ID = admin_ID;
            this.donationLB_admin.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.donationLB_admin.DrawItem += new DrawItemEventHandler(this.donationLB_admin_DrawItem);
            this.loanLB_admin.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.loanLB_admin.DrawItem += new DrawItemEventHandler(this.loanLB_admin_DrawItem);
            this.checkinLB_admin.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.checkinLB_admin.DrawItem += new DrawItemEventHandler(this.checkinLB_admin_DrawItem);
        }
        //end default constructor

        //function to set the listbox to display the data name
        public void SetDisplayData(ref ListBox dataListbox, String tableName, String columnName)
        {
            string path = Directory.GetCurrentDirectory();
            string connstring = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + path + @"\GameMuseumManagementSystem.accdb";
            using (OleDbConnection conn = new OleDbConnection(connstring))
            {
                using (OleDbCommand cmd = new OleDbCommand())
                {
                    cmd.Connection = conn;
                    conn.Open();
                    cmd.CommandText = "select * from " + tableName;
                    using (OleDbDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            dataListbox.Items.Add(reader[columnName].ToString());
                        }
                    }
                }
            }
        }
        //end SetDisplayData()

        //Get value from database with specific value
        public string GetValue(OleDbCommand cmd, string table_name, string column_name, string target, string target_column)
        {
            cmd.CommandText = "select " + column_name + " from " + table_name + " where (["+target_column+"]="+target+")";
            using (OleDbDataReader reader = cmd.ExecuteReader())
            {
                reader.Read();
                    return reader[column_name].ToString();
            }
        }
        //end GetValue()

        private List<string> GetGridData(string column_name)
        {
            List<string> datalist = new List<string>();
            string path = Directory.GetCurrentDirectory();
            string connstring = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + path + @"\GameMuseumManagementSystem.accdb";
            using (OleDbConnection conn = new OleDbConnection(connstring))
            {
                using (OleDbCommand cmd = new OleDbCommand())
                {
                    cmd.Connection = conn;
                    conn.Open();
                    cmd.CommandText = "select "+column_name+" from Finance";
                    using (OleDbDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            datalist.Add(reader[column_name].ToString());
                        }
                    }
                }
            }
            return datalist;
        }

        private string getRevenueSpent(string type,string id)
        {
            string result = "";
            using (OleDbConnection conn = new OleDbConnection(connstring))
            {
                using (OleDbCommand cmd = new OleDbCommand())
                {
                    cmd.Connection = conn;
                    conn.Open();
                    if (type.Equals("Souvenir"))
                    {
                        string target_id = GetValue(cmd, "Finance", "Order_ID", id, "Finance_ID");
                        result = GetValue(cmd, "[Order]", "Total_Price", target_id, "Order_ID");
                    }
                    if (type.Equals("Donation"))
                    {
                        string target_id = GetValue(cmd, "Finance", "Item_ID", id, "Finance_ID");
                        result = GetValue(cmd, "ItemDonation", "Selling_Price", target_id, "Item_ID");
                    }
                    if (type.Equals("Ticket"))
                    {
                        string target_id = GetValue(cmd, "Finance", "Purchase_ID", id, "Finance_ID");
                        result = GetValue(cmd, "Purchase", "Total_Price", target_id, "Purchase_ID");
                    }
                    if (type.Equals("Loan"))
                    {
                        string target_id = GetValue(cmd, "Finance", "Loan_ID", id, "Finance_ID");
                        result = GetValue(cmd, "Loan", "Loan_Price", target_id, "Loan_ID");
                    }

                }
            }
            return result;
        }

        //function to set the datagridview in finance
        private void SetGridView()
        {
            List<List<string>> griddata = new List<List<string>>();
            List<string> id = GetGridData("Finance_ID");
            List<string> date = GetGridData("Finance_Date");
            List<string> type = GetGridData("Finance_Type");
            griddata.Add(id);
            griddata.Add(date);
            griddata.Add(type);
            //MessageBox(id[])
            for(int i=0;i<id.Count();i++)
            {
                if (type[i].Equals("Donation"))
                {
                    spentgrid.Rows.Add(id[i], date[i], type[i], getRevenueSpent(type[i], id[i]));
                }
                else
                {
                    revenuegrid.Rows.Add(id[i], date[i], type[i], getRevenueSpent(type[i], id[i]));
                }
            }
            


        }
        //end SetGridView();

        //when the admin load
        private void Admin_Load(object sender, EventArgs e)
        {
            //set listbox value
            SetDisplayData(ref collectionLB_admin, "Collection", "Coll_Name");
            SetDisplayData(ref eventLB_admin, "Event", "Event_Title");
            SetDisplayData(ref souvenirLB_admin, "Souvenir", "Souv_Name");
            SetDisplayData(ref donationLB_admin, "ItemDonation", "Item_Name");
            SetDisplayData(ref loanLB_admin, "Loan", "Loan_ID");
            SetDisplayData(ref employeeLB_admin, "Employee", "Emp_Name");
            SetDisplayData(ref checkinLB_admin, "Employee", "Emp_Name");
            SetGridView();
            using (OleDbConnection conn = new OleDbConnection(connstring))
            {
                using (OleDbCommand cmd = new OleDbCommand())
                {
                    cmd.Connection = conn;
                    conn.Open();
                    cmd.CommandText = "select Admin_Name from Admin where Admin_ID=@id";
                    cmd.Parameters.AddWithValue("@id", Admin_ID);
                    using (OleDbDataReader reader = cmd.ExecuteReader())
                    {
                        reader.Read();
                        label2.Text = "Welcome, " + reader["Admin_Name"].ToString();
                    }
                }
            }
        }
        //end admin load

        //method to check whether user select a item or not
        private bool null_check()
        {
            bool null_check = false;
            switch(viewtabcontrol.SelectedIndex)
            {
                case 0:
                    if (collectionLB_admin.SelectedItem == null)
                        null_check = true;
                    break;
                case 1:
                    if (eventLB_admin.SelectedItem == null)
                        null_check = true;
                    break;
                case 2:
                    if (souvenirLB_admin.SelectedItem == null)
                        null_check = true;
                    break;
            }
            if(null_check)
                MessageBox.Show("Please select an item in " + viewtabcontrol.SelectedTab.Text + " tab");
            return null_check;
        }
        //end null_check()

        //view details button is clicked(complete)
        private void viewdetailsbtn_Click(object sender, EventArgs e)
        {
            bool error = null_check();
            if(!error)
            {
                switch (viewtabcontrol.SelectedIndex)
                {
                    case 0:
                        Collection frm = new Collection("view", collectionLB_admin.SelectedItem.ToString(), Admin_ID, ref collectionLB_admin);
                        frm.Show();
                        break;
                    case 1:
                        Event frm1 = new Event("view", eventLB_admin.SelectedItem.ToString(),ref eventLB_admin,Admin_ID);
                        frm1.Show();
                        break;
                    case 2:
                        Souvenir frm2 = new Souvenir("view", souvenirLB_admin.SelectedItem.ToString(),ref souvenirLB_admin,Admin_ID);
                        frm2.Show();
                        break;
                }

            }   
        }//end view details button

        //insert button clicked(complete)
        private void insertbtn_Click(object sender, EventArgs e)
        {
            //display different data window according the tab selected
            insertInfo();
            //e.g : event tab is select then it should display a even details window 
            
        }//end insert button

        private void insertInfo()
        {
            switch (viewtabcontrol.SelectedIndex)
            {
                case 0:
                    Collection frm = new Collection("insert", " ", Admin_ID, ref collectionLB_admin);
                    frm.Show();
                    break;
                case 1:
                    Event frm1 = new Event("insert", " ", ref eventLB_admin, Admin_ID);
                    frm1.Show();
                    break;
                case 2:
                    Souvenir frm2 = new Souvenir("insert", " ", ref souvenirLB_admin, Admin_ID);
                    frm2.Show();
                    break;
            }
        }
        //delete button clicked(complete)
        private void deletebtn_Click(object sender, EventArgs e)
        {
            deleteInfo();
        }
        //end delete button

        private void deleteInfo()
        {
            bool error = null_check();
            if (!error)
            {
                int selected_tab = viewtabcontrol.SelectedIndex;
                string path = Directory.GetCurrentDirectory();
                string connstring = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + path + @"\GameMuseumManagementSystem.accdb";
                using (OleDbConnection conn = new OleDbConnection(connstring))
                {
                    using (OleDbCommand cmd = new OleDbCommand())
                    {
                        cmd.Connection = conn;
                        conn.Open();
                        string table_name = viewtabcontrol.SelectedTab.Text;
                        cmd.CommandText = "delete * from " + table_name + " where ([Coll_Name])=@name";
                        if (viewtabcontrol.SelectedTab.Text.Equals("Collection"))
                        {
                            cmd.CommandText = "delete * from " + table_name + " where ([Coll_Name])=@name";
                            cmd.Parameters.AddWithValue("@name", collectionLB_admin.SelectedItem.ToString());
                            collectionLB_admin.Items.Remove(collectionLB_admin.SelectedItem.ToString());
                            collectionLB_admin.Update();
                        }
                        if (viewtabcontrol.SelectedTab.Text.Equals("Event"))
                        {
                            cmd.CommandText = "delete * from " + table_name + " where ([Event_Title])=@name";
                            cmd.Parameters.AddWithValue("@name", eventLB_admin.SelectedItem.ToString());
                            eventLB_admin.Items.Remove(eventLB_admin.SelectedItem.ToString());
                            eventLB_admin.Update();
                        }
                        if (viewtabcontrol.SelectedTab.Text.Equals("Souvenir"))
                        {
                            cmd.CommandText = "delete * from " + table_name + " where ([Souv_Name])=@name";
                            cmd.Parameters.AddWithValue("@name", souvenirLB_admin.SelectedItem.ToString());
                            souvenirLB_admin.Items.Remove(souvenirLB_admin.SelectedItem.ToString());
                            souvenirLB_admin.Update();
                        }
                        cmd.ExecuteNonQuery();
                    }
                }

            }
        }

        //edit button clicked(complete)
        private void editbtn_Click(object sender, EventArgs e)
        {
            editInfo();
        }//end edit button

        private void editInfo()
        {
            bool error = null_check();
            if (!error)
            {
                switch (viewtabcontrol.SelectedIndex)
                {
                    case 0:
                        Collection frm = new Collection("edit", collectionLB_admin.SelectedItem.ToString(), Admin_ID, ref collectionLB_admin);
                        frm.Show();
                        break;
                    case 1:
                        Event frm1 = new Event("edit", eventLB_admin.SelectedItem.ToString(), ref eventLB_admin, Admin_ID);
                        frm1.Show();
                        break;
                    case 2:
                        Souvenir frm2 = new Souvenir("edit", souvenirLB_admin.SelectedItem.ToString(), ref souvenirLB_admin, Admin_ID);
                        frm2.Show();
                        break;
                }
            }
        }

        //method to check whether user select a item or not
        private bool null_check_approve()
        {
            bool null_check = false;
            switch (approvetabcontrol.SelectedIndex)
            {
                case 0:
                    if (donationLB_admin.SelectedItem == null)
                        null_check = true;
                    break;
                case 1:
                    if (loanLB_admin.SelectedItem == null)
                        null_check = true;
                    break;
            }
            if (null_check)
                MessageBox.Show("Please select an item in " + approvetabcontrol.SelectedTab.Text + " tab");
            return null_check;
        }
        //end null_check()

        //view detail button in approve
        private void viewdetailbtn_approve_Click(object sender, EventArgs e)
        {
            viewDonateLoanDetail();
            
        }//end view detail

        private void viewDonateLoanDetail()
        {
            bool error = null_check_approve();
            if (!error)
            {
                switch (approvetabcontrol.SelectedIndex)
                {
                    case 0:
                        ItemDonation frm = new ItemDonation(donationLB_admin.SelectedItem.ToString());
                        frm.Show();
                        break;
                    case 1:
                        Loan frm1 = new Loan(loanLB_admin.SelectedItem.ToString());
                        frm1.Show();
                        break;
                }
            }
        }

        //overide this function to let row color in listbox change when approved
        private void donationLB_admin_DrawItem(object sender, DrawItemEventArgs e)
        {
            // Draw the background of the ListBox control for each item.
            e.DrawBackground();
            // Define the default color of the brush as black.
            Brush myBrush = Brushes.Black;

            Graphics g = e.Graphics;
            string path = Directory.GetCurrentDirectory();
            string connstring = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + path + @"\GameMuseumManagementSystem.accdb";
            bool approve;
            using (OleDbConnection conn = new OleDbConnection(connstring))
            {
                using (OleDbCommand cmd = new OleDbCommand())
                {
                    cmd.Connection = conn;
                    conn.Open();
                    cmd.CommandText = "select Donation_Status from ItemDonation where ([Item_Name])=@name";
                    cmd.Parameters.AddWithValue("@name", donationLB_admin.Items[e.Index].ToString());
                    using (OleDbDataReader reader = cmd.ExecuteReader())
                    {
                        reader.Read();
                        approve = (bool)reader["Donation_Status"];
                    }
                }
            }
            if(approve)
                g.FillRectangle(new SolidBrush(Color.Green), e.Bounds);
            e.Graphics.DrawString(donationLB_admin.Items[e.Index].ToString(),e.Font, myBrush, e.Bounds, StringFormat.GenericDefault);
            e.DrawFocusRectangle();
        }//end drawitem function

        //overide this function to let row color in listbox change when approved
        private void loanLB_admin_DrawItem(object sender, DrawItemEventArgs e)
        {
            // Draw the background of the ListBox control for each item.
            e.DrawBackground();
            // Define the default color of the brush as black.
            Brush myBrush = Brushes.Black;

            Graphics g = e.Graphics;
            string path = Directory.GetCurrentDirectory();
            string connstring = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + path + @"\GameMuseumManagementSystem.accdb";
            bool approve;
            using (OleDbConnection conn = new OleDbConnection(connstring))
            {
                using (OleDbCommand cmd = new OleDbCommand())
                {
                    cmd.Connection = conn;
                    conn.Open();
                    cmd.CommandText = "select Loan_Status from Loan where ([Loan_ID])=@id";
                    cmd.Parameters.AddWithValue("@id",loanLB_admin.Items[e.Index].ToString());
                    using (OleDbDataReader reader = cmd.ExecuteReader())
                    {
                        reader.Read();
                        approve = (bool) reader["Loan_Status"];
                    }
                }
            }
            if (approve)
                g.FillRectangle(new SolidBrush(Color.Green), e.Bounds);
            e.Graphics.DrawString(loanLB_admin.Items[e.Index].ToString(), e.Font, myBrush, e.Bounds, StringFormat.GenericDefault);
            e.DrawFocusRectangle();
        }//end drawitem function


        //Get value from database with employee
        public string getEmpInfo(OleDbCommand cmd, string column_name , string target)
        {
            cmd.CommandText = "select " + column_name + " from Employee where ([Emp_Name]=@target)";
            cmd.Parameters.AddWithValue("@target", target);
            using (OleDbDataReader reader = cmd.ExecuteReader())
            {
                reader.Read();
                return reader[column_name].ToString();
            }
        }
        //end GetValue()

        //overide this function to let row color in listbox change when approved
        private void checkinLB_admin_DrawItem(object sender, DrawItemEventArgs e)
        {
            // Draw the background of the ListBox control for each item.
            e.DrawBackground();
            // Define the default color of the brush as black.
            Brush myBrush = Brushes.Black;

            Graphics g = e.Graphics;
            string path = Directory.GetCurrentDirectory();
            string connstring = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + path + @"\GameMuseumManagementSystem.accdb";
            using (OleDbConnection conn = new OleDbConnection(connstring))
            {
                using (OleDbCommand cmd = new OleDbCommand())
                {
                    cmd.Connection = conn;
                    conn.Open();
                    if(getEmpInfo(cmd, "Last_CheckIn", checkinLB_admin.Items[e.Index].ToString()).Equals(""))
                    {
                        if(getEmpInfo(cmd, "Last_CheckOut", checkinLB_admin.Items[e.Index].ToString()).Equals(""))
                            { }
                        else
                            g.FillRectangle(new SolidBrush(Color.Red), e.Bounds);
                    }
                    else
                        g.FillRectangle(new SolidBrush(Color.Green), e.Bounds);
                }
            }
            e.Graphics.DrawString(checkinLB_admin.Items[e.Index].ToString(), e.Font, myBrush, e.Bounds, StringFormat.GenericDefault);
            e.DrawFocusRectangle();
        }//end drawitem function

        //approve button in loan/donation
        private void approvebtn_Click(object sender, EventArgs e)
        {
            approveDonateLoan();
        }//end approve button in loan/donation

        private void approveDonateLoan()
        {
            bool error = null_check_approve();
            if (!error)
            {
                string path = Directory.GetCurrentDirectory();
                string connstring = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + path + @"\GameMuseumManagementSystem.accdb";
                //approve for donation
                if (approvetabcontrol.SelectedIndex == 0)
                {
                    string check_status;
                    using (OleDbConnection conn = new OleDbConnection(connstring))
                    {
                        using (OleDbCommand cmd = new OleDbCommand())
                        {

                            cmd.Connection = conn;
                            conn.Open();
                            cmd.CommandText = "select Donation_Status from ItemDonation where Item_Name=@name";
                            cmd.Parameters.AddWithValue("@name", donationLB_admin.SelectedItem.ToString());
                            using (OleDbDataReader reader = cmd.ExecuteReader())
                            {
                                reader.Read();
                                check_status = reader["Donation_Status"].ToString();
                            }
                        }
                    }
                    if (check_status.Equals("False"))
                    {
                        string item_detail;
                        string loan_charge;
                        string item_id;
                        using (OleDbConnection conn = new OleDbConnection(connstring))
                        {
                            using (OleDbCommand cmd = new OleDbCommand())
                            {
                                cmd.Connection = conn;
                                conn.Open();
                                cmd.CommandText = "select * from ItemDonation where ([Item_Name]=@target)";
                                cmd.Parameters.AddWithValue("@target", donationLB_admin.SelectedItem.ToString());
                                using (OleDbDataReader reader = cmd.ExecuteReader())
                                {
                                    reader.Read();
                                    item_detail = reader["Item_Detail"].ToString();
                                    loan_charge = reader["Selling_Price"].ToString();
                                    item_id = reader["Item_ID"].ToString();
                                }
                            }
                        }
                        using (OleDbConnection conn = new OleDbConnection(connstring))
                        {
                            using (OleDbCommand cmd = new OleDbCommand())
                            {

                                cmd.Connection = conn;
                                conn.Open();
                                cmd.CommandText = "insert into Collection ([Coll_Name],[Coll_Detail],[Coll_Date],[Coll_Status],[Loan_Charge]) values (?,?,?,?,?)";
                                cmd.Parameters.AddWithValue("@name", donationLB_admin.SelectedItem.ToString());
                                cmd.Parameters.AddWithValue("@detail", item_detail);
                                cmd.Parameters.AddWithValue("@date", DateTime.Today.ToString());
                                bool value = true;
                                cmd.Parameters.AddWithValue("@value", value);
                                cmd.Parameters.AddWithValue("@charge", loan_charge);
                                cmd.ExecuteNonQuery();
                            }
                        }
                        using (OleDbConnection conn = new OleDbConnection(connstring))
                        {
                            using (OleDbCommand cmd = new OleDbCommand())
                            {

                                cmd.Connection = conn;
                                conn.Open();
                                cmd.CommandText = "update ItemDonation set Donation_Status=@status,Admin_ID=@id where Item_Name=@name";
                                bool value = true;
                                cmd.Parameters.AddWithValue("@status", value);
                                cmd.Parameters.AddWithValue("@id", Admin_ID);
                                cmd.Parameters.AddWithValue("@name", donationLB_admin.SelectedItem.ToString());
                                cmd.ExecuteNonQuery();
                            }
                        }
                        using (OleDbConnection conn = new OleDbConnection(connstring))
                        {
                            using (OleDbCommand finance = new OleDbCommand())
                            {

                                finance.Connection = conn;
                                conn.Open();
                                finance.CommandText = "INSERT INTO Finance (Finance_Type, Finance_Date, Item_ID,Admin_ID) VALUES (@type, @date, @id,@admin_id);";
                                finance.Parameters.AddWithValue("@type", "Donation");
                                finance.Parameters.AddWithValue("@date", DateTime.Today);
                                finance.Parameters.AddWithValue("@id", item_id);
                                finance.Parameters.AddWithValue("@admin_id", Admin_ID);
                                finance.ExecuteNonQuery();
                            }
                        }

                        collectionLB_admin.Items.Add(donationLB_admin.SelectedItem.ToString());
                        collectionLB_admin.Update();
                        int index = donationLB_admin.FindString(donationLB_admin.SelectedItem.ToString());
                        donationLB_admin.Items[index] = donationLB_admin.SelectedItem.ToString();
                        donationLB_admin.Update();
                        revenuegrid.Rows.Clear();
                        spentgrid.Rows.Clear();
                        SetGridView();
                        revenuegrid.Update();
                        spentgrid.Update();
                    }
                    else
                    {
                        MessageBox.Show("The donation approved ");
                    }

                }//end approve for donation

                //approve for loan
                else
                {
                    string check_status;
                    using (OleDbConnection conn = new OleDbConnection(connstring))
                    {
                        using (OleDbCommand cmd = new OleDbCommand())
                        {

                            cmd.Connection = conn;
                            conn.Open();
                            cmd.CommandText = "select Loan_Status from Loan where Loan_ID=@name";
                            cmd.Parameters.AddWithValue("@name", loanLB_admin.SelectedItem.ToString());
                            using (OleDbDataReader reader = cmd.ExecuteReader())
                            {
                                reader.Read();
                                check_status = reader["Loan_Status"].ToString();
                            }
                        }
                    }
                    if (check_status.Equals("False"))
                    {
                        string Coll_ID;
                        using (OleDbConnection conn = new OleDbConnection(connstring))
                        {
                            using (OleDbCommand cmd = new OleDbCommand())
                            {
                                cmd.Connection = conn;
                                conn.Open();
                                cmd.CommandText = "select Coll_ID from Loan where ([Loan_ID]=@target)";
                                cmd.Parameters.AddWithValue("@target", loanLB_admin.SelectedItem.ToString());
                                using (OleDbDataReader reader = cmd.ExecuteReader())
                                {
                                    reader.Read();
                                    Coll_ID = reader["Coll_ID"].ToString();
                                }
                            }
                        }
                        using (OleDbConnection conn = new OleDbConnection(connstring))
                        {
                            using (OleDbCommand cmd = new OleDbCommand())
                            {
                                cmd.Connection = conn;
                                conn.Open();
                                cmd.CommandText = "update Collection set Coll_Status=@status where Coll_ID=@id";
                                bool value = false;
                                cmd.Parameters.AddWithValue("@status", value);
                                cmd.Parameters.AddWithValue("@id", Coll_ID);
                                cmd.ExecuteNonQuery();
                            }
                        }
                        using (OleDbConnection conn = new OleDbConnection(connstring))
                        {
                            using (OleDbCommand cmd = new OleDbCommand())
                            {

                                cmd.Connection = conn;
                                conn.Open();
                                cmd.CommandText = "update Loan set Loan_Status=@status,Admin_ID=@id where Loan_ID=@name";
                                bool value = true;
                                cmd.Parameters.AddWithValue("@status", value);
                                cmd.Parameters.AddWithValue("@id", Admin_ID);
                                cmd.Parameters.AddWithValue("@name", loanLB_admin.SelectedItem.ToString());
                                cmd.ExecuteNonQuery();
                            }
                        }
                        using (OleDbConnection conn = new OleDbConnection(connstring))
                        {
                            using (OleDbCommand finance = new OleDbCommand())
                            {

                                finance.Connection = conn;
                                conn.Open();
                                finance.CommandText = "INSERT INTO Finance (Finance_Type, Finance_Date, Loan_ID,Admin_ID) VALUES (@type, @date, @id,@admin_id);";
                                finance.Parameters.AddWithValue("@type", "Loan");
                                finance.Parameters.AddWithValue("@date", DateTime.Today);
                                finance.Parameters.AddWithValue("@id", loanLB_admin.SelectedItem.ToString());
                                finance.Parameters.AddWithValue("@admin_id", Admin_ID);
                                finance.ExecuteNonQuery();
                            }
                        }

                        int index = loanLB_admin.FindString(loanLB_admin.SelectedItem.ToString());
                        loanLB_admin.Items[index] = loanLB_admin.SelectedItem.ToString();
                        loanLB_admin.Update();
                        revenuegrid.Rows.Clear();
                        spentgrid.Rows.Clear();
                        SetGridView();
                        revenuegrid.Update();
                        spentgrid.Update();
                    }
                    else
                    {
                        MessageBox.Show("The loan approved");
                    }//end approve for loan
                }
            }
        }
        private bool null_check_emp()
        {
            bool null_check = false;
            switch (employeetabcontrol.SelectedIndex)
            {
                case 0:
                    if (employeeLB_admin.SelectedItem == null)
                        null_check = true;
                    break;
                case 1:
                    if (checkinLB_admin.SelectedItem == null)
                        null_check = true;
                    break;
            }
            if (null_check)
                MessageBox.Show("Please select an item in " + employeetabcontrol.SelectedTab.Text + " tab");
            return null_check;
        }

        //view detail button in employee
        private void viewdetailsbtn_employee_Click(object sender, EventArgs e)
        {
            viewEmpDetail();
            
        }//end view detail

        private void viewEmpDetail()
        {
            bool error = null_check_emp();
            if (!error)
            {
                Employee frm = new Employee("view", employeeLB_admin.SelectedItem.ToString(), ref employeeLB_admin, Admin_ID, ref checkinLB_admin);
                frm.Show();
            }
        }

        //insert button in employee
        private void insertbtn_employee_Click(object sender, EventArgs e)
        {
            insertEmp();
        }//end insert button

        private void insertEmp()
        {
            Employee frm = new Employee("insert", "", ref employeeLB_admin, Admin_ID, ref checkinLB_admin);
            frm.Show();
        }

        //delete button in employee
        private void deletebtn_employee_Click(object sender, EventArgs e)
        {
            
        }//end delete button

        private void deleteEmp()
        {
            bool error = null_check_emp();
            if (!error)
            {
                string path = Directory.GetCurrentDirectory();
                string connstring = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + path + @"\GameMuseumManagementSystem.accdb";
                using (OleDbConnection conn = new OleDbConnection(connstring))
                {
                    using (OleDbCommand cmd = new OleDbCommand())
                    {
                        cmd.Connection = conn;
                        conn.Open();
                        string table_name = "Employee";
                        cmd.CommandText = "delete * from " + table_name + " where ([Emp_Name])=@name";
                        cmd.Parameters.AddWithValue("@name", employeeLB_admin.SelectedItem.ToString());
                        cmd.ExecuteNonQuery();
                        checkinLB_admin.Items.Remove(employeeLB_admin.SelectedItem.ToString());
                        checkinLB_admin.Update();
                        employeeLB_admin.Items.Remove(employeeLB_admin.SelectedItem.ToString());
                        employeeLB_admin.Update();

                    }
                }
            }
        }

        //edit button in employee
        private void editbtn_employee_Click(object sender, EventArgs e)
        {
            editEmp();
        }//end edit button

        private void editEmp()
        {
            bool error = null_check_emp();
            if (!error)
            {
                Employee frm = new Employee("edit", employeeLB_admin.SelectedItem.ToString(), ref employeeLB_admin, Admin_ID, ref checkinLB_admin);
                frm.Show();
            }
        }

        private void checkoutbtn_Click(object sender, EventArgs e)
        {
            checkoutEmp();
        }

        private void checkoutEmp()
        {
            bool error = null_check_emp();
            if (!error)
            {
                string path = Directory.GetCurrentDirectory();
                string connstring = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + path + @"\GameMuseumManagementSystem.accdb";
                string check;
                DateTime checkin;
                using (OleDbConnection conn = new OleDbConnection(connstring))
                {
                    using (OleDbCommand cmd = new OleDbCommand())
                    {
                        cmd.Connection = conn;
                        conn.Open();
                        cmd.CommandText = "select * from Employee where Emp_Name=@name";
                        cmd.Parameters.AddWithValue("@name", checkinLB_admin.SelectedItem.ToString());
                        using (OleDbDataReader reader = cmd.ExecuteReader())
                        {
                            reader.Read();
                            check = reader["Last_CheckOut"].ToString();
                            checkin = DateTime.Parse(reader["Last_CheckIn"].ToString());
                        }
                    }
                }
                if (check.Equals(""))
                {
                    using (OleDbConnection conn = new OleDbConnection(connstring))
                    {
                        using (OleDbCommand cmd = new OleDbCommand())
                        {
                            TimeSpan tspan = DateTime.Now.Subtract(checkin);
                            int differenceInhours = tspan.Hours;
                            cmd.Connection = conn;
                            conn.Open();
                            cmd.CommandText = "update Employee set Emp_WorkingHrs=Emp_WorkingHrs+@wrk,Last_CheckIn=@checkin,Last_CheckOut=@checkout where Emp_Name=@default";
                            cmd.Parameters.AddWithValue("@wrk", differenceInhours);
                            cmd.Parameters.AddWithValue("@checkin", DBNull.Value);
                            cmd.Parameters.AddWithValue("@checkout", DateTime.Today);
                            cmd.Parameters.AddWithValue("@default", checkinLB_admin.SelectedItem.ToString());
                            cmd.ExecuteNonQuery();
                        }
                    }
                    int index = checkinLB_admin.FindString(checkinLB_admin.SelectedItem.ToString());
                    checkinLB_admin.Items[index] = checkinLB_admin.SelectedItem.ToString();
                    checkinLB_admin.Update();
                }
                else
                {
                    MessageBox.Show("This employee already check out");
                }

            }
        }

        private void checkinbtn_Click(object sender, EventArgs e)
        {
            checkinEmp();
        }

        private void checkinEmp()
        {
            bool error = null_check_emp();
            if (!error)
            {
                string path = Directory.GetCurrentDirectory();
                string connstring = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + path + @"\GameMuseumManagementSystem.accdb";
                string check;
                string emp_Name;
                using (OleDbConnection conn = new OleDbConnection(connstring))
                {
                    using (OleDbCommand cmd = new OleDbCommand())
                    {
                        cmd.Connection = conn;
                        conn.Open();
                        cmd.CommandText = "select * from Employee where Emp_Name=@name";
                        cmd.Parameters.AddWithValue("@name", checkinLB_admin.SelectedItem.ToString());
                        using (OleDbDataReader reader = cmd.ExecuteReader())
                        {
                            reader.Read();
                            emp_Name = reader["Emp_Name"].ToString();
                            check = reader["Last_CheckIn"].ToString();
                        }
                    }
                }
                if (check.Equals(""))
                {
                    using (OleDbConnection conn = new OleDbConnection(connstring))
                    {
                        using (OleDbCommand cmd = new OleDbCommand())
                        {
                            cmd.Connection = conn;
                            conn.Open();
                            DateTime checkintime = DateTime.Today;
                            cmd.CommandText = "update Employee set Last_CheckIn=@checkin,Last_CheckOut=@checkout where Emp_Name=@default";
                            cmd.Parameters.AddWithValue("@checkin", checkintime);
                            cmd.Parameters.AddWithValue("@checkout", DBNull.Value);
                            cmd.Parameters.AddWithValue("@default", emp_Name);
                            cmd.ExecuteNonQuery();
                        }
                    }
                    int index = checkinLB_admin.FindString(checkinLB_admin.SelectedItem.ToString());
                    checkinLB_admin.Items[index] = checkinLB_admin.SelectedItem.ToString();
                    checkinLB_admin.Update();
                }
                else
                {
                    MessageBox.Show("This employee already check in");
                }
            }
        }

        //calculate profit button in finance
        private void calculateprofitbtn_Click(object sender, EventArgs e)
        {
            calcProfit();
        }
        //end profit button

        private void calcProfit()
        {
            int profit = 0;
            for (int i = 0; i < revenuegrid.Rows.Count - 1; i++)
                profit = profit + Convert.ToInt32(revenuegrid.Rows[i].Cells[3].Value);
            for (int i = 0; i < spentgrid.Rows.Count - 1; i++)
                profit = profit - Convert.ToInt32(spentgrid.Rows[i].Cells[3].Value);
            MessageBox.Show("The total profit is " + profit.ToString());
        }

        private void logoutbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void generatereportbtn_Click(object sender, EventArgs e)
        {
            generateReport();
        }

        private void generateReport()
        {
            Finance frm = new Finance(spentgrid, revenuegrid);
            frm.Show();
        }

        private void newbtn_feedback_Click(object sender, EventArgs e)
        {
            createFeedback();
        }

        private void createFeedback()
        {
            NewFeedback frm = new NewFeedback();
            frm.Show();
        }

        private void editbtn_feedback_Click(object sender, EventArgs e)
        {
            editFeedback();
        }

        private void editFeedback()
        {
            NewFeedback frm = new NewFeedback();
            frm.Show();
        }
    
    }
}
