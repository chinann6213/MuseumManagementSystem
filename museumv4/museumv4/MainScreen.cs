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
    public partial class MainScreen : Form
    {
        public MainScreen()
        {
            InitializeComponent();
        }

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

        private void Main_Load(object sender, EventArgs e)
        {
            SetDisplayData(ref collectionlist, "Collection", "Coll_Name");
            SetDisplayData(ref eventlist, "Event", "Event_Title");
            SetDisplayData(ref souvenirlist, "Souvenir", "Souv_Name");
        }

        private void registerlink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Registration frm = new Registration();
            frm.Show();
        }

        private void feedbacklink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Feedback frm = new Feedback();
            frm.Show();
        }

        //method to check whether user select a item or not
        private bool null_check()
        {
            bool null_check = false;
            switch (viewtabcontrol.SelectedIndex)
            {
                case 0:
                    if (collectionlist.SelectedItem == null)
                        null_check = true;
                    break;
                case 1:
                    if (eventlist.SelectedItem == null)
                        null_check = true;
                    break;
                case 2:
                    if (souvenirlist.SelectedItem == null)
                        null_check = true;
                    break;
            }
            if (null_check)
                MessageBox.Show("Please select an item in " + viewtabcontrol.SelectedTab.Text + " tab");
            return null_check;
        }
        //end null_check()

        // @author Kia Kin > START
        private void detailsbtn_Click(object sender, EventArgs e)
        {
            viewInfoDetail();
        }
        // END <

        private void viewInfoDetail()
        {
            bool error = null_check();
            if (!error)
            {
                switch (viewtabcontrol.SelectedIndex)
                {
                    case 0:
                        Collection frm = new Collection("view", collectionlist.SelectedItem.ToString(), "", ref collectionlist);
                        frm.Show();
                        break;
                    case 1:
                        Event frm1 = new Event("view", eventlist.SelectedItem.ToString(), ref eventlist, "");
                        frm1.Show();
                        break;
                    case 2:
                        Souvenir frm2 = new Souvenir("view", souvenirlist.SelectedItem.ToString(), ref souvenirlist, "");
                        frm2.Show();
                        break;
                }
            }
        }
        private void loginbtn_Click(object sender, EventArgs e)
        {
            login();
        }

        private void login()
        {
            string path = Directory.GetCurrentDirectory();
            string connstring = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + path + @"\GameMuseumManagementSystem.accdb";
            OleDbConnection conn = new OleDbConnection(connstring); //Create connection
            conn.Open();

            OleDbCommand cmd = new OleDbCommand(); //Create command

            cmd.Connection = conn; //command connect to database
            cmd.CommandText = "select count(*) from Admin where ([Admin_Email]=@email)"; //check whether got the email registed in Admin
            cmd.Parameters.AddWithValue("@email", emailtxt.Text); //Assign the email value with the value of textbox using this to prevent injection    
            int check_exist_admin = (int)cmd.ExecuteScalar(); // if the email type correctly , it will > 0
            if (check_exist_admin > 0)
            {
                cmd.CommandText = "select * from Admin where ([Admin_Email]=@email)"; //select statement to get the password that match with Admin_email
                cmd.Parameters.AddWithValue("@email", emailtxt.Text);
                OleDbDataReader reader = cmd.ExecuteReader(); //get the value
                if (reader.Read()) //if a value read successful
                {
                    if (pwtxt.Text.Equals(reader["Admin_Password"].ToString())) //if the password is type correctly
                    {
                        Admin frm = new Admin(reader["Admin_ID"].ToString());
                        frm.Show();
                        emailtxt.Text = "";
                        pwtxt.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Wrong Password"); //wrong message pop out
                    }
                }
            }
            else //maybe the email is registed as member?
            {
                cmd.CommandText = "select count(*) from Member where ([Member_Email]=@email)"; //check whether got the email registed in member
                cmd.Parameters.AddWithValue("@email", emailtxt.Text);
                int check_exist_member = (int)cmd.ExecuteScalar();
                if (check_exist_member > 0)
                {
                    cmd.CommandText = "select * from Member where ([Member_Email]=@email)";
                    cmd.Parameters.AddWithValue("@email", emailtxt.Text);
                    OleDbDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        string member_id = reader["Member_ID"].ToString();
                        if (pwtxt.Text.Equals(reader["Member_Password"].ToString()))
                        {
                            Member frm = new Member(member_id);
                            frm.Show();
                            emailtxt.Text = "";
                            pwtxt.Text = "";
                        }
                        else
                        {
                            MessageBox.Show("Wrong Password");
                        }
                    }
                }
                else // this email is invalid
                {
                    MessageBox.Show("Invalid email");
                }
            }
        }

        // @author Kia Kin > START
        private void searchbtn_Click(object sender, EventArgs e)
        {
            searchInfo();

        }
        // END <

        private void searchInfo()
        {
            emptylbl.Text = "";
            if (String.IsNullOrWhiteSpace(searchtxt.Text))
            {
                emptylbl.Text = "You can't leave this empty.";
                emptylbl.Visible = true;
            }
            else
            {
                int index = -1;
                switch (viewtabcontrol.SelectedIndex)
                {
                    case 0:
                        index = collectionlist.FindString(searchtxt.Text, -1);
                        if (index != -1)
                            collectionlist.SetSelected(index, true);
                        break;
                    case 1:
                        index = eventlist.FindString(searchtxt.Text, -1);
                        if (index != -1)
                            eventlist.SetSelected(index, true);
                        break;
                    case 2:
                        index = souvenirlist.FindString(searchtxt.Text, -1);
                        if (index != -1)
                            souvenirlist.SetSelected(index, true);
                        break;
                }
                if (index == -1)
                {
                    MessageBox.Show("Item not found");
                }
            }
        }
    }
}
