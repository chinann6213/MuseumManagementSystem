namespace museumv4
{
    partial class Collection
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.nametxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.detailtxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.availabecheck = new System.Windows.Forms.CheckBox();
            this.loanedcheck = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.chargetxt = new System.Windows.Forms.TextBox();
            this.cancelbtn = new System.Windows.Forms.Button();
            this.picture = new System.Windows.Forms.PictureBox();
            this.browsebtn = new System.Windows.Forms.Button();
            this.confirmbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            this.SuspendLayout();
            // 
            // nametxt
            // 
            this.nametxt.Location = new System.Drawing.Point(15, 25);
            this.nametxt.Name = "nametxt";
            this.nametxt.ReadOnly = true;
            this.nametxt.Size = new System.Drawing.Size(288, 20);
            this.nametxt.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Collection Name : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Collection Detail : ";
            // 
            // detailtxt
            // 
            this.detailtxt.Location = new System.Drawing.Point(15, 64);
            this.detailtxt.Multiline = true;
            this.detailtxt.Name = "detailtxt";
            this.detailtxt.ReadOnly = true;
            this.detailtxt.Size = new System.Drawing.Size(288, 60);
            this.detailtxt.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Collection Date : ";
            // 
            // date
            // 
            this.date.Enabled = false;
            this.date.Location = new System.Drawing.Point(15, 143);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(288, 20);
            this.date.TabIndex = 5;
            this.date.ValueChanged += new System.EventHandler(this.date_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Loan Status : ";
            // 
            // availabecheck
            // 
            this.availabecheck.AutoSize = true;
            this.availabecheck.Enabled = false;
            this.availabecheck.Location = new System.Drawing.Point(92, 171);
            this.availabecheck.Name = "availabecheck";
            this.availabecheck.Size = new System.Drawing.Size(69, 17);
            this.availabecheck.TabIndex = 7;
            this.availabecheck.Text = "Available";
            this.availabecheck.UseVisualStyleBackColor = true;
            this.availabecheck.CheckedChanged += new System.EventHandler(this.availabecheck_CheckedChanged);
            // 
            // loanedcheck
            // 
            this.loanedcheck.AutoSize = true;
            this.loanedcheck.Enabled = false;
            this.loanedcheck.Location = new System.Drawing.Point(167, 171);
            this.loanedcheck.Name = "loanedcheck";
            this.loanedcheck.Size = new System.Drawing.Size(62, 17);
            this.loanedcheck.TabIndex = 8;
            this.loanedcheck.Text = "Loaned";
            this.loanedcheck.UseVisualStyleBackColor = true;
            this.loanedcheck.CheckedChanged += new System.EventHandler(this.loanedcheck_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Loan Charge : ";
            // 
            // chargetxt
            // 
            this.chargetxt.Location = new System.Drawing.Point(92, 198);
            this.chargetxt.Name = "chargetxt";
            this.chargetxt.ReadOnly = true;
            this.chargetxt.Size = new System.Drawing.Size(211, 20);
            this.chargetxt.TabIndex = 10;
            // 
            // cancelbtn
            // 
            this.cancelbtn.Location = new System.Drawing.Point(397, 240);
            this.cancelbtn.Name = "cancelbtn";
            this.cancelbtn.Size = new System.Drawing.Size(75, 23);
            this.cancelbtn.TabIndex = 11;
            this.cancelbtn.Text = "Cancel";
            this.cancelbtn.UseVisualStyleBackColor = true;
            this.cancelbtn.Click += new System.EventHandler(this.cancelbtn_Click);
            // 
            // picture
            // 
            this.picture.BackColor = System.Drawing.Color.White;
            this.picture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picture.InitialImage = null;
            this.picture.Location = new System.Drawing.Point(316, 25);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(156, 138);
            this.picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture.TabIndex = 13;
            this.picture.TabStop = false;
            // 
            // browsebtn
            // 
            this.browsebtn.Location = new System.Drawing.Point(360, 172);
            this.browsebtn.Name = "browsebtn";
            this.browsebtn.Size = new System.Drawing.Size(75, 23);
            this.browsebtn.TabIndex = 14;
            this.browsebtn.Text = "Browse";
            this.browsebtn.UseVisualStyleBackColor = true;
            this.browsebtn.Visible = false;
            this.browsebtn.Click += new System.EventHandler(this.browsebtn_Click);
            // 
            // confirmbtn
            // 
            this.confirmbtn.Location = new System.Drawing.Point(316, 240);
            this.confirmbtn.Name = "confirmbtn";
            this.confirmbtn.Size = new System.Drawing.Size(75, 23);
            this.confirmbtn.TabIndex = 12;
            this.confirmbtn.Text = "Confirm";
            this.confirmbtn.UseVisualStyleBackColor = true;
            this.confirmbtn.Visible = false;
            this.confirmbtn.Click += new System.EventHandler(this.confirmbtn_Click);
            // 
            // collection_detail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 279);
            this.Controls.Add(this.browsebtn);
            this.Controls.Add(this.picture);
            this.Controls.Add(this.confirmbtn);
            this.Controls.Add(this.cancelbtn);
            this.Controls.Add(this.chargetxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.loanedcheck);
            this.Controls.Add(this.availabecheck);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.date);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.detailtxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nametxt);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "collection_detail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Collection";
            this.Load += new System.EventHandler(this.collection_detail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nametxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox detailtxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox availabecheck;
        private System.Windows.Forms.CheckBox loanedcheck;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox chargetxt;
        private System.Windows.Forms.Button cancelbtn;
        private System.Windows.Forms.PictureBox picture;
        private System.Windows.Forms.Button browsebtn;
        private System.Windows.Forms.Button confirmbtn;
    }
}