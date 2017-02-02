namespace museumv4
{
    partial class Feedback
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
            this.cancelbtn = new System.Windows.Forms.Button();
            this.submitbtn = new System.Windows.Forms.Button();
            this.feedbacklist = new System.Windows.Forms.ListBox();
            this.question_list_view = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // cancelbtn
            // 
            this.cancelbtn.Location = new System.Drawing.Point(397, 326);
            this.cancelbtn.Name = "cancelbtn";
            this.cancelbtn.Size = new System.Drawing.Size(75, 23);
            this.cancelbtn.TabIndex = 1;
            this.cancelbtn.Text = "Cancel";
            this.cancelbtn.UseVisualStyleBackColor = true;
            this.cancelbtn.Click += new System.EventHandler(this.cancelbtn_Click);
            // 
            // submitbtn
            // 
            this.submitbtn.Location = new System.Drawing.Point(316, 326);
            this.submitbtn.Name = "submitbtn";
            this.submitbtn.Size = new System.Drawing.Size(75, 23);
            this.submitbtn.TabIndex = 2;
            this.submitbtn.Text = "View";
            this.submitbtn.UseVisualStyleBackColor = true;
            this.submitbtn.Click += new System.EventHandler(this.submitbtn_Click);
            // 
            // feedbacklist
            // 
            this.feedbacklist.FormattingEnabled = true;
            this.feedbacklist.Location = new System.Drawing.Point(12, 12);
            this.feedbacklist.Name = "feedbacklist";
            this.feedbacklist.Size = new System.Drawing.Size(466, 290);
            this.feedbacklist.TabIndex = 3;
            // 
            // question_list_view
            // 
            this.question_list_view.Location = new System.Drawing.Point(85, 53);
            this.question_list_view.Name = "question_list_view";
            this.question_list_view.Size = new System.Drawing.Size(322, 189);
            this.question_list_view.TabIndex = 5;
            this.question_list_view.UseCompatibleStateImageBehavior = false;
            this.question_list_view.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // feedback
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.question_list_view);
            this.Controls.Add(this.feedbacklist);
            this.Controls.Add(this.submitbtn);
            this.Controls.Add(this.cancelbtn);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "feedback";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Feedback";
            this.Load += new System.EventHandler(this.feedback_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button cancelbtn;
        private System.Windows.Forms.Button submitbtn;
        private System.Windows.Forms.ListBox feedbacklist;
        private System.Windows.Forms.ListView question_list_view;
    }
}