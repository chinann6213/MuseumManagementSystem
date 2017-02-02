namespace museumv4
{
    partial class ShoppingCart
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
            this.proceed_btn = new System.Windows.Forms.Button();
            this.discard_btn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.totalprice_lbl = new System.Windows.Forms.Label();
            this.cart_list = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // proceed_btn
            // 
            this.proceed_btn.Location = new System.Drawing.Point(305, 278);
            this.proceed_btn.Name = "proceed_btn";
            this.proceed_btn.Size = new System.Drawing.Size(75, 23);
            this.proceed_btn.TabIndex = 0;
            this.proceed_btn.Text = "Proceed";
            this.proceed_btn.UseVisualStyleBackColor = true;
            this.proceed_btn.Click += new System.EventHandler(this.proceed_btn_Click);
            // 
            // discard_btn
            // 
            this.discard_btn.Location = new System.Drawing.Point(386, 278);
            this.discard_btn.Name = "discard_btn";
            this.discard_btn.Size = new System.Drawing.Size(75, 23);
            this.discard_btn.TabIndex = 1;
            this.discard_btn.Text = "Discard";
            this.discard_btn.UseVisualStyleBackColor = true;
            this.discard_btn.Click += new System.EventHandler(this.discard_btn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(315, 247);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Final Price:  ";
            // 
            // totalprice_lbl
            // 
            this.totalprice_lbl.AutoSize = true;
            this.totalprice_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalprice_lbl.Location = new System.Drawing.Point(382, 242);
            this.totalprice_lbl.Name = "totalprice_lbl";
            this.totalprice_lbl.Size = new System.Drawing.Size(44, 20);
            this.totalprice_lbl.TabIndex = 8;
            this.totalprice_lbl.Text = "Price";
            // 
            // cart_list
            // 
            this.cart_list.Location = new System.Drawing.Point(9, 12);
            this.cart_list.Name = "cart_list";
            this.cart_list.Size = new System.Drawing.Size(451, 218);
            this.cart_list.TabIndex = 9;
            this.cart_list.UseCompatibleStateImageBehavior = false;
            // 
            // Shopping_cart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 307);
            this.Controls.Add(this.cart_list);
            this.Controls.Add(this.totalprice_lbl);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.discard_btn);
            this.Controls.Add(this.proceed_btn);
            this.Name = "Shopping_cart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Shopping cart";
            this.Load += new System.EventHandler(this.Shopping_cart_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button proceed_btn;
        private System.Windows.Forms.Button discard_btn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label totalprice_lbl;
        private System.Windows.Forms.ListView cart_list;
    }
}