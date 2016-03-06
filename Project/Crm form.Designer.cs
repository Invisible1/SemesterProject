namespace Project_Khuram
{
    partial class Crm_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Crm_form));
            this.tab_data1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btn_go = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_searchinvoice = new System.Windows.Forms.Button();
            this.txt_invoicenumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.btn_search_refund = new System.Windows.Forms.Button();
            this.txt_refundno = new System.Windows.Forms.TextBox();
            this.lbl_refundid = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btn_go_customer = new System.Windows.Forms.Button();
            this.btn_searchbycustomer = new System.Windows.Forms.Button();
            this.txt_customername = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.btn_go_date = new System.Windows.Forms.Button();
            this.tab_data1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.SuspendLayout();
            // 
            // tab_data1
            // 
            this.tab_data1.Controls.Add(this.tabPage1);
            this.tab_data1.Controls.Add(this.tabPage2);
            this.tab_data1.Controls.Add(this.tabPage3);
            this.tab_data1.Controls.Add(this.tabPage4);
            this.tab_data1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tab_data1.Font = new System.Drawing.Font("Segoe WP Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tab_data1.Location = new System.Drawing.Point(0, 24);
            this.tab_data1.Name = "tab_data1";
            this.tab_data1.SelectedIndex = 0;
            this.tab_data1.Size = new System.Drawing.Size(1115, 608);
            this.tab_data1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btn_go);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.btn_searchinvoice);
            this.tabPage1.Controls.Add(this.txt_invoicenumber);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1107, 578);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Search by Invoice Number";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btn_go
            // 
            this.btn_go.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_go.Location = new System.Drawing.Point(3, 69);
            this.btn_go.Name = "btn_go";
            this.btn_go.Size = new System.Drawing.Size(1101, 30);
            this.btn_go.TabIndex = 4;
            this.btn_go.Text = "G0";
            this.btn_go.UseVisualStyleBackColor = true;
            this.btn_go.Click += new System.EventHandler(this.btn_go_Click_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(3, 99);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1101, 476);
            this.dataGridView1.TabIndex = 3;
            // 
            // btn_searchinvoice
            // 
            this.btn_searchinvoice.Location = new System.Drawing.Point(542, 27);
            this.btn_searchinvoice.Name = "btn_searchinvoice";
            this.btn_searchinvoice.Size = new System.Drawing.Size(93, 33);
            this.btn_searchinvoice.TabIndex = 2;
            this.btn_searchinvoice.Text = "Search";
            this.btn_searchinvoice.UseVisualStyleBackColor = true;
            this.btn_searchinvoice.Click += new System.EventHandler(this.btn_searchinvoice_Click);
            // 
            // txt_invoicenumber
            // 
            this.txt_invoicenumber.Location = new System.Drawing.Point(251, 33);
            this.txt_invoicenumber.MaxLength = 7;
            this.txt_invoicenumber.Name = "txt_invoicenumber";
            this.txt_invoicenumber.Size = new System.Drawing.Size(249, 25);
            this.txt_invoicenumber.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter InVoice Number";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Controls.Add(this.btn_search_refund);
            this.tabPage2.Controls.Add(this.txt_refundno);
            this.tabPage2.Controls.Add(this.lbl_refundid);
            this.tabPage2.Location = new System.Drawing.Point(4, 26);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1107, 578);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Search by RefundId";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView2.Location = new System.Drawing.Point(3, 105);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(1101, 470);
            this.dataGridView2.TabIndex = 3;
            // 
            // btn_search_refund
            // 
            this.btn_search_refund.Location = new System.Drawing.Point(550, 42);
            this.btn_search_refund.Name = "btn_search_refund";
            this.btn_search_refund.Size = new System.Drawing.Size(82, 32);
            this.btn_search_refund.TabIndex = 2;
            this.btn_search_refund.Text = "Search";
            this.btn_search_refund.UseVisualStyleBackColor = true;
            this.btn_search_refund.Click += new System.EventHandler(this.btn_search_refund_Click);
            // 
            // txt_refundno
            // 
            this.txt_refundno.Location = new System.Drawing.Point(285, 47);
            this.txt_refundno.MaxLength = 7;
            this.txt_refundno.Name = "txt_refundno";
            this.txt_refundno.Size = new System.Drawing.Size(238, 25);
            this.txt_refundno.TabIndex = 1;
            // 
            // lbl_refundid
            // 
            this.lbl_refundid.AutoSize = true;
            this.lbl_refundid.Location = new System.Drawing.Point(112, 50);
            this.lbl_refundid.Name = "lbl_refundid";
            this.lbl_refundid.Size = new System.Drawing.Size(160, 17);
            this.lbl_refundid.TabIndex = 0;
            this.lbl_refundid.Text = "Enter RefundId to Search";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btn_go_customer);
            this.tabPage3.Controls.Add(this.btn_searchbycustomer);
            this.tabPage3.Controls.Add(this.txt_customername);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.dataGridView3);
            this.tabPage3.Location = new System.Drawing.Point(4, 26);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1107, 578);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Search by Customer Name";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btn_go_customer
            // 
            this.btn_go_customer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_go_customer.Location = new System.Drawing.Point(3, 86);
            this.btn_go_customer.Name = "btn_go_customer";
            this.btn_go_customer.Size = new System.Drawing.Size(1101, 32);
            this.btn_go_customer.TabIndex = 4;
            this.btn_go_customer.Text = "GO";
            this.btn_go_customer.UseVisualStyleBackColor = true;
            this.btn_go_customer.Click += new System.EventHandler(this.btn_go_customer_Click);
            // 
            // btn_searchbycustomer
            // 
            this.btn_searchbycustomer.Location = new System.Drawing.Point(614, 41);
            this.btn_searchbycustomer.Name = "btn_searchbycustomer";
            this.btn_searchbycustomer.Size = new System.Drawing.Size(82, 33);
            this.btn_searchbycustomer.TabIndex = 3;
            this.btn_searchbycustomer.Text = "Search";
            this.btn_searchbycustomer.UseVisualStyleBackColor = true;
            this.btn_searchbycustomer.Click += new System.EventHandler(this.btn_searchbycustomer_Click);
            // 
            // txt_customername
            // 
            this.txt_customername.Location = new System.Drawing.Point(333, 45);
            this.txt_customername.Name = "txt_customername";
            this.txt_customername.Size = new System.Drawing.Size(250, 25);
            this.txt_customername.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(102, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(204, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter Customer Name to Search";
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView3.Location = new System.Drawing.Point(3, 118);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(1101, 457);
            this.dataGridView3.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.btn_go_date);
            this.tabPage4.Controls.Add(this.dataGridView4);
            this.tabPage4.Controls.Add(this.dateTimePicker2);
            this.tabPage4.Controls.Add(this.dateTimePicker1);
            this.tabPage4.Controls.Add(this.label5);
            this.tabPage4.Controls.Add(this.label4);
            this.tabPage4.Controls.Add(this.label3);
            this.tabPage4.Location = new System.Drawing.Point(4, 26);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1107, 578);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Search by Date";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(254, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Enter Date :";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1115, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.homeToolStripMenuItem.Text = "Home";
            this.homeToolStripMenuItem.Click += new System.EventHandler(this.homeToolStripMenuItem_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe WP", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(637, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "to";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe WP", 11.25F, System.Drawing.FontStyle.Italic);
            this.label5.Location = new System.Drawing.Point(354, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "From";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(420, 45);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(193, 25);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(666, 45);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(205, 25);
            this.dateTimePicker2.TabIndex = 6;
            // 
            // dataGridView4
            // 
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView4.Location = new System.Drawing.Point(3, 133);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.Size = new System.Drawing.Size(1101, 442);
            this.dataGridView4.TabIndex = 7;
            // 
            // btn_go_date
            // 
            this.btn_go_date.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_go_date.Location = new System.Drawing.Point(3, 100);
            this.btn_go_date.Name = "btn_go_date";
            this.btn_go_date.Size = new System.Drawing.Size(1101, 33);
            this.btn_go_date.TabIndex = 8;
            this.btn_go_date.Text = "Search";
            this.btn_go_date.UseVisualStyleBackColor = true;
            this.btn_go_date.Click += new System.EventHandler(this.btn_go_date_Click);
            // 
            // Crm_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(172)))), ((int)(((byte)(213)))));
            this.ClientSize = new System.Drawing.Size(1115, 632);
            this.Controls.Add(this.tab_data1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Crm_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Crm_form_Load);
            this.tab_data1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tab_data1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txt_invoicenumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_searchinvoice;
        private System.Windows.Forms.Button btn_go;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btn_search_refund;
        private System.Windows.Forms.TextBox txt_refundno;
        private System.Windows.Forms.Label lbl_refundid;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btn_searchbycustomer;
        private System.Windows.Forms.TextBox txt_customername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Button btn_go_customer;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btn_go_date;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;

    }
}