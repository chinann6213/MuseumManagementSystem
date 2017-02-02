namespace museumv4
{
    partial class Event
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
            this.titletxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.detailtxt = new System.Windows.Forms.TextBox();
            this.cancelbtn = new System.Windows.Forms.Button();
            this.confirmbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Event Title : ";
            // 
            // titletxt
            // 
            this.titletxt.Location = new System.Drawing.Point(15, 25);
            this.titletxt.Name = "titletxt";
            this.titletxt.ReadOnly = true;
            this.titletxt.Size = new System.Drawing.Size(274, 20);
            this.titletxt.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Event Date : ";
            // 
            // date
            // 
            this.date.Enabled = false;
            this.date.Location = new System.Drawing.Point(15, 64);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(274, 20);
            this.date.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Event Detail : ";
            // 
            // detailtxt
            // 
            this.detailtxt.Location = new System.Drawing.Point(15, 103);
            this.detailtxt.Multiline = true;
            this.detailtxt.Name = "detailtxt";
            this.detailtxt.ReadOnly = true;
            this.detailtxt.Size = new System.Drawing.Size(274, 60);
            this.detailtxt.TabIndex = 5;
            // 
            // cancelbtn
            // 
            this.cancelbtn.Location = new System.Drawing.Point(214, 174);
            this.cancelbtn.Name = "cancelbtn";
            this.cancelbtn.Size = new System.Drawing.Size(75, 23);
            this.cancelbtn.TabIndex = 6;
            this.cancelbtn.Text = "Cancel";
            this.cancelbtn.UseVisualStyleBackColor = true;
            this.cancelbtn.Click += new System.EventHandler(this.cancelbtn_Click_1);
            // 
            // confirmbtn
            // 
            this.confirmbtn.Location = new System.Drawing.Point(133, 174);
            this.confirmbtn.Name = "confirmbtn";
            this.confirmbtn.Size = new System.Drawing.Size(75, 23);
            this.confirmbtn.TabIndex = 7;
            this.confirmbtn.Text = "Confirm";
            this.confirmbtn.UseVisualStyleBackColor = true;
            this.confirmbtn.Visible = false;
            this.confirmbtn.Click += new System.EventHandler(this.confirmbtn_Click_1);
            // 
            // event_detail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 209);
            this.Controls.Add(this.confirmbtn);
            this.Controls.Add(this.cancelbtn);
            this.Controls.Add(this.detailtxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.date);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.titletxt);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "event_detail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Event";
            this.Load += new System.EventHandler(this.event_detail_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox titletxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox detailtxt;
        private System.Windows.Forms.Button cancelbtn;
        private System.Windows.Forms.Button confirmbtn;
    }
}