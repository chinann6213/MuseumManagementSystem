namespace museumv4
{
    partial class ItemDonation
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
            this.detailtxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.discardbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Item Name : ";
            // 
            // nametxt
            // 
            this.nametxt.Location = new System.Drawing.Point(12, 25);
            this.nametxt.Name = "nametxt";
            this.nametxt.ReadOnly = true;
            this.nametxt.Size = new System.Drawing.Size(260, 20);
            this.nametxt.TabIndex = 1;
            // 
            // detailtxt
            // 
            this.detailtxt.Location = new System.Drawing.Point(12, 64);
            this.detailtxt.Multiline = true;
            this.detailtxt.Name = "detailtxt";
            this.detailtxt.ReadOnly = true;
            this.detailtxt.Size = new System.Drawing.Size(260, 60);
            this.detailtxt.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Item Detail : ";
            // 
            // discardbtn
            // 
            this.discardbtn.Location = new System.Drawing.Point(197, 139);
            this.discardbtn.Name = "discardbtn";
            this.discardbtn.Size = new System.Drawing.Size(75, 23);
            this.discardbtn.TabIndex = 4;
            this.discardbtn.Text = "Discard";
            this.discardbtn.UseVisualStyleBackColor = true;
            this.discardbtn.Click += new System.EventHandler(this.discardbtn_Click);
            // 
            // Item_Donation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 174);
            this.Controls.Add(this.discardbtn);
            this.Controls.Add(this.detailtxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nametxt);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Item_Donation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Donation";
            this.Load += new System.EventHandler(this.Item_Donation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nametxt;
        private System.Windows.Forms.TextBox detailtxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button discardbtn;
    }
}