namespace Project_Khuram
{
    partial class SignUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUp));
            this.lbl_newuser = new System.Windows.Forms.Label();
            this.lbl_newpass = new System.Windows.Forms.Label();
            this.txt_usernew = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_confpass = new System.Windows.Forms.TextBox();
            this.radio_user = new System.Windows.Forms.RadioButton();
            this.radio_admin = new System.Windows.Forms.RadioButton();
            this.btn_create = new System.Windows.Forms.Button();
            this.txt_user_pass = new System.Windows.Forms.TextBox();
            this.btn_gohome = new System.Windows.Forms.Button();
            this.accountinfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_newuser
            // 
            this.lbl_newuser.AutoSize = true;
            this.lbl_newuser.Font = new System.Drawing.Font("Segoe WP Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_newuser.Location = new System.Drawing.Point(123, 79);
            this.lbl_newuser.Name = "lbl_newuser";
            this.lbl_newuser.Size = new System.Drawing.Size(85, 20);
            this.lbl_newuser.TabIndex = 0;
            this.lbl_newuser.Text = "User Name";
            // 
            // lbl_newpass
            // 
            this.lbl_newpass.AutoSize = true;
            this.lbl_newpass.Font = new System.Drawing.Font("Segoe WP Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_newpass.Location = new System.Drawing.Point(123, 121);
            this.lbl_newpass.Name = "lbl_newpass";
            this.lbl_newpass.Size = new System.Drawing.Size(73, 20);
            this.lbl_newpass.TabIndex = 1;
            this.lbl_newpass.Text = "Password";
            // 
            // txt_usernew
            // 
            this.txt_usernew.Font = new System.Drawing.Font("Segoe WP Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_usernew.Location = new System.Drawing.Point(270, 76);
            this.txt_usernew.Name = "txt_usernew";
            this.txt_usernew.Size = new System.Drawing.Size(169, 27);
            this.txt_usernew.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe WP Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(123, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Confirm Password";
            // 
            // txt_confpass
            // 
            this.txt_confpass.Font = new System.Drawing.Font("Segoe WP Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_confpass.Location = new System.Drawing.Point(268, 158);
            this.txt_confpass.Name = "txt_confpass";
            this.txt_confpass.Size = new System.Drawing.Size(171, 27);
            this.txt_confpass.TabIndex = 6;
            // 
            // radio_user
            // 
            this.radio_user.AutoSize = true;
            this.radio_user.Font = new System.Drawing.Font("Segoe WP Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio_user.Location = new System.Drawing.Point(157, 207);
            this.radio_user.Name = "radio_user";
            this.radio_user.Size = new System.Drawing.Size(118, 24);
            this.radio_user.TabIndex = 7;
            this.radio_user.TabStop = true;
            this.radio_user.Text = "User Account";
            this.radio_user.UseVisualStyleBackColor = true;
            this.radio_user.CheckedChanged += new System.EventHandler(this.radio_value_CheckedChanged);
            // 
            // radio_admin
            // 
            this.radio_admin.AutoSize = true;
            this.radio_admin.Font = new System.Drawing.Font("Segoe WP Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio_admin.Location = new System.Drawing.Point(293, 207);
            this.radio_admin.Name = "radio_admin";
            this.radio_admin.Size = new System.Drawing.Size(132, 24);
            this.radio_admin.TabIndex = 8;
            this.radio_admin.TabStop = true;
            this.radio_admin.Text = "Admin Account";
            this.radio_admin.UseVisualStyleBackColor = true;
            this.radio_admin.CheckedChanged += new System.EventHandler(this.radio_value1_CheckedChanged);
            // 
            // btn_create
            // 
            this.btn_create.Font = new System.Drawing.Font("Segoe WP Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_create.Location = new System.Drawing.Point(219, 289);
            this.btn_create.Name = "btn_create";
            this.btn_create.Size = new System.Drawing.Size(125, 31);
            this.btn_create.TabIndex = 9;
            this.btn_create.Text = "Create User";
            this.btn_create.UseVisualStyleBackColor = true;
            this.btn_create.Click += new System.EventHandler(this.btn_create_Click);
            // 
            // txt_user_pass
            // 
            this.txt_user_pass.Font = new System.Drawing.Font("Segoe WP Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_user_pass.Location = new System.Drawing.Point(270, 118);
            this.txt_user_pass.Name = "txt_user_pass";
            this.txt_user_pass.Size = new System.Drawing.Size(169, 27);
            this.txt_user_pass.TabIndex = 5;
            // 
            // btn_gohome
            // 
            this.btn_gohome.Font = new System.Drawing.Font("Segoe WP Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_gohome.Location = new System.Drawing.Point(219, 26);
            this.btn_gohome.Name = "btn_gohome";
            this.btn_gohome.Size = new System.Drawing.Size(142, 31);
            this.btn_gohome.TabIndex = 10;
            this.btn_gohome.Text = "Home";
            this.btn_gohome.UseVisualStyleBackColor = true;
            this.btn_gohome.Click += new System.EventHandler(this.btn_gohome_Click);
            // 
            // accountinfo
            // 
            this.accountinfo.AutoSize = true;
            this.accountinfo.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountinfo.ForeColor = System.Drawing.Color.Red;
            this.accountinfo.Location = new System.Drawing.Point(196, 250);
            this.accountinfo.Name = "accountinfo";
            this.accountinfo.Size = new System.Drawing.Size(0, 21);
            this.accountinfo.TabIndex = 11;
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(172)))), ((int)(((byte)(213)))));
            this.ClientSize = new System.Drawing.Size(548, 346);
            this.Controls.Add(this.accountinfo);
            this.Controls.Add(this.btn_gohome);
            this.Controls.Add(this.txt_user_pass);
            this.Controls.Add(this.btn_create);
            this.Controls.Add(this.radio_admin);
            this.Controls.Add(this.radio_user);
            this.Controls.Add(this.txt_confpass);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_usernew);
            this.Controls.Add(this.lbl_newpass);
            this.Controls.Add(this.lbl_newuser);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SignUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create Account";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_newuser;
        private System.Windows.Forms.Label lbl_newpass;
        private System.Windows.Forms.TextBox txt_usernew;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_confpass;
        private System.Windows.Forms.RadioButton radio_user;
        private System.Windows.Forms.RadioButton radio_admin;
        private System.Windows.Forms.Button btn_create;
        private System.Windows.Forms.TextBox txt_user_pass;
        private System.Windows.Forms.Button btn_gohome;
        private System.Windows.Forms.Label accountinfo;
    }
}