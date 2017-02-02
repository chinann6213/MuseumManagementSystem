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
    public partial class Collection : Form
    {
        string function = "view"; //indicate which function view , insert or edit
        string name = "";//collection name
        ListBox listbox;//pass in listbox to force update 
        string image_path = "";
        string Admin_ID;

        //default constructor
        public Collection(string function,string name,string admin_id,ref ListBox listbox)
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
            cmd.CommandText = "select " + column_name + " from Collection where ([Coll_Name]=@name)";
            cmd.Parameters.AddWithValue("@name", name);
            using (OleDbDataReader reader = cmd.ExecuteReader())
            {
                reader.Read();
                return reader[column_name].ToString();
            }
        }
        //end GetValue()

        //when the class load
        private void collection_detail_Load(object sender, EventArgs e)
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
                            nametxt.Text = name;//set name
                            detailtxt.Text = GetValue(cmd, "Coll_Detail");//set detail
                            date.Text = GetValue(cmd, "Coll_Date");//set date
                            if (GetValue(cmd, "Coll_Status").Equals("True"))//set available
                            {
                                availabecheck.Checked = true;
                            }
                            else
                            {
                                loanedcheck.Checked = true;
                            }
                            chargetxt.Text = GetValue(cmd, "Loan_Charge");//set charge
                            string image_path = GetValue(cmd, "Image_Path");//image
                            if(!image_path.Equals(""))//if no image for this collection
                            {
                                Image img = Image.FromFile(image_path);
                                // Resize if image is too big
                                if (img.Width > picture.Width && img.Height > picture.Height)
                                {
                                    Bitmap bitmap = new Bitmap(img, new Size(picture.Width, picture.Height));
                                    picture.Image = bitmap;
                                }
                                else picture.Image = img;
                            }
                            break;
                        case "insert":
                            this.Text = "Insert Collection";
                            nametxt.ReadOnly = false;
                            detailtxt.ReadOnly = false;
                            date.Enabled = true;
                            availabecheck.Enabled = true;
                            loanedcheck.Enabled = true;
                            chargetxt.ReadOnly = false;
                            confirmbtn.Visible = true;
                            browsebtn.Visible = true;
                            break;
                        case "edit":
                            this.Text = "Edit Collection";
                            nametxt.ReadOnly = false;
                            detailtxt.ReadOnly = false;
                            date.Enabled = true;
                            availabecheck.Enabled = true;
                            loanedcheck.Enabled = true;
                            chargetxt.ReadOnly = false;
                            confirmbtn.Visible = true;
                            browsebtn.Visible = true;
                            break;
                    }
                }
            }
        }
        //end load()

        //confirm button clicked
        private void confirmbtn_Click(object sender, EventArgs e)
        {
            confirmEditInsert();
            
        }//end confirm button click

        private void confirmEditInsert()
        {
            bool error = false;
            string path = Directory.GetCurrentDirectory();
            string connstring = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + path + @"\GameMuseumManagementSystem.accdb";
            //check textbox to prevent null value
            if (date.Value > DateTime.Today)
                error = true;
            if (nametxt.Text.Equals(""))
                error = true;
            if (detailtxt.Text.Equals(""))
                error = true;
            if (nametxt.Text.Equals(""))
                error = true;
            if (chargetxt.Text.Equals(""))
                error = true;
            int n;
            //check the input is integer or not
            bool isNumeric = int.TryParse(chargetxt.Text, out n);
            if (!isNumeric)
                error = true;
            //if no error
            if (!error)
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
                        //insert function
                        if (function.Equals("insert"))
                        {
                            //new collection not exist in database
                            if (check == 0)
                            {
                                if (!image_path.Equals(""))
                                {
                                    string destination = Path.Combine(Directory.GetCurrentDirectory() + @"\images", nametxt.Text + ".png");
                                    System.IO.File.Copy(image_path, destination);
                                    image_path = "images/" + nametxt.Text + ".png";
                                }
                                cmd.CommandText = "insert into Collection ([Coll_Name],[Coll_Detail],[Coll_Date],[Coll_Status],[Loan_Charge],[Image_Path],[Admin_ID]) values (?,?,?,?,?,?,?)";
                                cmd.Parameters.AddWithValue("@name", nametxt.Text);
                                cmd.Parameters.AddWithValue("@detail", detailtxt.Text);
                                cmd.Parameters.AddWithValue("@value", date.Value.Date.ToString());
                                if (availabecheck.Checked == true)
                                {
                                    bool value = true;
                                    cmd.Parameters.AddWithValue("@value", value);
                                }
                                else
                                {
                                    bool value = false;
                                    cmd.Parameters.AddWithValue("@value", value);
                                }
                                cmd.Parameters.AddWithValue("@value", chargetxt.Text);
                                cmd.Parameters.AddWithValue("@value", image_path);
                                cmd.Parameters.AddWithValue("@value", Admin_ID);
                                cmd.ExecuteNonQuery();
                                listbox.Items.Add(nametxt.Text);
                                listbox.Update();
                                this.Close();
                                this.Dispose();
                            }
                            else
                            {
                                MessageBox.Show("This collection existed");
                            }
                        }
                        //edit function
                        else
                        {
                            cmd.CommandText = "update Collection set Coll_Name=@name,Coll_detail=@detail,Coll_Date=@date" +
                                              ",Coll_Status=@status,Loan_Charge=@charge,Admin_ID=@id where Coll_Name=@default";
                            cmd.Parameters.AddWithValue("@name", nametxt.Text);
                            cmd.Parameters.AddWithValue("@detail", detailtxt.Text);
                            cmd.Parameters.AddWithValue("@date", date.Value.Date.ToString());
                            if (availabecheck.Checked == true)
                            {
                                bool value = true;
                                cmd.Parameters.AddWithValue("@status", value);
                            }
                            else
                            {
                                bool value = false;
                                cmd.Parameters.AddWithValue("@status", value);
                            }
                            cmd.Parameters.AddWithValue("@charge", chargetxt.Text);
                            cmd.Parameters.AddWithValue("@id", Admin_ID);
                            cmd.Parameters.AddWithValue("@default", name);
                            cmd.ExecuteNonQuery();
                            int index = listbox.FindString(name);
                            listbox.Items[index] = nametxt.Text;
                            listbox.Update();
                            this.Close();
                            this.Dispose();
                        }
                    }
                }
            }
            else
            {
                //if input is not a integer
                if (!isNumeric)
                    MessageBox.Show("Please fill a integer in charge");
                if (date.Value > DateTime.Today)
                    MessageBox.Show("The date must be smaller than today");
                //if some information not fill up
                else
                    MessageBox.Show("Please fill up all information");
            }
        }

        //browse button clicked
        private void browsebtn_Click(object sender, EventArgs e)
        {
            browseImage();
        }//end browse button

        private void browseImage()
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.jpeg; *.png)|*.jpg; *.jpeg; *.png";
            if (open.ShowDialog() == DialogResult.OK)
            {
                Bitmap objBitmap = new Bitmap(open.FileName);
                objBitmap.SetResolution(165, 139);
                picture.Image = objBitmap;
            }
            image_path = open.FileName;
        }

        //cancel button clicked
        private void cancelbtn_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }//end cancel button

        //method to prevent two check box checked at the same time
        private void availabecheck_CheckedChanged(object sender, EventArgs e)
        {
            if (availabecheck.Checked == true)
                loanedcheck.Enabled = false;
            else
                loanedcheck.Enabled = true;
        }
        private void loanedcheck_CheckedChanged(object sender, EventArgs e)
        {
            if (loanedcheck.Checked == true)
                availabecheck.Enabled = false;
            else
                availabecheck.Enabled = true;
        }

        private void date_ValueChanged(object sender, EventArgs e)
        {
            
        }
        //end check method
    }
}
