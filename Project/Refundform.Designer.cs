namespace Project_Khuram
{
    partial class Refundform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Refundform));
            this.lbl_refund = new System.Windows.Forms.Label();
            this.txt_refundedto = new System.Windows.Forms.TextBox();
            this.lbl_total = new System.Windows.Forms.Label();
            this.lbl_payment = new System.Windows.Forms.Label();
            this.txt_payment = new System.Windows.Forms.TextBox();
            this.lbl_Mode = new System.Windows.Forms.Label();
            this.txt_combovalues = new System.Windows.Forms.ComboBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.lbl_valuemessage = new System.Windows.Forms.Label();
            this.txt_reciptnumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lbl_newinvoicerefundnumber = new System.Windows.Forms.Label();
            this.txt_toataldollar = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_refund
            // 
            this.lbl_refund.AutoSize = true;
            this.lbl_refund.Font = new System.Drawing.Font("Segoe WP", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_refund.Location = new System.Drawing.Point(72, 226);
            this.lbl_refund.Name = "lbl_refund";
            this.lbl_refund.Size = new System.Drawing.Size(106, 20);
            this.lbl_refund.TabIndex = 0;
            this.lbl_refund.Text = "Refunded To :";
            // 
            // txt_refundedto
            // 
            this.txt_refundedto.Font = new System.Drawing.Font("Segoe WP", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_refundedto.Location = new System.Drawing.Point(228, 223);
            this.txt_refundedto.Name = "txt_refundedto";
            this.txt_refundedto.Size = new System.Drawing.Size(197, 27);
            this.txt_refundedto.TabIndex = 1;
            // 
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.Font = new System.Drawing.Font("Segoe WP", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_total.Location = new System.Drawing.Point(72, 270);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(105, 20);
            this.lbl_total.TabIndex = 2;
            this.lbl_total.Text = "Total Dollars :";
            // 
            // lbl_payment
            // 
            this.lbl_payment.AutoSize = true;
            this.lbl_payment.Font = new System.Drawing.Font("Segoe WP", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_payment.Location = new System.Drawing.Point(72, 313);
            this.lbl_payment.Name = "lbl_payment";
            this.lbl_payment.Size = new System.Drawing.Size(150, 20);
            this.lbl_payment.TabIndex = 3;
            this.lbl_payment.Text = "Being Payment Off :";
            // 
            // txt_payment
            // 
            this.txt_payment.Font = new System.Drawing.Font("Segoe WP", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_payment.Location = new System.Drawing.Point(228, 306);
            this.txt_payment.Name = "txt_payment";
            this.txt_payment.Size = new System.Drawing.Size(197, 27);
            this.txt_payment.TabIndex = 4;
            // 
            // lbl_Mode
            // 
            this.lbl_Mode.AutoSize = true;
            this.lbl_Mode.Font = new System.Drawing.Font("Segoe WP", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Mode.Location = new System.Drawing.Point(72, 358);
            this.lbl_Mode.Name = "lbl_Mode";
            this.lbl_Mode.Size = new System.Drawing.Size(142, 20);
            this.lbl_Mode.TabIndex = 5;
            this.lbl_Mode.Text = "Mode of Payment :";
            // 
            // txt_combovalues
            // 
            this.txt_combovalues.Font = new System.Drawing.Font("Segoe WP", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_combovalues.FormattingEnabled = true;
            this.txt_combovalues.Location = new System.Drawing.Point(228, 350);
            this.txt_combovalues.Name = "txt_combovalues";
            this.txt_combovalues.Size = new System.Drawing.Size(197, 28);
            this.txt_combovalues.TabIndex = 6;
            // 
            // btn_save
            // 
            this.btn_save.Font = new System.Drawing.Font("Segoe WP", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.Location = new System.Drawing.Point(48, 414);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(79, 30);
            this.btn_save.TabIndex = 7;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // lbl_valuemessage
            // 
            this.lbl_valuemessage.AutoSize = true;
            this.lbl_valuemessage.Font = new System.Drawing.Font("Segoe WP", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_valuemessage.Location = new System.Drawing.Point(72, 117);
            this.lbl_valuemessage.Name = "lbl_valuemessage";
            this.lbl_valuemessage.Size = new System.Drawing.Size(315, 40);
            this.lbl_valuemessage.TabIndex = 8;
            this.lbl_valuemessage.Text = "Please input the Original invoice number to \r\nproceed with refund :";
            // 
            // txt_reciptnumber
            // 
            this.txt_reciptnumber.Font = new System.Drawing.Font("Segoe WP", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_reciptnumber.Location = new System.Drawing.Point(146, 169);
            this.txt_reciptnumber.MaxLength = 7;
            this.txt_reciptnumber.Name = "txt_reciptnumber";
            this.txt_reciptnumber.Size = new System.Drawing.Size(163, 27);
            this.txt_reciptnumber.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe WP", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(256, 414);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Receipt for Invoice Number :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe WP", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(96, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(269, 32);
            this.label3.TabIndex = 12;
            this.label3.Text = "Delta Emp Vault (DEV)";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe WP Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 57);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(454, 46);
            this.button1.TabIndex = 13;
            this.button1.Text = "Bill Generation (Refund) ";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_newinvoicerefundnumber
            // 
            this.lbl_newinvoicerefundnumber.AutoSize = true;
            this.lbl_newinvoicerefundnumber.Font = new System.Drawing.Font("Segoe WP", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_newinvoicerefundnumber.Location = new System.Drawing.Point(310, 440);
            this.lbl_newinvoicerefundnumber.Name = "lbl_newinvoicerefundnumber";
            this.lbl_newinvoicerefundnumber.Size = new System.Drawing.Size(0, 20);
            this.lbl_newinvoicerefundnumber.TabIndex = 14;
            // 
            // txt_toataldollar
            // 
            this.txt_toataldollar.Font = new System.Drawing.Font("Segoe WP", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_toataldollar.Location = new System.Drawing.Point(228, 267);
            this.txt_toataldollar.Name = "txt_toataldollar";
            this.txt_toataldollar.Size = new System.Drawing.Size(197, 27);
            this.txt_toataldollar.TabIndex = 15;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe WP Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(351, 168);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(74, 27);
            this.button2.TabIndex = 16;
            this.button2.Text = "Search";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(479, 158);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(534, 106);
            this.dataGridView1.TabIndex = 17;
            // 
            // Refundform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(172)))), ((int)(((byte)(213)))));
            this.ClientSize = new System.Drawing.Size(1025, 473);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txt_toataldollar);
            this.Controls.Add(this.lbl_newinvoicerefundnumber);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_reciptnumber);
            this.Controls.Add(this.lbl_valuemessage);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.txt_combovalues);
            this.Controls.Add(this.lbl_Mode);
            this.Controls.Add(this.txt_payment);
            this.Controls.Add(this.lbl_payment);
            this.Controls.Add(this.lbl_total);
            this.Controls.Add(this.txt_refundedto);
            this.Controls.Add(this.lbl_refund);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Refundform";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_refund;
        private System.Windows.Forms.TextBox txt_refundedto;
        private System.Windows.Forms.Label lbl_total;
        private System.Windows.Forms.Label lbl_payment;
        private System.Windows.Forms.TextBox txt_payment;
        private System.Windows.Forms.Label lbl_Mode;
        private System.Windows.Forms.ComboBox txt_combovalues;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Label lbl_valuemessage;
        private System.Windows.Forms.TextBox txt_reciptnumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbl_newinvoicerefundnumber;
        private System.Windows.Forms.TextBox txt_toataldollar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}