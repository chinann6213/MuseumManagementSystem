namespace museumv4
{
    partial class Souvenir
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
            this.label1 = new System.Windows.Forms.Label();
            this.nametxt = new System.Windows.Forms.TextBox();
            this.picture = new System.Windows.Forms.PictureBox();
            this.detailtxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pricetxt = new System.Windows.Forms.TextBox();
            this.browsebtn = new System.Windows.Forms.Button();
            this.cancelbtn = new System.Windows.Forms.Button();
            this.confirmbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Souvenir Name : ";
            // 
            // nametxt
            // 
            this.nametxt.Location = new System.Drawing.Point(15, 25);
            this.nametxt.Name = "nametxt";
            this.nametxt.ReadOnly = true;
            this.nametxt.Size = new System.Drawing.Size(278, 20);
            this.nametxt.TabIndex = 1;
            // 
            // picture
            // 
            this.picture.BackColor = System.Drawing.SystemColors.ControlLight;
            this.picture.Location = new System.Drawing.Point(299, 25);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(148, 106);
            this.picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture.TabIndex = 2;
            this.picture.TabStop = false;
            // 
            // detailtxt
            // 
            this.detailtxt.Location = new System.Drawing.Point(15, 64);
            this.detailtxt.Multiline = true;
            this.detailtxt.Name = "detailtxt";
            this.detailtxt.ReadOnly = true;
            this.detailtxt.Size = new System.Drawing.Size(278, 60);
            this.detailtxt.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Souvenir Detail : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Souvenir Price : ";
            // 
            // pricetxt
            // 
            this.pricetxt.Location = new System.Drawing.Point(104, 137);
            this.pricetxt.Name = "pricetxt";
            this.pricetxt.ReadOnly = true;
            this.pricetxt.Size = new System.Drawing.Size(189, 20);
            this.pricetxt.TabIndex = 6;
            // 
            // browsebtn
            // 
            this.browsebtn.Location = new System.Drawing.Point(372, 137);
            this.browsebtn.Name = "browsebtn";
            this.browsebtn.Size = new System.Drawing.Size(75, 23);
            this.browsebtn.TabIndex = 7;
            this.browsebtn.Text = "Browse";
            this.browsebtn.UseVisualStyleBackColor = true;
            this.browsebtn.Visible = false;
            this.browsebtn.Click += new System.EventHandler(this.browsebtn_Click);
            // 
            // cancelbtn
            // 
            this.cancelbtn.Location = new System.Drawing.Point(372, 167);
            this.cancelbtn.Name = "cancelbtn";
            this.cancelbtn.Size = new System.Drawing.Size(75, 23);
            this.cancelbtn.TabIndex = 8;
            this.cancelbtn.Text = "Cancel";
            this.cancelbtn.UseVisualStyleBackColor = true;
            this.cancelbtn.Click += new System.EventHandler(this.cancelbtn_Click);
            // 
            // confirmbtn
            // 
            this.confirmbtn.Location = new System.Drawing.Point(291, 167);
            this.confirmbtn.Name = "confirmbtn";
            this.confirmbtn.Size = new System.Drawing.Size(75, 23);
            this.confirmbtn.TabIndex = 9;
            this.confirmbtn.Text = "Confirm";
            this.confirmbtn.UseVisualStyleBackColor = true;
            this.confirmbtn.Visible = false;
            this.confirmbtn.Click += new System.EventHandler(this.confirmbtn_Click);
            // 
            // souvenir_detail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 202);
            this.Controls.Add(this.confirmbtn);
            this.Controls.Add(this.cancelbtn);
            this.Controls.Add(this.browsebtn);
            this.Controls.Add(this.pricetxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.detailtxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.picture);
            this.Controls.Add(this.nametxt);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "souvenir_detail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Souvenir";
            this.Load += new System.EventHandler(this.souvenir_detail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nametxt;
        private System.Windows.Forms.PictureBox picture;
        private System.Windows.Forms.TextBox detailtxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox pricetxt;
        private System.Windows.Forms.Button browsebtn;
        private System.Windows.Forms.Button cancelbtn;
        private System.Windows.Forms.Button confirmbtn;
    }
}