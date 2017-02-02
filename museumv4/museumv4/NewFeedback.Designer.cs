namespace museumv4
{
    partial class NewFeedback
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
            this.newbtn = new System.Windows.Forms.Button();
            this.removebtn = new System.Windows.Forms.Button();
            this.editbtn = new System.Windows.Forms.Button();
            this.feedback_panel = new System.Windows.Forms.Panel();
            this.add_btn = new System.Windows.Forms.Button();
            this.question_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.question_list = new System.Windows.Forms.ListBox();
            this.edit_panel = new System.Windows.Forms.Panel();
            this.asda = new System.Windows.Forms.Label();
            this.edit_q_txt = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.OK_btn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.table_name_txt = new System.Windows.Forms.Label();
            this.feedback_panel.SuspendLayout();
            this.edit_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // newbtn
            // 
            this.newbtn.Location = new System.Drawing.Point(397, 326);
            this.newbtn.Name = "newbtn";
            this.newbtn.Size = new System.Drawing.Size(75, 23);
            this.newbtn.TabIndex = 0;
            this.newbtn.Text = "New";
            this.newbtn.UseVisualStyleBackColor = true;
            this.newbtn.Click += new System.EventHandler(this.newbtn_Click);
            // 
            // removebtn
            // 
            this.removebtn.Location = new System.Drawing.Point(316, 326);
            this.removebtn.Name = "removebtn";
            this.removebtn.Size = new System.Drawing.Size(75, 23);
            this.removebtn.TabIndex = 1;
            this.removebtn.Text = "Remove";
            this.removebtn.UseVisualStyleBackColor = true;
            this.removebtn.Click += new System.EventHandler(this.removebtn_Click);
            // 
            // editbtn
            // 
            this.editbtn.Location = new System.Drawing.Point(235, 326);
            this.editbtn.Name = "editbtn";
            this.editbtn.Size = new System.Drawing.Size(75, 23);
            this.editbtn.TabIndex = 2;
            this.editbtn.Text = "Edit";
            this.editbtn.UseVisualStyleBackColor = true;
            this.editbtn.Click += new System.EventHandler(this.editbtn_Click);
            // 
            // feedback_panel
            // 
            this.feedback_panel.Controls.Add(this.table_name_txt);
            this.feedback_panel.Controls.Add(this.label3);
            this.feedback_panel.Controls.Add(this.add_btn);
            this.feedback_panel.Controls.Add(this.label1);
            this.feedback_panel.Controls.Add(this.question_txt);
            this.feedback_panel.Location = new System.Drawing.Point(43, 40);
            this.feedback_panel.Name = "feedback_panel";
            this.feedback_panel.Size = new System.Drawing.Size(390, 140);
            this.feedback_panel.TabIndex = 3;
            this.feedback_panel.Visible = false;
            // 
            // add_btn
            // 
            this.add_btn.Location = new System.Drawing.Point(312, 114);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(75, 23);
            this.add_btn.TabIndex = 11;
            this.add_btn.Text = "Add";
            this.add_btn.UseVisualStyleBackColor = true;
            this.add_btn.Visible = false;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // question_txt
            // 
            this.question_txt.Location = new System.Drawing.Point(16, 46);
            this.question_txt.Multiline = true;
            this.question_txt.Name = "question_txt";
            this.question_txt.Size = new System.Drawing.Size(355, 54);
            this.question_txt.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Question: ";
            // 
            // question_list
            // 
            this.question_list.FormattingEnabled = true;
            this.question_list.Location = new System.Drawing.Point(12, 12);
            this.question_list.Name = "question_list";
            this.question_list.Size = new System.Drawing.Size(444, 277);
            this.question_list.TabIndex = 4;
            // 
            // edit_panel
            // 
            this.edit_panel.Controls.Add(this.OK_btn);
            this.edit_panel.Controls.Add(this.label10);
            this.edit_panel.Controls.Add(this.edit_q_txt);
            this.edit_panel.Controls.Add(this.asda);
            this.edit_panel.Location = new System.Drawing.Point(113, 39);
            this.edit_panel.Name = "edit_panel";
            this.edit_panel.Size = new System.Drawing.Size(278, 138);
            this.edit_panel.TabIndex = 5;
            this.edit_panel.Visible = false;
            // 
            // asda
            // 
            this.asda.AutoSize = true;
            this.asda.Location = new System.Drawing.Point(9, 48);
            this.asda.Name = "asda";
            this.asda.Size = new System.Drawing.Size(52, 13);
            this.asda.TabIndex = 0;
            this.asda.Text = "Question:";
            // 
            // edit_q_txt
            // 
            this.edit_q_txt.Location = new System.Drawing.Point(12, 64);
            this.edit_q_txt.Multiline = true;
            this.edit_q_txt.Name = "edit_q_txt";
            this.edit_q_txt.Size = new System.Drawing.Size(248, 39);
            this.edit_q_txt.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 15);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "Edit Question";
            // 
            // OK_btn
            // 
            this.OK_btn.Location = new System.Drawing.Point(203, 109);
            this.OK_btn.Name = "OK_btn";
            this.OK_btn.Size = new System.Drawing.Size(75, 23);
            this.OK_btn.TabIndex = 15;
            this.OK_btn.Text = "OK";
            this.OK_btn.UseVisualStyleBackColor = true;
            this.OK_btn.Click += new System.EventHandler(this.OK_btn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Table name:";
            // 
            // table_name_txt
            // 
            this.table_name_txt.AutoSize = true;
            this.table_name_txt.Location = new System.Drawing.Point(85, 11);
            this.table_name_txt.Name = "table_name_txt";
            this.table_name_txt.Size = new System.Drawing.Size(62, 13);
            this.table_name_txt.TabIndex = 13;
            this.table_name_txt.Text = "table_name";
            // 
            // new_feedback
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.edit_panel);
            this.Controls.Add(this.feedback_panel);
            this.Controls.Add(this.editbtn);
            this.Controls.Add(this.removebtn);
            this.Controls.Add(this.newbtn);
            this.Controls.Add(this.question_list);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "new_feedback";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Feedback";
            this.feedback_panel.ResumeLayout(false);
            this.feedback_panel.PerformLayout();
            this.edit_panel.ResumeLayout(false);
            this.edit_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button newbtn;
        private System.Windows.Forms.Button removebtn;
        private System.Windows.Forms.Button editbtn;
        private System.Windows.Forms.Panel feedback_panel;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.TextBox question_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox question_list;
        private System.Windows.Forms.Panel edit_panel;
        private System.Windows.Forms.Button OK_btn;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox edit_q_txt;
        private System.Windows.Forms.Label asda;
        private System.Windows.Forms.Label table_name_txt;
        private System.Windows.Forms.Label label3;
    }
}