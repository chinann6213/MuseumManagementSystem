namespace museumv4
{
    partial class Employee
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
            this.wrktxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cancelbtn = new System.Windows.Forms.Button();
            this.confirmbtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.indate = new System.Windows.Forms.DateTimePicker();
            this.outdate = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name : ";
            // 
            // nametxt
            // 
            this.nametxt.Location = new System.Drawing.Point(12, 25);
            this.nametxt.Name = "nametxt";
            this.nametxt.ReadOnly = true;
            this.nametxt.Size = new System.Drawing.Size(243, 20);
            this.nametxt.TabIndex = 1;
            // 
            // wrktxt
            // 
            this.wrktxt.Location = new System.Drawing.Point(12, 64);
            this.wrktxt.Name = "wrktxt";
            this.wrktxt.ReadOnly = true;
            this.wrktxt.Size = new System.Drawing.Size(243, 20);
            this.wrktxt.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Working Hour : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Check Out : ";
            // 
            // cancelbtn
            // 
            this.cancelbtn.Location = new System.Drawing.Point(188, 176);
            this.cancelbtn.Name = "cancelbtn";
            this.cancelbtn.Size = new System.Drawing.Size(75, 23);
            this.cancelbtn.TabIndex = 8;
            this.cancelbtn.Text = "Cancel";
            this.cancelbtn.UseVisualStyleBackColor = true;
            this.cancelbtn.Click += new System.EventHandler(this.cancelbtn_Click_1);
            // 
            // confirmbtn
            // 
            this.confirmbtn.Location = new System.Drawing.Point(107, 176);
            this.confirmbtn.Name = "confirmbtn";
            this.confirmbtn.Size = new System.Drawing.Size(75, 23);
            this.confirmbtn.TabIndex = 9;
            this.confirmbtn.Text = "Confirm";
            this.confirmbtn.UseVisualStyleBackColor = true;
            this.confirmbtn.Visible = false;
            this.confirmbtn.Click += new System.EventHandler(this.confirmbtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Check In :";
            // 
            // indate
            // 
            this.indate.Enabled = false;
            this.indate.Location = new System.Drawing.Point(12, 103);
            this.indate.Name = "indate";
            this.indate.Size = new System.Drawing.Size(243, 20);
            this.indate.TabIndex = 11;
            // 
            // outdate
            // 
            this.outdate.Enabled = false;
            this.outdate.Location = new System.Drawing.Point(12, 142);
            this.outdate.Name = "outdate";
            this.outdate.Size = new System.Drawing.Size(243, 20);
            this.outdate.TabIndex = 12;
            // 
            // employee_details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 211);
            this.Controls.Add(this.outdate);
            this.Controls.Add(this.indate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.confirmbtn);
            this.Controls.Add(this.cancelbtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.wrktxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nametxt);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "employee_details";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee";
            this.Load += new System.EventHandler(this.employee_details_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nametxt;
        private System.Windows.Forms.TextBox wrktxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button cancelbtn;
        private System.Windows.Forms.Button confirmbtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker indate;
        private System.Windows.Forms.DateTimePicker outdate;
    }
}