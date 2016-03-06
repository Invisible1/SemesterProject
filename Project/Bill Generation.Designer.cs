namespace Project_Khuram
{
    partial class Bill_Generation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bill_Generation));
            this.lbl_invoicenumber = new System.Windows.Forms.Label();
            this.btn_generatebill = new System.Windows.Forms.Button();
            this.print = new System.Windows.Forms.Button();
            this.lbl_recievedform = new System.Windows.Forms.Label();
            this.lbl_total = new System.Windows.Forms.Label();
            this.lbl_payment = new System.Windows.Forms.Label();
            this.lbl_paymentmode = new System.Windows.Forms.Label();
            this.txt_paymentcombo = new System.Windows.Forms.ComboBox();
            this.labl_totallable = new System.Windows.Forms.Label();
            this.txt_payment = new System.Windows.Forms.TextBox();
            this.txt_recievedfrom = new System.Windows.Forms.TextBox();
            this.reciptnoinvoice = new System.Windows.Forms.Label();
            this.Delta_lbl = new System.Windows.Forms.Label();
            this.txt_copied = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_invoicenumber
            // 
            this.lbl_invoicenumber.AutoSize = true;
            this.lbl_invoicenumber.Font = new System.Drawing.Font("Segoe WP Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_invoicenumber.Location = new System.Drawing.Point(288, 364);
            this.lbl_invoicenumber.Name = "lbl_invoicenumber";
            this.lbl_invoicenumber.Size = new System.Drawing.Size(205, 20);
            this.lbl_invoicenumber.TabIndex = 8;
            this.lbl_invoicenumber.Text = "Receipt for Invoice Number :";
            // 
            // btn_generatebill
            // 
            this.btn_generatebill.Font = new System.Drawing.Font("Segoe WP Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_generatebill.Location = new System.Drawing.Point(12, 50);
            this.btn_generatebill.Name = "btn_generatebill";
            this.btn_generatebill.Size = new System.Drawing.Size(462, 43);
            this.btn_generatebill.TabIndex = 9;
            this.btn_generatebill.Text = "Generate Bill";
            this.btn_generatebill.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_generatebill.UseVisualStyleBackColor = true;
            this.btn_generatebill.Click += new System.EventHandler(this.btn_generatebill_Click);
            // 
            // print
            // 
            this.print.Font = new System.Drawing.Font("Segoe WP Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.print.Location = new System.Drawing.Point(59, 382);
            this.print.Name = "print";
            this.print.Size = new System.Drawing.Size(88, 31);
            this.print.TabIndex = 10;
            this.print.Text = "Print Bill";
            this.print.UseVisualStyleBackColor = true;
            this.print.Click += new System.EventHandler(this.print_Click);
            // 
            // lbl_recievedform
            // 
            this.lbl_recievedform.AutoSize = true;
            this.lbl_recievedform.Font = new System.Drawing.Font("Segoe WP Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_recievedform.Location = new System.Drawing.Point(55, 124);
            this.lbl_recievedform.Name = "lbl_recievedform";
            this.lbl_recievedform.Size = new System.Drawing.Size(118, 20);
            this.lbl_recievedform.TabIndex = 0;
            this.lbl_recievedform.Text = "Recieved Form :";
            // 
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.Font = new System.Drawing.Font("Segoe WP Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_total.Location = new System.Drawing.Point(54, 167);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(146, 20);
            this.lbl_total.TabIndex = 1;
            this.lbl_total.Text = "The Sum of Dollars :";
            // 
            // lbl_payment
            // 
            this.lbl_payment.AutoSize = true;
            this.lbl_payment.Font = new System.Drawing.Font("Segoe WP Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_payment.Location = new System.Drawing.Point(55, 208);
            this.lbl_payment.Name = "lbl_payment";
            this.lbl_payment.Size = new System.Drawing.Size(143, 20);
            this.lbl_payment.TabIndex = 2;
            this.lbl_payment.Text = "Being Payment off :";
            // 
            // lbl_paymentmode
            // 
            this.lbl_paymentmode.AutoSize = true;
            this.lbl_paymentmode.Font = new System.Drawing.Font("Segoe WP Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_paymentmode.Location = new System.Drawing.Point(55, 247);
            this.lbl_paymentmode.Name = "lbl_paymentmode";
            this.lbl_paymentmode.Size = new System.Drawing.Size(139, 20);
            this.lbl_paymentmode.TabIndex = 3;
            this.lbl_paymentmode.Text = "Mode of Payment :";
            // 
            // txt_paymentcombo
            // 
            this.txt_paymentcombo.Font = new System.Drawing.Font("Segoe WP Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_paymentcombo.FormattingEnabled = true;
            this.txt_paymentcombo.Location = new System.Drawing.Point(213, 247);
            this.txt_paymentcombo.Name = "txt_paymentcombo";
            this.txt_paymentcombo.Size = new System.Drawing.Size(187, 28);
            this.txt_paymentcombo.TabIndex = 8;
            // 
            // labl_totallable
            // 
            this.labl_totallable.AutoSize = true;
            this.labl_totallable.Font = new System.Drawing.Font("Segoe WP Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labl_totallable.Location = new System.Drawing.Point(218, 167);
            this.labl_totallable.Name = "labl_totallable";
            this.labl_totallable.Size = new System.Drawing.Size(0, 20);
            this.labl_totallable.TabIndex = 5;
            // 
            // txt_payment
            // 
            this.txt_payment.Font = new System.Drawing.Font("Segoe WP Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_payment.Location = new System.Drawing.Point(213, 205);
            this.txt_payment.Name = "txt_payment";
            this.txt_payment.Size = new System.Drawing.Size(187, 27);
            this.txt_payment.TabIndex = 7;
            this.txt_payment.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_recievedfrom
            // 
            this.txt_recievedfrom.Font = new System.Drawing.Font("Segoe WP Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_recievedfrom.Location = new System.Drawing.Point(213, 124);
            this.txt_recievedfrom.Name = "txt_recievedfrom";
            this.txt_recievedfrom.Size = new System.Drawing.Size(187, 27);
            this.txt_recievedfrom.TabIndex = 6;
            // 
            // reciptnoinvoice
            // 
            this.reciptnoinvoice.AutoSize = true;
            this.reciptnoinvoice.Font = new System.Drawing.Font("Segoe WP Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reciptnoinvoice.Location = new System.Drawing.Point(345, 393);
            this.reciptnoinvoice.Name = "reciptnoinvoice";
            this.reciptnoinvoice.Size = new System.Drawing.Size(0, 20);
            this.reciptnoinvoice.TabIndex = 11;
            // 
            // Delta_lbl
            // 
            this.Delta_lbl.AutoSize = true;
            this.Delta_lbl.Font = new System.Drawing.Font("Segoe WP", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delta_lbl.Location = new System.Drawing.Point(109, 9);
            this.Delta_lbl.Name = "Delta_lbl";
            this.Delta_lbl.Size = new System.Drawing.Size(269, 32);
            this.Delta_lbl.TabIndex = 12;
            this.Delta_lbl.Text = "Delta Emp Vault (DEV)";
            // 
            // txt_copied
            // 
            this.txt_copied.AutoSize = true;
            this.txt_copied.Font = new System.Drawing.Font("Miramonte", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_copied.Location = new System.Drawing.Point(403, 101);
            this.txt_copied.Name = "txt_copied";
            this.txt_copied.Size = new System.Drawing.Size(0, 16);
            this.txt_copied.TabIndex = 13;
            // 
            // Bill_Generation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(172)))), ((int)(((byte)(213)))));
            this.ClientSize = new System.Drawing.Size(505, 439);
            this.Controls.Add(this.txt_copied);
            this.Controls.Add(this.Delta_lbl);
            this.Controls.Add(this.reciptnoinvoice);
            this.Controls.Add(this.txt_recievedfrom);
            this.Controls.Add(this.print);
            this.Controls.Add(this.btn_generatebill);
            this.Controls.Add(this.lbl_invoicenumber);
            this.Controls.Add(this.txt_paymentcombo);
            this.Controls.Add(this.txt_payment);
            this.Controls.Add(this.labl_totallable);
            this.Controls.Add(this.lbl_paymentmode);
            this.Controls.Add(this.lbl_payment);
            this.Controls.Add(this.lbl_total);
            this.Controls.Add(this.lbl_recievedform);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Bill_Generation";
            this.Text = "Bill_Generation";
            this.Load += new System.EventHandler(this.Bill_Generation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_invoicenumber;
        private System.Windows.Forms.Button btn_generatebill;
        private System.Windows.Forms.Button print;
        private System.Windows.Forms.Label lbl_recievedform;
        private System.Windows.Forms.Label lbl_total;
        private System.Windows.Forms.Label lbl_payment;
        private System.Windows.Forms.Label lbl_paymentmode;
        private System.Windows.Forms.ComboBox txt_paymentcombo;
        private System.Windows.Forms.Label labl_totallable;
        private System.Windows.Forms.TextBox txt_payment;
        private System.Windows.Forms.TextBox txt_recievedfrom;
        private System.Windows.Forms.Label reciptnoinvoice;
        private System.Windows.Forms.Label Delta_lbl;
        public System.Windows.Forms.Label txt_copied;
    }
}