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
    public partial class Choose_user : Form
    {
        public string account_type = null;

        public Choose_user(string account_type)
        {
            InitializeComponent();
            this.account_type = account_type;
        }

        private void btn_Builling_Click(object sender, EventArgs e)
        {
            this.Hide();
            Bulling_Module form = new Bulling_Module(account_type);
            form.ShowDialog();
        }

        private void btn_crm_Click(object sender, EventArgs e)
        {
            this.Hide();
            Crm_form form = new Crm_form(account_type);
            form.Show();
        }
    }
}
