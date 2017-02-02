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
    public partial class Member : Form
    {
        string image_path="";
        static string path = Directory.GetCurrentDirectory();
        static string connstring = @"Provider = Microsoft.ACE.OLEDB.12.0;Data Source=" + path + @"\GameMuseumManagementSystem.accdb";

        //default construtor
        public Member()
        {
            InitializeComponent();
        }
        //end default constructor

        private string Member_ID;

        public Member(string member_id)
        {
            InitializeComponent();
            Member_ID = member_id;
        }
        
        private void Member_Load(object sender, EventArgs e)
        {
            quantitytxt_ticket.ReadOnly = true;
            totalpricetxt_ticket.ReadOnly = true;
            datepicker_tic.Value = DateTime.Today.AddDays(1);
            startdatepicker.Value = DateTime.Today.AddDays(1);
            enddatepicker.Value = DateTime.Today.AddDays(1);
            using (OleDbConnection conn = new OleDbConnection(connstring))
            {
                using (OleDbCommand cmd = new OleDbCommand())
                {
                    cmd.Connection = conn;
                    conn.Open();
                    cmd.CommandText = "select Member_Name from Member where Member_ID=@id";
                    cmd.Parameters.AddWithValue("@id", Member_ID);
                    using (OleDbDataReader reader = cmd.ExecuteReader())
                    {
                        reader.Read();
                        label1.Text = "Welcome, " + reader["Member_Name"].ToString();
                    }
                }
            }
            
        }

        private void viewshoppingbtn_souvenir_Click(object sender, EventArgs e)
        {
            viewShoppingCart();
        }

        private void viewShoppingCart()
        {
            ShoppingCart frm = new ShoppingCart(Member_ID);
            frm.Show();
        }

        private void proceedbtn_ticket_Click(object sender, EventArgs e)
        {
            if(numadulttxt_ticket.Text.Equals("")||numchildrentxt_ticket.Equals(""))
            {
                MessageBox.Show("Please enter number of ticket for adult and children correctly", "Error");
                return;
            }
            else
            {
                Payment frm = new Payment(Member_ID, datepicker_tic.Value, int.Parse(numadulttxt_ticket.Text), int.Parse(numchildrentxt_ticket.Text));
                frm.Show();
            }
        }

        private void browsebtn_donate_Click(object sender, EventArgs e)
        {
            browseDonatePic();
        }

        private void browseDonatePic()
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.jpeg; *.png)|*.jpg; *.jpeg; *.png";
            if (open.ShowDialog() == DialogResult.OK)
            {
                Bitmap objBitmap = new Bitmap(open.FileName);
                objBitmap.SetResolution(165, 139);
                donate_pic.Image = objBitmap;
            }
            image_path = open.FileName;
        }

        private void discardbtn_Click(object sender, EventArgs e)
        {
            nametxt_donate.Clear();
            detailtxt_donate.Clear();
            pricetxt_donate.Clear();
            donate_pic.Image = null;
        }

        private void submitbtn_Click(object sender, EventArgs e)//complete
        {
            submitItemDonation();
        }

        private void submitItemDonation()
        {
            bool isIncomplete = false;
            foreach (Control control in donatetab.Controls)
            {
                if (control is TextBox)
                {
                    TextBox tb = control as TextBox;
                    if (tb.Text == string.Empty)
                    {
                        isIncomplete = true;
                        break;
                    }
                }
            }
            if (!isIncomplete)
            {
                //check new collection exist in database or not
                int check = 0;
                using (OleDbConnection conn = new OleDbConnection(connstring))
                {
                    using (OleDbCommand cmd = new OleDbCommand())
                    {
                        cmd.Connection = conn;
                        conn.Open();
                        cmd.CommandText = "select count(*) from Collection where Coll_Name=@name";
                        cmd.Parameters.AddWithValue("@name", nametxt_donate.Text);
                        check = (int)cmd.ExecuteScalar();
                    }
                }
                if (!image_path.Equals(""))
                {
                    string destination = Path.Combine(Directory.GetCurrentDirectory() + @"\images", nametxt_donate.Text + ".png");
                    System.IO.File.Copy(image_path, destination);
                    image_path = "images/" + nametxt_donate.Text + ".png";
                }
                if (check == 0)
                {
                    DialogResult dialogResult = MessageBox.Show("Confirm submit?", "Confirm submit", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        using (OleDbConnection conn = new OleDbConnection(connstring)) //Create connection
                        {
                            conn.Open();
                            using (OleDbCommand cmd = new OleDbCommand()) //Create command
                            {
                                cmd.Connection = conn; //command connect to database

                                cmd.CommandText = "INSERT INTO ItemDonation (Item_Name, Item_Detail, Selling_Price,Image_Path,Member_ID) VALUES (@name, @detail, @price,@image,@id);";

                                cmd.Parameters.AddWithValue("@name", nametxt_donate.Text);
                                cmd.Parameters.AddWithValue("@detail", detailtxt_donate.Text);
                                cmd.Parameters.AddWithValue("@price", pricetxt_donate.Text);
                                cmd.Parameters.AddWithValue("@image", image_path);
                                cmd.Parameters.AddWithValue("@id", Member_ID);
                                cmd.ExecuteNonQuery();
                            }
                        }

                    }
                }
                else
                {
                    MessageBox.Show("This collection name existed , please fill in another name");
                }
            }
            else
            {
                MessageBox.Show("Please fill in all the blank area! Price field can only be integer.", "Error", MessageBoxButtons.OK);
            }
        }

        private void log_out_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            selectLoanItem();
        }

        private void selectLoanItem()
        {
            if (coll_listbox.SelectedItem == null)
            {
                MessageBox.Show("Please select an item.", "Error");
                return;
            }

            using (OleDbConnection conn = new OleDbConnection(connstring)) //Create connection
            {
                conn.Open();

                string collection = coll_listbox.GetItemText(coll_listbox.SelectedItem);
                string coll_id;
                using (OleDbCommand target_id = new OleDbCommand("SELECT Coll_ID FROM Collection WHERE ([Coll_Name]=@collection)", conn))
                {
                    target_id.Parameters.AddWithValue("@collection", collection);
                    using (OleDbDataReader reader2 = target_id.ExecuteReader())
                    {
                        reader2.Read();
                        coll_id = reader2["Coll_ID"].ToString();
                    }
                }

                int count;
                using (OleDbCommand check = new OleDbCommand("SELECT count(*) FROM Loan WHERE ([Coll_ID]=@id)", conn))
                {
                    check.Parameters.AddWithValue("@id", coll_id);
                    count = (int)check.ExecuteScalar();
                }
                if (count > 0)
                {
                    MessageBox.Show("This collection loan by another , please try later");
                }
                else
                {
                    collname_txt.Text = collection;

                    using (OleDbCommand cmd = new OleDbCommand("SELECT Loan_Charge FROM Collection WHERE ([Coll_Name]=@collection)", conn))
                    {
                        cmd.Parameters.AddWithValue("@collection", collection);

                        using (OleDbDataReader reader = cmd.ExecuteReader())
                        {
                            reader.Read();
                            charge.Text = reader["Loan_Charge"].ToString();
                        }

                    }
                    browse_panel.Visible = false;
                    collname_txt.Visible = true;
                    charge.Visible = true;
                    submitbtn_loan.Visible = true;
                    discardbtn_loan.Visible = true;
                }
            }
        }

        private void view_collbtn_Click(object sender, EventArgs e)
        {
            viewCollDetail();
            
        }

        private void viewCollDetail()
        {
            if (coll_listbox.SelectedItem != null)
            {
                Collection frm = new Collection("view", coll_listbox.SelectedItem.ToString(), "", ref coll_listbox);
                frm.Show();
            }
            else
            {
                MessageBox.Show("Please select a collection");
            }
        }

        private void close_collbtn_Click(object sender, EventArgs e)
        {
            browse_panel.Visible = false;
            coll_listbox.Items.Clear();
            charge.Visible = true;
            submitbtn_loan.Visible = true;
            discardbtn_loan.Visible = true;
            collname_txt.Visible = true;
        }

        private void browsebtn_loan_Click(object sender, EventArgs e)
        {
            browseLoanItem();   
        }

        private void browseLoanItem()
        {
            charge.Visible = false;
            submitbtn_loan.Visible = false;
            discardbtn_loan.Visible = false;
            collname_txt.Visible = false;
            browse_panel.Visible = true;
            using (OleDbConnection conn = new OleDbConnection(connstring)) //Create connection
            {
                conn.Open();

                using (OleDbCommand cmd = new OleDbCommand("SELECT * FROM Collection where Coll_Status=True", conn)) //Create command
                {
                    using (OleDbDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            coll_listbox.Items.Add(reader["Coll_Name"]);
                        }
                    }
                }
            }
        }

        private void submitbtn_loan_Click(object sender, EventArgs e)//complete
        {
            submitLoan();
        }

        private void submitLoan()
        {
            if (purposetxt_loan.Text == string.Empty || collname_txt.Text == "Collection name")
            {
                MessageBox.Show("Please fill in the blank area!", "Error", MessageBoxButtons.OK);
                return;
            }
            if (enddatepicker.Value < startdatepicker.Value)
            {
                MessageBox.Show("Ending date must greater than starting date", "Error", MessageBoxButtons.OK);
                return;
            }

            DialogResult dialogResult = MessageBox.Show("Confirm submit?", "Confirm submit", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                using (OleDbConnection conn = new OleDbConnection(connstring)) //Create connection
                {
                    conn.Open();
                    int differenceInDays;
                    int coll_id;
                    using (OleDbCommand cmd = new OleDbCommand("SELECT Coll_ID FROM Collection WHERE ([Coll_Name]=@collection)", conn))
                    {
                        cmd.Parameters.AddWithValue("@collection", collname_txt.Text);
                        cmd.ExecuteNonQuery();
                        using (OleDbDataReader reader = cmd.ExecuteReader())
                        {
                            reader.Read();
                            coll_id = Int32.Parse(reader["Coll_ID"].ToString());
                            DateTime startDate = startdatepicker.Value;
                            DateTime endDate = enddatepicker.Value;
                            TimeSpan tspan = endDate - startDate;
                            differenceInDays = tspan.Days;
                        }
                    }

                    using (OleDbCommand loanPeriod = new OleDbCommand("INSERT INTO Loan(Loan_Period, Loan_Purpose, Coll_ID,Loan_Price,Member_ID) VALUES (@period, @purpose, @collID,@price,@id)", conn))
                    {
                        loanPeriod.Parameters.AddWithValue("@period", differenceInDays);
                        loanPeriod.Parameters.AddWithValue("@purpose", purposetxt_loan.Text);
                        loanPeriod.Parameters.AddWithValue("@collID", coll_id);
                        loanPeriod.Parameters.AddWithValue("@price", charge.Text);
                        loanPeriod.Parameters.AddWithValue("@id", Member_ID);
                        loanPeriod.ExecuteNonQuery();
                    }
                }
            }
        }

        private void quantitytxt_ticket_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void datepicker_ValueChanged(object sender, EventArgs e)
        {
            checkDateValidity(datepicker_tic);
        }

        private void numadulttxt_ticket_TextChanged(object sender, EventArgs e)
        {
            int parsedValue;
           
            if (!int.TryParse(numadulttxt_ticket.Text, out parsedValue) && numadulttxt_ticket.Text != string.Empty)
            {
                MessageBox.Show("Number of adult and children must be only integers!");
                numadulttxt_ticket.Text = 0.ToString();
                numadulttxt_ticket.SelectionLength = numadulttxt_ticket.Text.Length;
                return;
            }

            calculatePrice();
        }

        private void numchildrentxt_ticket_TextChanged(object sender, EventArgs e)
        {
            int parsedValue;
            if (!int.TryParse(numchildrentxt_ticket.Text, out parsedValue) && numchildrentxt_ticket.Text != string.Empty)
            {
                MessageBox.Show("Number of adult and children must be only integers!");
                numchildrentxt_ticket.Text = 0.ToString();
                numchildrentxt_ticket.SelectionLength = numchildrentxt_ticket.Text.Length;
                return;
            }
            calculatePrice();
        }

        private void calculatePrice()
        {
            using (OleDbConnection conn = new OleDbConnection(connstring)) //Create connection
            {
                conn.Open();

                using (OleDbCommand getAdultPrice = new OleDbCommand("SELECT Ticket_Price FROM Ticket WHERE ([Ticket_Type]=@adult)", conn))
                {
                    getAdultPrice.Parameters.AddWithValue("@adult", "adult");
                    using (OleDbCommand getChildPrice = new OleDbCommand("SELECT Ticket_Price FROM Ticket WHERE ([Ticket_Type]=@child)", conn))
                    {
                        getChildPrice.Parameters.AddWithValue("@child", "children");
                        using (OleDbDataReader readAdult = getAdultPrice.ExecuteReader())
                        {
                            readAdult.Read();
                            using (OleDbDataReader readChild = getChildPrice.ExecuteReader())
                            {
                                readChild.Read();

                                float AdultTic_price = int.Parse(readAdult["Ticket_Price"].ToString());
                                float ChildTic_price = int.Parse(readChild["Ticket_Price"].ToString());

                                if (string.IsNullOrWhiteSpace(numchildrentxt_ticket.Text))
                                {
                                    numchildrentxt_ticket.Text = 0.ToString();
                                }

                                if (string.IsNullOrWhiteSpace(numadulttxt_ticket.Text))
                                {
                                    numadulttxt_ticket.Text = 0.ToString();
                                }

                                quantitytxt_ticket.Text = (int.Parse(numadulttxt_ticket.Text) + int.Parse(numchildrentxt_ticket.Text)).ToString();

                                float total = AdultTic_price * int.Parse(numadulttxt_ticket.Text) + ChildTic_price * int.Parse(numchildrentxt_ticket.Text);
                                totalpricetxt_ticket.Text = total.ToString();
                            }
                        }  
                    }
                }
            }
                
        }

        private void pricetxt_donate_TextChanged(object sender, EventArgs e)
        {
            Double value;
            if (Double.TryParse(pricetxt_donate.Text, out value))
                pricetxt_donate.Text = String.Format(System.Globalization.CultureInfo.CurrentCulture, "{0:C2}", value);
            else
                pricetxt_donate.Text = String.Empty;
        }

        private void enddatepicker_ValueChanged(object sender, EventArgs e)
        {
            checkDateValidity(enddatepicker);
        }

        private void startdatepicker_ValueChanged(object sender, EventArgs e)
        {
            checkDateValidity(startdatepicker);
        }

        private void checkDateValidity(DateTimePicker timePicker)
        {
            bool checker = false;
            if (timePicker.Value < DateTime.Today.AddDays(1))
            { 
                checker = true;
            }

            if (checker == true)
            {
                timePicker.Value = DateTime.Today.AddDays(1);
                DialogResult dialogResult = MessageBox.Show("The date entered must greater than today!", "OK", MessageBoxButtons.OK);
            }
        }

        private void tickettab_Click(object sender, EventArgs e)
        {

        }

        private void discardbtn_ticket_Click(object sender, EventArgs e)
        {
            datepicker_tic.Value = DateTime.Today.AddDays(1);
            numadulttxt_ticket.Text = 0.ToString();
            numchildrentxt_ticket.Text = 0.ToString();
        }

        private void coll_listbox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void browsebtn_souvenir_Click(object sender, EventArgs e)
        {
            browseSouv();
        }

        private void browseSouv()
        {
            viewshoppingbtn_souvenir.Visible = false;
            addcartbtn_souvenir.Visible = false;
            browse_souv_panel.Visible = true;

            using (OleDbConnection conn = new OleDbConnection(connstring)) //Create connection
            {
                conn.Open();

                using (OleDbCommand cmd = new OleDbCommand("SELECT * FROM Souvenir", conn)) //Create command
                {
                    using (OleDbDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            souv_listbox.Items.Add(reader["Souv_Name"]);
                        }
                    }
                }
            }
        }

        private void selectsouv_btn_Click(object sender, EventArgs e)
        {
            selectSouv();
        }

        private void selectSouv()
        {
            if (souv_listbox.SelectedItem == null)
            {
                MessageBox.Show("Please select an item.", "Error");
                return;
            }

            using (OleDbConnection conn = new OleDbConnection(connstring)) //Create connection
            {
                conn.Open();

                string souvenir = souv_listbox.GetItemText(souv_listbox.SelectedItem);
                nametxt_souvenir.Text = souvenir;

                using (OleDbCommand cmd = new OleDbCommand("SELECT Souv_Price FROM Souvenir WHERE ([Souv_Name]=@souvenir)", conn))
                {
                    cmd.Parameters.AddWithValue("@souvenir", souvenir);

                    using (OleDbDataReader reader = cmd.ExecuteReader())
                    {
                        reader.Read();

                        totalpricetxt_souvenir.Text = reader["Souv_Price"].ToString();
                        quantitytxt_souvenir.Text = 1.ToString();
                    }
                }
                browse_souv_panel.Visible = false;
                viewshoppingbtn_souvenir.Visible = true;
                addcartbtn_souvenir.Visible = true;
            }
        }

        private void close_souv_btn_Click(object sender, EventArgs e)
        {
            browse_souv_panel.Visible = false;
            souv_listbox.Items.Clear();
            viewshoppingbtn_souvenir.Visible = true;
            addcartbtn_souvenir.Visible = true;
        }

        private void quantitytxt_souvenir_TextChanged(object sender, EventArgs e)
        {
            using (OleDbConnection conn = new OleDbConnection(connstring)) //Create connection
            {
                conn.Open();

                string souvenir = souv_listbox.GetItemText(souv_listbox.SelectedItem);
                nametxt_souvenir.Text = souvenir;

                using (OleDbCommand cmd = new OleDbCommand("SELECT Souv_Price FROM Souvenir WHERE ([Souv_Name]=@souvenir)", conn))
                {
                    cmd.Parameters.AddWithValue("@souvenir", souvenir);

                    using (OleDbDataReader reader = cmd.ExecuteReader())
                    {
                        reader.Read();

                        int souv_price = int.Parse(reader["Souv_Price"].ToString());

                        if (nametxt_souvenir.Text != string.Empty && quantitytxt_souvenir.Text != string.Empty)
                        {
                            float total_price = int.Parse(quantitytxt_souvenir.Text) * souv_price;
                            totalpricetxt_souvenir.Text = total_price.ToString();
                        }
                        else
                        {
                            totalpricetxt_souvenir.Text = 0.ToString();
                        }
                    } 
                }   
            }  
        }

        private void addcartbtn_souvenir_Click(object sender, EventArgs e)
        {
            addSouvToCart();
        }

        private void addSouvToCart()
        {
            if (nametxt_souvenir.Text == string.Empty || quantitytxt_souvenir.Text == string.Empty)
            {
                MessageBox.Show("Please fill in the blank area!", "Error");
                return;
            }

            DialogResult dialogResult = MessageBox.Show("Confirm submit?", "Confirm submit", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                using (OleDbConnection conn = new OleDbConnection(connstring)) //Create connection
                {
                    conn.Open();

                    int check_souv = 0;
                    using (OleDbCommand check = new OleDbCommand("select count(*) from ShoppingCart where Cart_Souv_Name=@name", conn))
                    {
                        check.Parameters.AddWithValue("@name", nametxt_souvenir.Text);
                        check_souv = (int)check.ExecuteScalar();

                        if (check_souv == 0)
                        {
                            using (OleDbCommand insertToCart = new OleDbCommand("INSERT INTO ShoppingCart(Cart_Souv_Name, Quantity, Cart_Souv_Price) VALUES (@name, @quantity, @totalPrice)", conn))
                            {
                                insertToCart.Parameters.AddWithValue("@name", nametxt_souvenir.Text);
                                insertToCart.Parameters.AddWithValue("@quantity", quantitytxt_souvenir.Text);
                                insertToCart.Parameters.AddWithValue("@total_Price", totalpricetxt_souvenir.Text);
                                insertToCart.ExecuteNonQuery();
                            }
                        }
                        else
                        {
                            using (OleDbCommand updatecart = new OleDbCommand("update ShoppingCart set Quantity=Quantity+" + quantitytxt_souvenir.Text + ",Cart_Souv_Price=Cart_Souv_Price+" + totalpricetxt_souvenir.Text + " where Cart_Souv_Name=@name", conn))
                            {
                                updatecart.Parameters.AddWithValue("@name", nametxt_souvenir.Text);
                                updatecart.ExecuteNonQuery();
                            }
                        }
                        MessageBox.Show("Added successfully.", "Message");
                    }
                }

            }
        }

        private void pricetxt_donate_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
 
        }
    }
}
