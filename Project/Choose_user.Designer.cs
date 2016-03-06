namespace Project_Khuram
{
    partial class Choose_user
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Choose_user));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_Builling = new System.Windows.Forms.Button();
            this.btn_crm = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.btn_Builling, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_crm, 1, 0);
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Segoe WP Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(107, 75);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(307, 163);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btn_Builling
            // 
            this.btn_Builling.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Builling.Location = new System.Drawing.Point(3, 3);
            this.btn_Builling.Name = "btn_Builling";
            this.btn_Builling.Size = new System.Drawing.Size(147, 157);
            this.btn_Builling.TabIndex = 0;
            this.btn_Builling.Text = "Builling Module";
            this.btn_Builling.UseVisualStyleBackColor = true;
            this.btn_Builling.Click += new System.EventHandler(this.btn_Builling_Click);
            // 
            // btn_crm
            // 
            this.btn_crm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_crm.Location = new System.Drawing.Point(156, 3);
            this.btn_crm.Name = "btn_crm";
            this.btn_crm.Size = new System.Drawing.Size(148, 157);
            this.btn_crm.TabIndex = 1;
            this.btn_crm.Text = "CRM";
            this.btn_crm.UseVisualStyleBackColor = true;
            this.btn_crm.Click += new System.EventHandler(this.btn_crm_Click);
            // 
            // Choose_user
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(172)))), ((int)(((byte)(213)))));
            this.ClientSize = new System.Drawing.Size(507, 314);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Choose_user";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btn_Builling;
        private System.Windows.Forms.Button btn_crm;

    }
}