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
    public partial class Popupform : Form
    {
        public Popupform()
        {
            InitializeComponent();
        }

        private void btn_generatebill_Click(object sender, EventArgs e)
        {
            this.Hide();
            float total;
            total = float.Parse(txt_servicefee.Text) + float.Parse(txt_momapplicationfee.Text)+float.Parse(txt_localservice.Text);
            Bill_Generation form = new Bill_Generation(txt_serialno.ToString(),total);
            form.txt_copied.Text = "Copied";
            form.ShowDialog();
        }
    }
}
