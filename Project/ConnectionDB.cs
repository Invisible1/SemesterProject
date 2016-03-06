using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Khuram
{
    public partial class ConnectionDB : Form
    {
        public ConnectionDB()
        {
            InitializeComponent();
            Passwordb_txt.PasswordChar = '*';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            StreamWriter File = new StreamWriter("Text_File.Text");
            File.WriteLine(instancedb_txt.Text);
            File.WriteLine(usernamedb_txt.Text);
            File.WriteLine(Passwordb_txt.Text);
            File.WriteLine(datasourcedb_txt.Text);
            File.Close();
            try
            { 
            Connectioncs conn = new Connectioncs();
            conn.Connectdatabase();
            MessageBox.Show("Connection Succesful");
            this.Hide();
                }
            catch(Exception)
            {
                MessageBox.Show("Connection Failed");
            }
        }
    }
}
