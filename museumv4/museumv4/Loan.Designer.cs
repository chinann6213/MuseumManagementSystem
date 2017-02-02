namespace museumv4
{
    partial class Loan
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
            this.memberidtxt = new System.Windows.Forms.TextBox();
            this.collidtxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.periodtxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.purposetxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pricetxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cancelbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Member ID :";
            // 
            // memberidtxt
            // 
            this.memberidtxt.Location = new System.Drawing.Point(15, 25);
            this.memberidtxt.Name = "memberidtxt";
            this.memberidtxt.ReadOnly = true;
            this.memberidtxt.Size = new System.Drawing.Size(257, 20);
            this.memberidtxt.TabIndex = 1;
            // 
            // collidtxt
            // 
            this.collidtxt.Location = new System.Drawing.Point(15, 64);
            this.collidtxt.Name = "collidtxt";
            this.collidtxt.ReadOnly = true;
            this.collidtxt.Size = new System.Drawing.Size(257, 20);
            this.collidtxt.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Collection ID : ";
            // 
            // periodtxt
            // 
            this.periodtxt.Location = new System.Drawing.Point(15, 103);
            this.periodtxt.Name = "periodtxt";
            this.periodtxt.ReadOnly = true;
            this.periodtxt.Size = new System.Drawing.Size(257, 20);
            this.periodtxt.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Loan Period : ";
            // 
            // purposetxt
            // 
            this.purposetxt.Location = new System.Drawing.Point(15, 142);
            this.purposetxt.Multiline = true;
            this.purposetxt.Name = "purposetxt";
            this.purposetxt.ReadOnly = true;
            this.purposetxt.Size = new System.Drawing.Size(257, 60);
            this.purposetxt.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Loan Purpose : ";
            // 
            // pricetxt
            // 
            this.pricetxt.Location = new System.Drawing.Point(15, 221);
            this.pricetxt.Name = "pricetxt";
            this.pricetxt.ReadOnly = true;
            this.pricetxt.Size = new System.Drawing.Size(257, 20);
            this.pricetxt.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Loan Price : ";
            // 
            // cancelbtn
            // 
            this.cancelbtn.Location = new System.Drawing.Point(197, 256);
            this.cancelbtn.Name = "cancelbtn";
            this.cancelbtn.Size = new System.Drawing.Size(75, 23);
            this.cancelbtn.TabIndex = 10;
            this.cancelbtn.Text = "Cancel";
            this.cancelbtn.UseVisualStyleBackColor = true;
            this.cancelbtn.Click += new System.EventHandler(this.cancelbtn_Click);
            // 
            // Loan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 291);
            this.Controls.Add(this.cancelbtn);
            this.Controls.Add(this.pricetxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.purposetxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.periodtxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.collidtxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.memberidtxt);
            this.Controls.Add(this.label1);
            this.Name = "Loan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loan";
            this.Load += new System.EventHandler(this.Loan_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox memberidtxt;
        private System.Windows.Forms.TextBox collidtxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox periodtxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox purposetxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox pricetxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button cancelbtn;
    }
}