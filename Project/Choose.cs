using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Khuram
{
    public partial class Choose : Form
    {
        public string account_type = null;
        public Choose(string account_type)
        {
            Connectioncs.conn.Close();
            InitializeComponent();
            this.account_type = account_type;
        }
        
        private void btn_builling_Click(object sender, EventArgs e)
        {
            this.Hide();
            Bulling_Module formbill = new Bulling_Module(account_type);
            formbill.Show();
        }

        private void btn_useradd_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignUp signup = new SignUp(account_type);
            signup.Show();
        }

        private void Choose_Load(object sender, EventArgs e)
        {

        }

        private void btn_crm_Click(object sender, EventArgs e)
        {
            this.Hide();
            Crm_form form = new Crm_form(account_type);
            form.Show();
        }
    }
}
