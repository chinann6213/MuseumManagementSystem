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
    public partial class Souvenir : Form
    {
        string function = "view"; //indicate which function view , insert or edit
        string name = "";//collection name
        ListBox listbox;//pass in listbox to force update 
        string image_path = "";
        string Admin_ID;

        //default constructor
        public Souvenir(string function, string name,ref ListBox listbox,string admin_id)
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
            cmd.CommandText = "select " + column_name + " from Souvenir where ([Souv_Name]=@name)";
            cmd.Parameters.AddWithValue("@name", name);
            using (OleDbDataReader reader = cmd.ExecuteReader())
            {
                reader.Read();
                return reader[column_name].ToString();
            }
        }
        //end GetValue()

        //when the class load
        private void souvenir_detail_Load(object sender, EventArgs e)
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
                            detailtxt.Text = GetValue(cmd, "Souv_Detail");
                            pricetxt.Text = GetValue(cmd, "Souv_Price");
                            string image_path = GetValue(cmd, "Image_Path");
                            if (!image_path.Equals(""))
                            {
                                Image img = Image.FromFile(GetValue(cmd, "Image_Path"));
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
                            this.Text = "Insert Souvenir";
                            nametxt.ReadOnly = false;
                            detailtxt.ReadOnly = false;
                            pricetxt.ReadOnly = false;
                            confirmbtn.Visible = true;
                            browsebtn.Visible = true;
                            break;
                        case "edit":
                            this.Text = "Edit Souvenir";
                            nametxt.ReadOnly = false;
                            detailtxt.ReadOnly = false;
                            pricetxt.ReadOnly = false;
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
            confirmEditInsertSouv();
            
        }//end confirm button click

        private void confirmEditInsertSouv()
        {
            bool error = false;
            string path = Directory.GetCurrentDirectory();
            string connstring = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + path + @"\GameMuseumManagementSystem.accdb";
            if (nametxt.Text.Equals(""))
                error = true;
            if (detailtxt.Text.Equals(""))
                error = true;
            if (pricetxt.Text.Equals(""))
                error = true;
            int n;
            bool isNumeric = int.TryParse(pricetxt.Text, out n);
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
                        cmd.CommandText = "select count(*) from Souvenir where Souv_Name=@name";
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
                                if (!image_path.Equals(""))
                                {
                                    string destination = Path.Combine(Directory.GetCurrentDirectory() + @"\images", nametxt.Text + ".png");
                                    System.IO.File.Copy(image_path, destination);
                                    image_path = "images/" + nametxt.Text + ".png";
                                }
                                cmd.CommandText = "insert into Souvenir ([Souv_Name],[Souv_Detail],[Souv_Price],[Image_Path],[Admin_ID]) values (?,?,?,?,?)";
                                cmd.Parameters.AddWithValue("@name", nametxt.Text);
                                cmd.Parameters.AddWithValue("@detail", detailtxt.Text);
                                cmd.Parameters.AddWithValue("@price", pricetxt.Text);
                                cmd.Parameters.AddWithValue("@value", image_path);
                                cmd.Parameters.AddWithValue("@id", Admin_ID);
                                cmd.ExecuteNonQuery();
                                listbox.Items.Add(nametxt.Text);
                                listbox.Update();
                                this.Close();
                                this.Dispose();
                            }
                            else
                            {
                                MessageBox.Show("This souvenir existed");
                            }

                        }
                        else
                        {
                            cmd.CommandText = "update Souvenir set Souv_Name=@name,Souv_Detail=@detail,Souv_Price=@price,Admin_ID=@id" +
                                              " where Souv_Name=@default";
                            cmd.Parameters.AddWithValue("@name", nametxt.Text);
                            cmd.Parameters.AddWithValue("@detail", detailtxt.Text);
                            cmd.Parameters.AddWithValue("@price", pricetxt.Text);
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
                if (!isNumeric)
                    MessageBox.Show("Please fill a integer in price");
                else
                    MessageBox.Show("Please fill up all information");
            }
        }

        //browse button clicked
        private void browsebtn_Click(object sender, EventArgs e)
        {
            browseSouvImage();
        }//end browse button

        private void browseSouvImage()
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
    }
}
