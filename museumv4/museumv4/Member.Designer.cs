namespace museumv4
{
    partial class Member
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
            this.membertabcontrol = new System.Windows.Forms.TabControl();
            this.donatetab = new System.Windows.Forms.TabPage();
            this.donate_price = new System.Windows.Forms.Label();
            this.pricetxt_donate = new System.Windows.Forms.TextBox();
            this.submitbtn = new System.Windows.Forms.Button();
            this.discardbtn = new System.Windows.Forms.Button();
            this.browsebtn_donate = new System.Windows.Forms.Button();
            this.donate_detail = new System.Windows.Forms.Label();
            this.detailtxt_donate = new System.Windows.Forms.TextBox();
            this.donate_name = new System.Windows.Forms.Label();
            this.nametxt_donate = new System.Windows.Forms.TextBox();
            this.donate_pic = new System.Windows.Forms.PictureBox();
            this.loantab = new System.Windows.Forms.TabPage();
            this.collname_txt = new System.Windows.Forms.Label();
            this.charge = new System.Windows.Forms.Label();
            this.browse_panel = new System.Windows.Forms.Panel();
            this.coll_listbox = new System.Windows.Forms.ListBox();
            this.close_collbtn = new System.Windows.Forms.Button();
            this.select_collbtn = new System.Windows.Forms.Button();
            this.view_collbtn = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.enddatepicker = new System.Windows.Forms.DateTimePicker();
            this.startdatepicker = new System.Windows.Forms.DateTimePicker();
            this.browsebtn_loan = new System.Windows.Forms.Button();
            this.submitbtn_loan = new System.Windows.Forms.Button();
            this.discardbtn_loan = new System.Windows.Forms.Button();
            this.purposetxt_loan = new System.Windows.Forms.TextBox();
            this.loan_purpose = new System.Windows.Forms.Label();
            this.loan_period = new System.Windows.Forms.Label();
            this.loan_charge = new System.Windows.Forms.Label();
            this.coll_name = new System.Windows.Forms.Label();
            this.ordertab = new System.Windows.Forms.TabPage();
            this.ordertabcontrol = new System.Windows.Forms.TabControl();
            this.tickettab = new System.Windows.Forms.TabPage();
            this.totalpricetxt_ticket = new System.Windows.Forms.TextBox();
            this.quantitytxt_ticket = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.datepicker_tic = new System.Windows.Forms.DateTimePicker();
            this.proceedbtn_ticket = new System.Windows.Forms.Button();
            this.discardbtn_ticket = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.numchildrentxt_ticket = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.numadulttxt_ticket = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.souvenirtab = new System.Windows.Forms.TabPage();
            this.browse_souv_panel = new System.Windows.Forms.Panel();
            this.close_souv_btn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.selectsouv_btn = new System.Windows.Forms.Button();
            this.souv_listbox = new System.Windows.Forms.ListBox();
            this.discardbtn_souvenir = new System.Windows.Forms.Button();
            this.addcartbtn_souvenir = new System.Windows.Forms.Button();
            this.viewshoppingbtn_souvenir = new System.Windows.Forms.Button();
            this.browsebtn_souvenir = new System.Windows.Forms.Button();
            this.totalpricetxt_souvenir = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.quantitytxt_souvenir = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.nametxt_souvenir = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.log_out = new System.Windows.Forms.LinkLabel();
            this.membertabcontrol.SuspendLayout();
            this.donatetab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.donate_pic)).BeginInit();
            this.loantab.SuspendLayout();
            this.browse_panel.SuspendLayout();
            this.ordertab.SuspendLayout();
            this.ordertabcontrol.SuspendLayout();
            this.tickettab.SuspendLayout();
            this.souvenirtab.SuspendLayout();
            this.browse_souv_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(412, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome , Member";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // membertabcontrol
            // 
            this.membertabcontrol.Controls.Add(this.donatetab);
            this.membertabcontrol.Controls.Add(this.loantab);
            this.membertabcontrol.Controls.Add(this.ordertab);
            this.membertabcontrol.Location = new System.Drawing.Point(0, 101);
            this.membertabcontrol.Name = "membertabcontrol";
            this.membertabcontrol.SelectedIndex = 0;
            this.membertabcontrol.Size = new System.Drawing.Size(584, 360);
            this.membertabcontrol.TabIndex = 2;
            // 
            // donatetab
            // 
            this.donatetab.Controls.Add(this.donate_price);
            this.donatetab.Controls.Add(this.pricetxt_donate);
            this.donatetab.Controls.Add(this.submitbtn);
            this.donatetab.Controls.Add(this.discardbtn);
            this.donatetab.Controls.Add(this.browsebtn_donate);
            this.donatetab.Controls.Add(this.donate_detail);
            this.donatetab.Controls.Add(this.detailtxt_donate);
            this.donatetab.Controls.Add(this.donate_name);
            this.donatetab.Controls.Add(this.nametxt_donate);
            this.donatetab.Controls.Add(this.donate_pic);
            this.donatetab.Location = new System.Drawing.Point(4, 22);
            this.donatetab.Name = "donatetab";
            this.donatetab.Padding = new System.Windows.Forms.Padding(3);
            this.donatetab.Size = new System.Drawing.Size(576, 334);
            this.donatetab.TabIndex = 0;
            this.donatetab.Text = "Donate";
            this.donatetab.UseVisualStyleBackColor = true;
            this.donatetab.Leave += new System.EventHandler(this.pricetxt_donate_TextChanged);
            // 
            // donate_price
            // 
            this.donate_price.AutoSize = true;
            this.donate_price.Location = new System.Drawing.Point(22, 141);
            this.donate_price.Name = "donate_price";
            this.donate_price.Size = new System.Drawing.Size(40, 13);
            this.donate_price.TabIndex = 10;
            this.donate_price.Text = "Price  :";
            // 
            // pricetxt_donate
            // 
            this.pricetxt_donate.Location = new System.Drawing.Point(71, 138);
            this.pricetxt_donate.Name = "pricetxt_donate";
            this.pricetxt_donate.Size = new System.Drawing.Size(267, 20);
            this.pricetxt_donate.TabIndex = 9;
            this.pricetxt_donate.TextChanged += new System.EventHandler(this.pricetxt_donate_TextChanged_1);
            this.pricetxt_donate.Leave += new System.EventHandler(this.pricetxt_donate_TextChanged);
            // 
            // submitbtn
            // 
            this.submitbtn.Location = new System.Drawing.Point(407, 303);
            this.submitbtn.Name = "submitbtn";
            this.submitbtn.Size = new System.Drawing.Size(75, 23);
            this.submitbtn.TabIndex = 7;
            this.submitbtn.Text = "Submit";
            this.submitbtn.UseVisualStyleBackColor = true;
            this.submitbtn.Click += new System.EventHandler(this.submitbtn_Click);
            // 
            // discardbtn
            // 
            this.discardbtn.Location = new System.Drawing.Point(488, 303);
            this.discardbtn.Name = "discardbtn";
            this.discardbtn.Size = new System.Drawing.Size(75, 23);
            this.discardbtn.TabIndex = 6;
            this.discardbtn.Text = "Discard";
            this.discardbtn.UseVisualStyleBackColor = true;
            this.discardbtn.Click += new System.EventHandler(this.discardbtn_Click);
            // 
            // browsebtn_donate
            // 
            this.browsebtn_donate.Location = new System.Drawing.Point(444, 176);
            this.browsebtn_donate.Name = "browsebtn_donate";
            this.browsebtn_donate.Size = new System.Drawing.Size(75, 23);
            this.browsebtn_donate.TabIndex = 5;
            this.browsebtn_donate.Text = "Browse";
            this.browsebtn_donate.UseVisualStyleBackColor = true;
            this.browsebtn_donate.Click += new System.EventHandler(this.browsebtn_donate_Click);
            // 
            // donate_detail
            // 
            this.donate_detail.AutoSize = true;
            this.donate_detail.Location = new System.Drawing.Point(22, 60);
            this.donate_detail.Name = "donate_detail";
            this.donate_detail.Size = new System.Drawing.Size(40, 13);
            this.donate_detail.TabIndex = 4;
            this.donate_detail.Text = "Detail :";
            // 
            // detailtxt_donate
            // 
            this.detailtxt_donate.Location = new System.Drawing.Point(71, 57);
            this.detailtxt_donate.Multiline = true;
            this.detailtxt_donate.Name = "detailtxt_donate";
            this.detailtxt_donate.Size = new System.Drawing.Size(267, 75);
            this.detailtxt_donate.TabIndex = 3;
            // 
            // donate_name
            // 
            this.donate_name.AutoSize = true;
            this.donate_name.Location = new System.Drawing.Point(22, 34);
            this.donate_name.Name = "donate_name";
            this.donate_name.Size = new System.Drawing.Size(44, 13);
            this.donate_name.TabIndex = 2;
            this.donate_name.Text = "Name : ";
            // 
            // nametxt_donate
            // 
            this.nametxt_donate.Location = new System.Drawing.Point(71, 31);
            this.nametxt_donate.Name = "nametxt_donate";
            this.nametxt_donate.Size = new System.Drawing.Size(267, 20);
            this.nametxt_donate.TabIndex = 1;
            // 
            // donate_pic
            // 
            this.donate_pic.BackColor = System.Drawing.Color.LightGray;
            this.donate_pic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.donate_pic.Location = new System.Drawing.Point(398, 31);
            this.donate_pic.Name = "donate_pic";
            this.donate_pic.Size = new System.Drawing.Size(165, 139);
            this.donate_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.donate_pic.TabIndex = 0;
            this.donate_pic.TabStop = false;
            // 
            // loantab
            // 
            this.loantab.Controls.Add(this.collname_txt);
            this.loantab.Controls.Add(this.charge);
            this.loantab.Controls.Add(this.browse_panel);
            this.loantab.Controls.Add(this.label19);
            this.loantab.Controls.Add(this.label18);
            this.loantab.Controls.Add(this.enddatepicker);
            this.loantab.Controls.Add(this.startdatepicker);
            this.loantab.Controls.Add(this.browsebtn_loan);
            this.loantab.Controls.Add(this.submitbtn_loan);
            this.loantab.Controls.Add(this.discardbtn_loan);
            this.loantab.Controls.Add(this.purposetxt_loan);
            this.loantab.Controls.Add(this.loan_purpose);
            this.loantab.Controls.Add(this.loan_period);
            this.loantab.Controls.Add(this.loan_charge);
            this.loantab.Controls.Add(this.coll_name);
            this.loantab.Location = new System.Drawing.Point(4, 22);
            this.loantab.Name = "loantab";
            this.loantab.Padding = new System.Windows.Forms.Padding(3);
            this.loantab.Size = new System.Drawing.Size(576, 334);
            this.loantab.TabIndex = 1;
            this.loantab.Text = "Loan";
            this.loantab.UseVisualStyleBackColor = true;
            // 
            // collname_txt
            // 
            this.collname_txt.AutoSize = true;
            this.collname_txt.BackColor = System.Drawing.Color.DarkGray;
            this.collname_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.collname_txt.Location = new System.Drawing.Point(190, 63);
            this.collname_txt.Name = "collname_txt";
            this.collname_txt.Size = new System.Drawing.Size(84, 15);
            this.collname_txt.TabIndex = 21;
            this.collname_txt.Text = "Collection name";
            // 
            // charge
            // 
            this.charge.AutoSize = true;
            this.charge.Location = new System.Drawing.Point(189, 86);
            this.charge.Name = "charge";
            this.charge.Size = new System.Drawing.Size(40, 13);
            this.charge.TabIndex = 20;
            this.charge.Text = "charge";
            // 
            // browse_panel
            // 
            this.browse_panel.Controls.Add(this.coll_listbox);
            this.browse_panel.Controls.Add(this.close_collbtn);
            this.browse_panel.Controls.Add(this.select_collbtn);
            this.browse_panel.Controls.Add(this.view_collbtn);
            this.browse_panel.Location = new System.Drawing.Point(65, 26);
            this.browse_panel.Name = "browse_panel";
            this.browse_panel.Size = new System.Drawing.Size(452, 271);
            this.browse_panel.TabIndex = 19;
            this.browse_panel.Visible = false;
            // 
            // coll_listbox
            // 
            this.coll_listbox.FormattingEnabled = true;
            this.coll_listbox.Location = new System.Drawing.Point(12, 15);
            this.coll_listbox.Name = "coll_listbox";
            this.coll_listbox.Size = new System.Drawing.Size(430, 212);
            this.coll_listbox.TabIndex = 15;
            this.coll_listbox.SelectedIndexChanged += new System.EventHandler(this.coll_listbox_SelectedIndexChanged);
            // 
            // close_collbtn
            // 
            this.close_collbtn.Location = new System.Drawing.Point(368, 233);
            this.close_collbtn.Name = "close_collbtn";
            this.close_collbtn.Size = new System.Drawing.Size(75, 23);
            this.close_collbtn.TabIndex = 18;
            this.close_collbtn.Text = "Close";
            this.close_collbtn.UseVisualStyleBackColor = true;
            this.close_collbtn.Click += new System.EventHandler(this.close_collbtn_Click);
            // 
            // select_collbtn
            // 
            this.select_collbtn.Location = new System.Drawing.Point(206, 233);
            this.select_collbtn.Name = "select_collbtn";
            this.select_collbtn.Size = new System.Drawing.Size(75, 23);
            this.select_collbtn.TabIndex = 17;
            this.select_collbtn.Text = "Select";
            this.select_collbtn.UseVisualStyleBackColor = true;
            this.select_collbtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // view_collbtn
            // 
            this.view_collbtn.Location = new System.Drawing.Point(287, 233);
            this.view_collbtn.Name = "view_collbtn";
            this.view_collbtn.Size = new System.Drawing.Size(75, 23);
            this.view_collbtn.TabIndex = 16;
            this.view_collbtn.Text = "View Detail";
            this.view_collbtn.UseVisualStyleBackColor = true;
            this.view_collbtn.Click += new System.EventHandler(this.view_collbtn_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(396, 145);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(26, 13);
            this.label19.TabIndex = 14;
            this.label19.Text = "End";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(396, 115);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(29, 13);
            this.label18.TabIndex = 13;
            this.label18.Text = "Start";
            // 
            // enddatepicker
            // 
            this.enddatepicker.Location = new System.Drawing.Point(190, 138);
            this.enddatepicker.Name = "enddatepicker";
            this.enddatepicker.Size = new System.Drawing.Size(200, 20);
            this.enddatepicker.TabIndex = 12;
            this.enddatepicker.ValueChanged += new System.EventHandler(this.enddatepicker_ValueChanged);
            // 
            // startdatepicker
            // 
            this.startdatepicker.Location = new System.Drawing.Point(190, 112);
            this.startdatepicker.Name = "startdatepicker";
            this.startdatepicker.Size = new System.Drawing.Size(200, 20);
            this.startdatepicker.TabIndex = 11;
            this.startdatepicker.ValueChanged += new System.EventHandler(this.startdatepicker_ValueChanged);
            // 
            // browsebtn_loan
            // 
            this.browsebtn_loan.Location = new System.Drawing.Point(399, 58);
            this.browsebtn_loan.Name = "browsebtn_loan";
            this.browsebtn_loan.Size = new System.Drawing.Size(75, 23);
            this.browsebtn_loan.TabIndex = 10;
            this.browsebtn_loan.Text = "Browse";
            this.browsebtn_loan.UseVisualStyleBackColor = true;
            this.browsebtn_loan.Click += new System.EventHandler(this.browsebtn_loan_Click);
            // 
            // submitbtn_loan
            // 
            this.submitbtn_loan.Location = new System.Drawing.Point(407, 303);
            this.submitbtn_loan.Name = "submitbtn_loan";
            this.submitbtn_loan.Size = new System.Drawing.Size(75, 23);
            this.submitbtn_loan.TabIndex = 9;
            this.submitbtn_loan.Text = "Submit";
            this.submitbtn_loan.UseVisualStyleBackColor = true;
            this.submitbtn_loan.Click += new System.EventHandler(this.submitbtn_loan_Click);
            // 
            // discardbtn_loan
            // 
            this.discardbtn_loan.Location = new System.Drawing.Point(488, 303);
            this.discardbtn_loan.Name = "discardbtn_loan";
            this.discardbtn_loan.Size = new System.Drawing.Size(75, 23);
            this.discardbtn_loan.TabIndex = 8;
            this.discardbtn_loan.Text = "Discard";
            this.discardbtn_loan.UseVisualStyleBackColor = true;
            // 
            // purposetxt_loan
            // 
            this.purposetxt_loan.Location = new System.Drawing.Point(190, 164);
            this.purposetxt_loan.Multiline = true;
            this.purposetxt_loan.Name = "purposetxt_loan";
            this.purposetxt_loan.Size = new System.Drawing.Size(200, 75);
            this.purposetxt_loan.TabIndex = 7;
            // 
            // loan_purpose
            // 
            this.loan_purpose.AutoSize = true;
            this.loan_purpose.Location = new System.Drawing.Point(91, 164);
            this.loan_purpose.Name = "loan_purpose";
            this.loan_purpose.Size = new System.Drawing.Size(91, 13);
            this.loan_purpose.TabIndex = 6;
            this.loan_purpose.Text = "Loan Purpose    : ";
            // 
            // loan_period
            // 
            this.loan_period.AutoSize = true;
            this.loan_period.Location = new System.Drawing.Point(91, 115);
            this.loan_period.Name = "loan_period";
            this.loan_period.Size = new System.Drawing.Size(91, 13);
            this.loan_period.TabIndex = 4;
            this.loan_period.Text = "Loan Period       : ";
            // 
            // loan_charge
            // 
            this.loan_charge.AutoSize = true;
            this.loan_charge.Location = new System.Drawing.Point(91, 86);
            this.loan_charge.Name = "loan_charge";
            this.loan_charge.Size = new System.Drawing.Size(92, 13);
            this.loan_charge.TabIndex = 2;
            this.loan_charge.Text = "Loan Charge      : ";
            // 
            // coll_name
            // 
            this.coll_name.AutoSize = true;
            this.coll_name.Location = new System.Drawing.Point(91, 63);
            this.coll_name.Name = "coll_name";
            this.coll_name.Size = new System.Drawing.Size(93, 13);
            this.coll_name.TabIndex = 0;
            this.coll_name.Text = "Collection Name : ";
            // 
            // ordertab
            // 
            this.ordertab.Controls.Add(this.ordertabcontrol);
            this.ordertab.Location = new System.Drawing.Point(4, 22);
            this.ordertab.Name = "ordertab";
            this.ordertab.Padding = new System.Windows.Forms.Padding(3);
            this.ordertab.Size = new System.Drawing.Size(576, 334);
            this.ordertab.TabIndex = 2;
            this.ordertab.Text = "Order";
            this.ordertab.UseVisualStyleBackColor = true;
            // 
            // ordertabcontrol
            // 
            this.ordertabcontrol.Controls.Add(this.tickettab);
            this.ordertabcontrol.Controls.Add(this.souvenirtab);
            this.ordertabcontrol.Location = new System.Drawing.Point(0, 14);
            this.ordertabcontrol.Name = "ordertabcontrol";
            this.ordertabcontrol.SelectedIndex = 0;
            this.ordertabcontrol.Size = new System.Drawing.Size(580, 324);
            this.ordertabcontrol.TabIndex = 0;
            // 
            // tickettab
            // 
            this.tickettab.Controls.Add(this.totalpricetxt_ticket);
            this.tickettab.Controls.Add(this.quantitytxt_ticket);
            this.tickettab.Controls.Add(this.label3);
            this.tickettab.Controls.Add(this.label2);
            this.tickettab.Controls.Add(this.datepicker_tic);
            this.tickettab.Controls.Add(this.proceedbtn_ticket);
            this.tickettab.Controls.Add(this.discardbtn_ticket);
            this.tickettab.Controls.Add(this.label14);
            this.tickettab.Controls.Add(this.numchildrentxt_ticket);
            this.tickettab.Controls.Add(this.label10);
            this.tickettab.Controls.Add(this.numadulttxt_ticket);
            this.tickettab.Controls.Add(this.label11);
            this.tickettab.Controls.Add(this.label12);
            this.tickettab.Controls.Add(this.label13);
            this.tickettab.Location = new System.Drawing.Point(4, 22);
            this.tickettab.Name = "tickettab";
            this.tickettab.Padding = new System.Windows.Forms.Padding(3);
            this.tickettab.Size = new System.Drawing.Size(572, 298);
            this.tickettab.TabIndex = 0;
            this.tickettab.Text = "Ticket";
            this.tickettab.UseVisualStyleBackColor = true;
            this.tickettab.Click += new System.EventHandler(this.tickettab_Click);
            // 
            // totalpricetxt_ticket
            // 
            this.totalpricetxt_ticket.Location = new System.Drawing.Point(234, 178);
            this.totalpricetxt_ticket.Name = "totalpricetxt_ticket";
            this.totalpricetxt_ticket.Size = new System.Drawing.Size(192, 20);
            this.totalpricetxt_ticket.TabIndex = 24;
            // 
            // quantitytxt_ticket
            // 
            this.quantitytxt_ticket.Location = new System.Drawing.Point(234, 152);
            this.quantitytxt_ticket.Name = "quantitytxt_ticket";
            this.quantitytxt_ticket.Size = new System.Drawing.Size(192, 20);
            this.quantitytxt_ticket.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(231, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(231, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 21;
            // 
            // datepicker_tic
            // 
            this.datepicker_tic.Location = new System.Drawing.Point(234, 71);
            this.datepicker_tic.Name = "datepicker_tic";
            this.datepicker_tic.Size = new System.Drawing.Size(200, 20);
            this.datepicker_tic.TabIndex = 20;
            this.datepicker_tic.ValueChanged += new System.EventHandler(this.datepicker_ValueChanged);
            // 
            // proceedbtn_ticket
            // 
            this.proceedbtn_ticket.Location = new System.Drawing.Point(403, 267);
            this.proceedbtn_ticket.Name = "proceedbtn_ticket";
            this.proceedbtn_ticket.Size = new System.Drawing.Size(75, 23);
            this.proceedbtn_ticket.TabIndex = 19;
            this.proceedbtn_ticket.Text = "Proceed";
            this.proceedbtn_ticket.UseVisualStyleBackColor = true;
            this.proceedbtn_ticket.Click += new System.EventHandler(this.proceedbtn_ticket_Click);
            // 
            // discardbtn_ticket
            // 
            this.discardbtn_ticket.Location = new System.Drawing.Point(484, 267);
            this.discardbtn_ticket.Name = "discardbtn_ticket";
            this.discardbtn_ticket.Size = new System.Drawing.Size(75, 23);
            this.discardbtn_ticket.TabIndex = 18;
            this.discardbtn_ticket.Text = "Discard";
            this.discardbtn_ticket.UseVisualStyleBackColor = true;
            this.discardbtn_ticket.Click += new System.EventHandler(this.discardbtn_ticket_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(113, 178);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(109, 13);
            this.label14.TabIndex = 16;
            this.label14.Text = "Total Price               : ";
            this.label14.UseMnemonic = false;
            // 
            // numchildrentxt_ticket
            // 
            this.numchildrentxt_ticket.Location = new System.Drawing.Point(234, 123);
            this.numchildrentxt_ticket.Name = "numchildrentxt_ticket";
            this.numchildrentxt_ticket.Size = new System.Drawing.Size(192, 20);
            this.numchildrentxt_ticket.TabIndex = 15;
            this.numchildrentxt_ticket.TextChanged += new System.EventHandler(this.numchildrentxt_ticket_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(114, 126);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(109, 13);
            this.label10.TabIndex = 14;
            this.label10.Text = "Number of Children  : ";
            // 
            // numadulttxt_ticket
            // 
            this.numadulttxt_ticket.Location = new System.Drawing.Point(234, 97);
            this.numadulttxt_ticket.Name = "numadulttxt_ticket";
            this.numadulttxt_ticket.Size = new System.Drawing.Size(192, 20);
            this.numadulttxt_ticket.TabIndex = 13;
            this.numadulttxt_ticket.TextChanged += new System.EventHandler(this.numadulttxt_ticket_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(113, 100);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(110, 13);
            this.label11.TabIndex = 12;
            this.label11.Text = "Number of Adult       : ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(115, 152);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(109, 13);
            this.label12.TabIndex = 10;
            this.label12.Text = "Quantity                   : ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(115, 74);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(109, 13);
            this.label13.TabIndex = 8;
            this.label13.Text = "Visit Date                 : ";
            // 
            // souvenirtab
            // 
            this.souvenirtab.Controls.Add(this.browse_souv_panel);
            this.souvenirtab.Controls.Add(this.discardbtn_souvenir);
            this.souvenirtab.Controls.Add(this.addcartbtn_souvenir);
            this.souvenirtab.Controls.Add(this.viewshoppingbtn_souvenir);
            this.souvenirtab.Controls.Add(this.browsebtn_souvenir);
            this.souvenirtab.Controls.Add(this.totalpricetxt_souvenir);
            this.souvenirtab.Controls.Add(this.label15);
            this.souvenirtab.Controls.Add(this.quantitytxt_souvenir);
            this.souvenirtab.Controls.Add(this.label16);
            this.souvenirtab.Controls.Add(this.nametxt_souvenir);
            this.souvenirtab.Controls.Add(this.label17);
            this.souvenirtab.Location = new System.Drawing.Point(4, 22);
            this.souvenirtab.Name = "souvenirtab";
            this.souvenirtab.Padding = new System.Windows.Forms.Padding(3);
            this.souvenirtab.Size = new System.Drawing.Size(572, 298);
            this.souvenirtab.TabIndex = 1;
            this.souvenirtab.Text = "Souvenir";
            this.souvenirtab.UseVisualStyleBackColor = true;
            // 
            // browse_souv_panel
            // 
            this.browse_souv_panel.Controls.Add(this.close_souv_btn);
            this.browse_souv_panel.Controls.Add(this.button2);
            this.browse_souv_panel.Controls.Add(this.selectsouv_btn);
            this.browse_souv_panel.Controls.Add(this.souv_listbox);
            this.browse_souv_panel.Location = new System.Drawing.Point(39, 16);
            this.browse_souv_panel.Name = "browse_souv_panel";
            this.browse_souv_panel.Size = new System.Drawing.Size(494, 223);
            this.browse_souv_panel.TabIndex = 21;
            this.browse_souv_panel.Visible = false;
            // 
            // close_souv_btn
            // 
            this.close_souv_btn.Location = new System.Drawing.Point(410, 192);
            this.close_souv_btn.Name = "close_souv_btn";
            this.close_souv_btn.Size = new System.Drawing.Size(75, 23);
            this.close_souv_btn.TabIndex = 3;
            this.close_souv_btn.Text = "Close";
            this.close_souv_btn.UseVisualStyleBackColor = true;
            this.close_souv_btn.Click += new System.EventHandler(this.close_souv_btn_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(329, 192);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "View Detail";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // selectsouv_btn
            // 
            this.selectsouv_btn.Location = new System.Drawing.Point(248, 192);
            this.selectsouv_btn.Name = "selectsouv_btn";
            this.selectsouv_btn.Size = new System.Drawing.Size(75, 23);
            this.selectsouv_btn.TabIndex = 1;
            this.selectsouv_btn.Text = "Select";
            this.selectsouv_btn.UseVisualStyleBackColor = true;
            this.selectsouv_btn.Click += new System.EventHandler(this.selectsouv_btn_Click);
            // 
            // souv_listbox
            // 
            this.souv_listbox.FormattingEnabled = true;
            this.souv_listbox.Location = new System.Drawing.Point(10, 13);
            this.souv_listbox.Name = "souv_listbox";
            this.souv_listbox.Size = new System.Drawing.Size(475, 173);
            this.souv_listbox.TabIndex = 0;
            // 
            // discardbtn_souvenir
            // 
            this.discardbtn_souvenir.Location = new System.Drawing.Point(484, 267);
            this.discardbtn_souvenir.Name = "discardbtn_souvenir";
            this.discardbtn_souvenir.Size = new System.Drawing.Size(75, 23);
            this.discardbtn_souvenir.TabIndex = 20;
            this.discardbtn_souvenir.Text = "Discard";
            this.discardbtn_souvenir.UseVisualStyleBackColor = true;
            // 
            // addcartbtn_souvenir
            // 
            this.addcartbtn_souvenir.Location = new System.Drawing.Point(393, 267);
            this.addcartbtn_souvenir.Name = "addcartbtn_souvenir";
            this.addcartbtn_souvenir.Size = new System.Drawing.Size(85, 23);
            this.addcartbtn_souvenir.TabIndex = 19;
            this.addcartbtn_souvenir.Text = "Add to Cart";
            this.addcartbtn_souvenir.UseVisualStyleBackColor = true;
            this.addcartbtn_souvenir.Click += new System.EventHandler(this.addcartbtn_souvenir_Click);
            // 
            // viewshoppingbtn_souvenir
            // 
            this.viewshoppingbtn_souvenir.Location = new System.Drawing.Point(258, 267);
            this.viewshoppingbtn_souvenir.Name = "viewshoppingbtn_souvenir";
            this.viewshoppingbtn_souvenir.Size = new System.Drawing.Size(129, 23);
            this.viewshoppingbtn_souvenir.TabIndex = 18;
            this.viewshoppingbtn_souvenir.Text = "View Shopping Cart";
            this.viewshoppingbtn_souvenir.UseVisualStyleBackColor = true;
            this.viewshoppingbtn_souvenir.Click += new System.EventHandler(this.viewshoppingbtn_souvenir_Click);
            // 
            // browsebtn_souvenir
            // 
            this.browsebtn_souvenir.Location = new System.Drawing.Point(393, 77);
            this.browsebtn_souvenir.Name = "browsebtn_souvenir";
            this.browsebtn_souvenir.Size = new System.Drawing.Size(75, 23);
            this.browsebtn_souvenir.TabIndex = 17;
            this.browsebtn_souvenir.Text = "Browse";
            this.browsebtn_souvenir.UseVisualStyleBackColor = true;
            this.browsebtn_souvenir.Click += new System.EventHandler(this.browsebtn_souvenir_Click);
            // 
            // totalpricetxt_souvenir
            // 
            this.totalpricetxt_souvenir.Location = new System.Drawing.Point(193, 131);
            this.totalpricetxt_souvenir.Name = "totalpricetxt_souvenir";
            this.totalpricetxt_souvenir.ReadOnly = true;
            this.totalpricetxt_souvenir.Size = new System.Drawing.Size(192, 20);
            this.totalpricetxt_souvenir.TabIndex = 16;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(118, 134);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(67, 13);
            this.label15.TabIndex = 15;
            this.label15.Text = "Total Price : ";
            // 
            // quantitytxt_souvenir
            // 
            this.quantitytxt_souvenir.Location = new System.Drawing.Point(193, 105);
            this.quantitytxt_souvenir.Name = "quantitytxt_souvenir";
            this.quantitytxt_souvenir.Size = new System.Drawing.Size(192, 20);
            this.quantitytxt_souvenir.TabIndex = 14;
            this.quantitytxt_souvenir.TextChanged += new System.EventHandler(this.quantitytxt_souvenir_TextChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(121, 108);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(64, 13);
            this.label16.TabIndex = 13;
            this.label16.Text = "Quantity    : ";
            // 
            // nametxt_souvenir
            // 
            this.nametxt_souvenir.Location = new System.Drawing.Point(193, 79);
            this.nametxt_souvenir.Name = "nametxt_souvenir";
            this.nametxt_souvenir.ReadOnly = true;
            this.nametxt_souvenir.Size = new System.Drawing.Size(192, 20);
            this.nametxt_souvenir.TabIndex = 12;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(120, 82);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(65, 13);
            this.label17.TabIndex = 11;
            this.label17.Text = "Name        : ";
            // 
            // log_out
            // 
            this.log_out.AutoSize = true;
            this.log_out.Location = new System.Drawing.Point(529, 27);
            this.log_out.Name = "log_out";
            this.log_out.Size = new System.Drawing.Size(43, 13);
            this.log_out.TabIndex = 3;
            this.log_out.TabStop = true;
            this.log_out.Text = "Log out";
            this.log_out.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.log_out_LinkClicked);
            // 
            // Member
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.log_out);
            this.Controls.Add(this.membertabcontrol);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Member";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Member";
            this.Load += new System.EventHandler(this.Member_Load);
            this.membertabcontrol.ResumeLayout(false);
            this.donatetab.ResumeLayout(false);
            this.donatetab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.donate_pic)).EndInit();
            this.loantab.ResumeLayout(false);
            this.loantab.PerformLayout();
            this.browse_panel.ResumeLayout(false);
            this.ordertab.ResumeLayout(false);
            this.ordertabcontrol.ResumeLayout(false);
            this.tickettab.ResumeLayout(false);
            this.tickettab.PerformLayout();
            this.souvenirtab.ResumeLayout(false);
            this.souvenirtab.PerformLayout();
            this.browse_souv_panel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl membertabcontrol;
        private System.Windows.Forms.TabPage donatetab;
        private System.Windows.Forms.Button submitbtn;
        private System.Windows.Forms.Button discardbtn;
        private System.Windows.Forms.Button browsebtn_donate;
        private System.Windows.Forms.Label donate_detail;
        private System.Windows.Forms.TextBox detailtxt_donate;
        private System.Windows.Forms.Label donate_name;
        private System.Windows.Forms.TextBox nametxt_donate;
        private System.Windows.Forms.PictureBox donate_pic;
        private System.Windows.Forms.TabPage loantab;
        private System.Windows.Forms.TabPage ordertab;
        private System.Windows.Forms.TextBox purposetxt_loan;
        private System.Windows.Forms.Label loan_purpose;
        private System.Windows.Forms.Label loan_period;
        private System.Windows.Forms.Label loan_charge;
        private System.Windows.Forms.Label coll_name;
        private System.Windows.Forms.Label donate_price;
        private System.Windows.Forms.TextBox pricetxt_donate;
        private System.Windows.Forms.Button browsebtn_loan;
        private System.Windows.Forms.Button submitbtn_loan;
        private System.Windows.Forms.Button discardbtn_loan;
        private System.Windows.Forms.TabControl ordertabcontrol;
        private System.Windows.Forms.TabPage tickettab;
        private System.Windows.Forms.TabPage souvenirtab;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox numchildrentxt_ticket;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button proceedbtn_ticket;
        private System.Windows.Forms.Button discardbtn_ticket;
        private System.Windows.Forms.Button discardbtn_souvenir;
        private System.Windows.Forms.Button addcartbtn_souvenir;
        private System.Windows.Forms.Button viewshoppingbtn_souvenir;
        private System.Windows.Forms.Button browsebtn_souvenir;
        private System.Windows.Forms.TextBox totalpricetxt_souvenir;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox quantitytxt_souvenir;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox nametxt_souvenir;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.DateTimePicker datepicker_tic;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.DateTimePicker enddatepicker;
        private System.Windows.Forms.DateTimePicker startdatepicker;
        private System.Windows.Forms.LinkLabel log_out;
        private System.Windows.Forms.Button close_collbtn;
        private System.Windows.Forms.Button select_collbtn;
        private System.Windows.Forms.Button view_collbtn;
        private System.Windows.Forms.ListBox coll_listbox;
        private System.Windows.Forms.Panel browse_panel;
        private System.Windows.Forms.Label charge;
        private System.Windows.Forms.TextBox numadulttxt_ticket;
        private System.Windows.Forms.Label collname_txt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox totalpricetxt_ticket;
        private System.Windows.Forms.TextBox quantitytxt_ticket;
        private System.Windows.Forms.Panel browse_souv_panel;
        private System.Windows.Forms.Button close_souv_btn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button selectsouv_btn;
        private System.Windows.Forms.ListBox souv_listbox;
    }
}