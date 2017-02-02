namespace museumv4
{
    partial class MainScreen
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
            this.emailtxt = new System.Windows.Forms.TextBox();
            this.pwtxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.loginbtn = new System.Windows.Forms.Button();
            this.registerlink = new System.Windows.Forms.LinkLabel();
            this.viewtabcontrol = new System.Windows.Forms.TabControl();
            this.collectiontab = new System.Windows.Forms.TabPage();
            this.collectionlist = new System.Windows.Forms.ListBox();
            this.eventtab = new System.Windows.Forms.TabPage();
            this.eventlist = new System.Windows.Forms.ListBox();
            this.souvenirtab = new System.Windows.Forms.TabPage();
            this.souvenirlist = new System.Windows.Forms.ListBox();
            this.detailsbtn = new System.Windows.Forms.Button();
            this.searchtxt = new System.Windows.Forms.TextBox();
            this.searchbtn = new System.Windows.Forms.Button();
            this.feedbacklink = new System.Windows.Forms.LinkLabel();
            this.emptylbl = new System.Windows.Forms.Label();
            this.viewtabcontrol.SuspendLayout();
            this.collectiontab.SuspendLayout();
            this.eventtab.SuspendLayout();
            this.souvenirtab.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(470, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Email : ";
            // 
            // emailtxt
            // 
            this.emailtxt.Location = new System.Drawing.Point(517, 23);
            this.emailtxt.Name = "emailtxt";
            this.emailtxt.Size = new System.Drawing.Size(155, 20);
            this.emailtxt.TabIndex = 1;
            // 
            // pwtxt
            // 
            this.pwtxt.Location = new System.Drawing.Point(517, 49);
            this.pwtxt.Name = "pwtxt";
            this.pwtxt.PasswordChar = '*';
            this.pwtxt.Size = new System.Drawing.Size(155, 20);
            this.pwtxt.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(449, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password : ";
            // 
            // loginbtn
            // 
            this.loginbtn.Location = new System.Drawing.Point(597, 80);
            this.loginbtn.Name = "loginbtn";
            this.loginbtn.Size = new System.Drawing.Size(75, 23);
            this.loginbtn.TabIndex = 4;
            this.loginbtn.Text = "Login";
            this.loginbtn.UseVisualStyleBackColor = true;
            this.loginbtn.Click += new System.EventHandler(this.loginbtn_Click);
            // 
            // registerlink
            // 
            this.registerlink.AutoSize = true;
            this.registerlink.Location = new System.Drawing.Point(507, 85);
            this.registerlink.Name = "registerlink";
            this.registerlink.Size = new System.Drawing.Size(84, 13);
            this.registerlink.TabIndex = 5;
            this.registerlink.TabStop = true;
            this.registerlink.Text = "Still not register?";
            this.registerlink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.registerlink_LinkClicked);
            // 
            // viewtabcontrol
            // 
            this.viewtabcontrol.Controls.Add(this.collectiontab);
            this.viewtabcontrol.Controls.Add(this.eventtab);
            this.viewtabcontrol.Controls.Add(this.souvenirtab);
            this.viewtabcontrol.Location = new System.Drawing.Point(0, 174);
            this.viewtabcontrol.Name = "viewtabcontrol";
            this.viewtabcontrol.SelectedIndex = 0;
            this.viewtabcontrol.Size = new System.Drawing.Size(683, 346);
            this.viewtabcontrol.TabIndex = 6;
            // 
            // collectiontab
            // 
            this.collectiontab.Controls.Add(this.collectionlist);
            this.collectiontab.Location = new System.Drawing.Point(4, 22);
            this.collectiontab.Name = "collectiontab";
            this.collectiontab.Padding = new System.Windows.Forms.Padding(3);
            this.collectiontab.Size = new System.Drawing.Size(675, 320);
            this.collectiontab.TabIndex = 0;
            this.collectiontab.Text = "Collection";
            this.collectiontab.UseVisualStyleBackColor = true;
            // 
            // collectionlist
            // 
            this.collectionlist.FormattingEnabled = true;
            this.collectionlist.Location = new System.Drawing.Point(0, 6);
            this.collectionlist.Name = "collectionlist";
            this.collectionlist.Size = new System.Drawing.Size(675, 303);
            this.collectionlist.TabIndex = 0;
            // 
            // eventtab
            // 
            this.eventtab.Controls.Add(this.eventlist);
            this.eventtab.Location = new System.Drawing.Point(4, 22);
            this.eventtab.Name = "eventtab";
            this.eventtab.Padding = new System.Windows.Forms.Padding(3);
            this.eventtab.Size = new System.Drawing.Size(675, 320);
            this.eventtab.TabIndex = 1;
            this.eventtab.Text = "Event";
            this.eventtab.UseVisualStyleBackColor = true;
            // 
            // eventlist
            // 
            this.eventlist.FormattingEnabled = true;
            this.eventlist.Location = new System.Drawing.Point(0, 9);
            this.eventlist.Name = "eventlist";
            this.eventlist.Size = new System.Drawing.Size(675, 303);
            this.eventlist.TabIndex = 1;
            // 
            // souvenirtab
            // 
            this.souvenirtab.Controls.Add(this.souvenirlist);
            this.souvenirtab.Location = new System.Drawing.Point(4, 22);
            this.souvenirtab.Name = "souvenirtab";
            this.souvenirtab.Padding = new System.Windows.Forms.Padding(3);
            this.souvenirtab.Size = new System.Drawing.Size(675, 320);
            this.souvenirtab.TabIndex = 2;
            this.souvenirtab.Text = "Souvenir";
            this.souvenirtab.UseVisualStyleBackColor = true;
            // 
            // souvenirlist
            // 
            this.souvenirlist.FormattingEnabled = true;
            this.souvenirlist.Location = new System.Drawing.Point(0, 9);
            this.souvenirlist.Name = "souvenirlist";
            this.souvenirlist.Size = new System.Drawing.Size(675, 303);
            this.souvenirlist.TabIndex = 1;
            // 
            // detailsbtn
            // 
            this.detailsbtn.Location = new System.Drawing.Point(597, 526);
            this.detailsbtn.Name = "detailsbtn";
            this.detailsbtn.Size = new System.Drawing.Size(75, 23);
            this.detailsbtn.TabIndex = 7;
            this.detailsbtn.Text = "View Details";
            this.detailsbtn.UseVisualStyleBackColor = true;
            this.detailsbtn.Click += new System.EventHandler(this.detailsbtn_Click);
            // 
            // searchtxt
            // 
            this.searchtxt.Location = new System.Drawing.Point(347, 148);
            this.searchtxt.Name = "searchtxt";
            this.searchtxt.Size = new System.Drawing.Size(244, 20);
            this.searchtxt.TabIndex = 0;
            // 
            // searchbtn
            // 
            this.searchbtn.Location = new System.Drawing.Point(597, 145);
            this.searchbtn.Name = "searchbtn";
            this.searchbtn.Size = new System.Drawing.Size(75, 23);
            this.searchbtn.TabIndex = 8;
            this.searchbtn.Text = "Search";
            this.searchbtn.UseVisualStyleBackColor = true;
            this.searchbtn.Click += new System.EventHandler(this.searchbtn_Click);
            // 
            // feedbacklink
            // 
            this.feedbacklink.AutoSize = true;
            this.feedbacklink.Location = new System.Drawing.Point(12, 539);
            this.feedbacklink.Name = "feedbacklink";
            this.feedbacklink.Size = new System.Drawing.Size(55, 13);
            this.feedbacklink.TabIndex = 9;
            this.feedbacklink.TabStop = true;
            this.feedbacklink.Text = "Feedback";
            this.feedbacklink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.feedbacklink_LinkClicked);
            // 
            // emptylbl
            // 
            this.emptylbl.AutoSize = true;
            this.emptylbl.Location = new System.Drawing.Point(356, 132);
            this.emptylbl.Name = "emptylbl";
            this.emptylbl.Size = new System.Drawing.Size(10, 13);
            this.emptylbl.TabIndex = 1;
            this.emptylbl.Text = " ";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 561);
            this.Controls.Add(this.emptylbl);
            this.Controls.Add(this.feedbacklink);
            this.Controls.Add(this.searchbtn);
            this.Controls.Add(this.searchtxt);
            this.Controls.Add(this.detailsbtn);
            this.Controls.Add(this.viewtabcontrol);
            this.Controls.Add(this.registerlink);
            this.Controls.Add(this.loginbtn);
            this.Controls.Add(this.pwtxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.emailtxt);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game Museum Management System";
            this.Load += new System.EventHandler(this.Main_Load);
            this.viewtabcontrol.ResumeLayout(false);
            this.collectiontab.ResumeLayout(false);
            this.eventtab.ResumeLayout(false);
            this.souvenirtab.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox emailtxt;
        private System.Windows.Forms.TextBox pwtxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button loginbtn;
        private System.Windows.Forms.LinkLabel registerlink;
        private System.Windows.Forms.TabControl viewtabcontrol;
        private System.Windows.Forms.TabPage collectiontab;
        private System.Windows.Forms.ListBox collectionlist;
        private System.Windows.Forms.TabPage eventtab;
        private System.Windows.Forms.ListBox eventlist;
        private System.Windows.Forms.TabPage souvenirtab;
        private System.Windows.Forms.Button detailsbtn;
        private System.Windows.Forms.TextBox searchtxt;
        private System.Windows.Forms.Button searchbtn;
        private System.Windows.Forms.LinkLabel feedbacklink;
        private System.Windows.Forms.Label emptylbl;
        private System.Windows.Forms.ListBox souvenirlist;
    }
}

