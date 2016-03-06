namespace Project_Khuram
{
    partial class Choose
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Choose));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_builling = new System.Windows.Forms.Button();
            this.btn_useradd = new System.Windows.Forms.Button();
            this.btn_crm = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.btn_builling, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_useradd, 1, 0);
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Segoe WP", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(122, 58);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(270, 114);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btn_builling
            // 
            this.btn_builling.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_builling.Location = new System.Drawing.Point(3, 3);
            this.btn_builling.Name = "btn_builling";
            this.btn_builling.Size = new System.Drawing.Size(129, 108);
            this.btn_builling.TabIndex = 0;
            this.btn_builling.Text = "Builling";
            this.btn_builling.UseVisualStyleBackColor = true;
            this.btn_builling.Click += new System.EventHandler(this.btn_builling_Click);
            // 
            // btn_useradd
            // 
            this.btn_useradd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_useradd.Location = new System.Drawing.Point(138, 3);
            this.btn_useradd.Name = "btn_useradd";
            this.btn_useradd.Size = new System.Drawing.Size(129, 108);
            this.btn_useradd.TabIndex = 1;
            this.btn_useradd.Text = "Add User";
            this.btn_useradd.UseVisualStyleBackColor = true;
            this.btn_useradd.Click += new System.EventHandler(this.btn_useradd_Click);
            // 
            // btn_crm
            // 
            this.btn_crm.Font = new System.Drawing.Font("Segoe WP", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_crm.Location = new System.Drawing.Point(122, 178);
            this.btn_crm.Name = "btn_crm";
            this.btn_crm.Size = new System.Drawing.Size(272, 82);
            this.btn_crm.TabIndex = 1;
            this.btn_crm.Text = "CRM";
            this.btn_crm.UseVisualStyleBackColor = true;
            this.btn_crm.Click += new System.EventHandler(this.btn_crm_Click);
            // 
            // Choose
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(172)))), ((int)(((byte)(213)))));
            this.ClientSize = new System.Drawing.Size(521, 330);
            this.Controls.Add(this.btn_crm);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Choose";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Choose_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btn_builling;
        private System.Windows.Forms.Button btn_useradd;
        private System.Windows.Forms.Button btn_crm;
    }
}