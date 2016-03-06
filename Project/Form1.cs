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
using System.Threading;
namespace Project_Khuram
{
    public partial class Sign_in : Form
    {
        
        public Sign_in()
        {
            Thread t = new Thread(new ThreadStart(SplashScreen));
            t.Start();
            Thread.Sleep(5000);
            InitializeComponent();
            txt_passw.PasswordChar = '*';

            t.Abort();
        }

        private void signin_Click(object sender, EventArgs e)
        {  try{
                Connectioncs conn = new Connectioncs();
                conn.Connectdatabase();
                SqlCommand selctcommand = new SqlCommand("select username,userpassword,accounttype from users where username='" + this.txt_user.Text + "' and userpassword='" + this.txt_passw.Text + "';", Connectioncs.conn);
               
                SqlDataReader myreader;
                myreader = selctcommand.ExecuteReader();
                int count = 0;
                string accounttype = null;
                while(myreader.Read())
                {
                    accounttype = (string)myreader["accounttype"];
                    count += 1;
                }
                if(count==1)
                {
                    if (accounttype == "user")
                    {
                        this.Hide();
                        Choose_user form = new Choose_user(accounttype);
                        Connectioncs.conn.Close();        
                        form.Show();
                    }
                   if (accounttype == "admin")
                   {
                        this.Hide();
                        Choose form = new Choose(accounttype);
                        Connectioncs.conn.Close();        
                        form.Show();
                   }
                }
                else MessageBox.Show("username or password is incorrect");
               
        }catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
    }

        private void Sign_in_Load(object sender, EventArgs e)
        {

        }
        public void SplashScreen()
        {
            Application.Run(new splash_screen());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConnectionDB form = new ConnectionDB();
            form.Show();
        }
        
    }
}
