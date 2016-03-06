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
    public partial class splash_screen : Form
    {
        public splash_screen()
        {
            InitializeComponent();
        }
        public int timeLeft { get; set; }
        private void splash_screen_Load(object sender, EventArgs e)
        {
           // timeLeft = 30;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Increment(1);
            if (progressBar1.Value == 100)
            { 
                timer1.Stop();
            }
            //if(timeLeft > 0)
            //{
            //    timeLeft = timeLeft - 1;
            //}
            //else
            //{
            //    timer1.Stop();
               //new Sign_in().Show();
               // this.Hide();
            //}
        }
    }
}
