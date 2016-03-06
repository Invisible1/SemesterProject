using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Project_Khuram
{
    public partial class SignUp : Form
    {
        string account_type=null;
        public string accountlogin = null;
        public SignUp(string accountlogin)
        {
            InitializeComponent();
            this.accountlogin = accountlogin;
            txt_user_pass.PasswordChar = '*';
            txt_confpass.PasswordChar = '*';
        }

        private void btn_create_Click(object sender, EventArgs e)
        {
            try
            {
                if(txt_usernew.Text=="" || txt_user_pass.Text=="" || txt_confpass.Text=="")
                {
                    accountinfo.Text = "";
                    MessageBox.Show("Some Fields Missing ");
                }
                if (txt_user_pass.Text == txt_confpass.Text)
                {
                    Connectioncs conn = new Connectioncs();
                    string query = "insert into users (username,userpassword,accounttype) values('" + this.txt_usernew.Text + "','" + this.txt_user_pass.Text + "','" + this.account_type + "');";

                    SqlCommand selctcommand = new SqlCommand(query, Connectioncs.conn);
                    Connectioncs.conn.Open();
                    SqlDataReader myReader;
                    try
                    {
                        conn.Connectdatabase();
                        myReader = selctcommand.ExecuteReader();
                        while (myReader.Read())
                        {

                        }
                        accountinfo.Text = "Account Succesfully Created";
                        Connectioncs.conn.Close();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("User Name already Exist");
                    }
                }
                else
                {
                    MessageBox.Show("Password Miss Match");
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message");
                   
            }
        }

        private void radio_value_CheckedChanged(object sender, EventArgs e)
        {
            account_type = "user";
        }

        private void radio_value1_CheckedChanged(object sender, EventArgs e)
        {
            account_type = "admin";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_gohome_Click(object sender, EventArgs e)
        {
            this.Hide();
            Choose choose = new Choose(accountlogin);
            choose.Show();
        }
    }
}
