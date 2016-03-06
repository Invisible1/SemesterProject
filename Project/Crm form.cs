using System.Data.SqlClient;
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
    public partial class Crm_form : Form
    {
        public bool found = false;
        public bool found1 = false;
        public string accounttype;
        public int count = 0;
        public Crm_form(string account)
        {
            
            InitializeComponent();
            this.accounttype = account;
        }
        void AutoCompleteText(TextBox textvalue)
        {

            
        }

        private void Crm_form_Load(object sender, EventArgs e)
        {
            }



        private void btn_searchinvoice_Click(object sender, EventArgs e)
        {
            Connectioncs connec = new Connectioncs();

             SqlCommand selctcommand = new SqlCommand("select * from builling_modules where serial_no like '%" + txt_invoicenumber.Text + "%';", Connectioncs.conn);
            try
            {
                Connectioncs.conn.Open();
               SqlDataReader myreader;
                myreader = selctcommand.ExecuteReader();

                while (myreader.Read())
                {
                    count += 1;      
                   
                }
                Connectioncs.conn.Close();
                
                if (count == 1)
                {
                    SqlDataAdapter sda = new SqlDataAdapter();
                    sda.SelectCommand = selctcommand;
                    DataTable dbdataset = new DataTable();
                    sda.Fill(dbdataset);
                    BindingSource bSourse = new BindingSource();
                    bSourse.DataSource = dbdataset;
                    dataGridView1.DataSource = bSourse;
                    sda.Update(dbdataset);
                    if (dataGridView1.Rows.Count != 0)
                    {
                        found = true;
                    }
                }  
            }
            catch (Exception ex)
            {
                MessageBox.Show("No user Found" + ex);
            }
        }

        private void btn_go_Click_1(object sender, EventArgs e)
        {
            if(found==true)
            { 
            Popupform form = new Popupform();

            form.txt_serialno.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();

            form.txt_customername.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            form.txt_telno.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            form.txt_maidname.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
            form.txt_fin.Text = this.dataGridView1.CurrentRow.Cells[4].Value.ToString();
            form.txt_nationality.Text = this.dataGridView1.CurrentRow.Cells[5].Value.ToString();
            form.txt_servicefee.Text = this.dataGridView1.CurrentRow.Cells[6].Value.ToString();
            form.txt_momapplicationfee.Text = this.dataGridView1.CurrentRow.Cells[7].Value.ToString();
            form.txt_insurance.Text = this.dataGridView1.CurrentRow.Cells[8].Value.ToString();
            form.txt_meetingservice.Text = this.dataGridView1.CurrentRow.Cells[9].Value.ToString();
            form.txt_medicalcheck.Text = this.dataGridView1.CurrentRow.Cells[10].Value.ToString();
            form.txt_sip_soc.Text = this.dataGridView1.CurrentRow.Cells[11].Value.ToString();
            form.txt_poea.Text = this.dataGridView1.CurrentRow.Cells[12].Value.ToString();
            form.txt_inbound.Text = this.dataGridView1.CurrentRow.Cells[13].Value.ToString();
            form.txt_overseas.Text = this.dataGridView1.CurrentRow.Cells[14].Value.ToString();
            form.txt_localservice.Text = this.dataGridView1.CurrentRow.Cells[15].Value.ToString();
            form.txt_misc.Text = this.dataGridView1.CurrentRow.Cells[16].Value.ToString();
            form.ShowDialog();
            }
            else { found = false; }
        }

        private void btn_search_refund_Click(object sender, EventArgs e)
        {
            Connectioncs connec = new Connectioncs();

             SqlCommand selctcommand = new SqlCommand("select * from refundata where refendserialno like '%" + txt_refundno.Text + "%';", Connectioncs.conn);

            try
            {
                Connectioncs.conn.Open();
                SqlDataAdapter sda = new SqlDataAdapter();
                sda.SelectCommand = selctcommand;
                DataTable dbdataset = new DataTable();
                sda.Fill(dbdataset);
                BindingSource bSourse = new BindingSource();
                bSourse.DataSource = dbdataset;
                dataGridView2.DataSource = bSourse;
                sda.Update(dbdataset);
                Connectioncs.conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No user Found" + ex);
            }
        }

        private void btn_searchbycustomer_Click(object sender, EventArgs e)
        {
            Connectioncs connec = new Connectioncs();

            SqlCommand selctcommand = new SqlCommand("select * from builling_modules where cst_name like '%" + this.txt_customername.Text + "%';", Connectioncs.conn);
            try
            {
                Connectioncs.conn.Open();
                SqlDataReader myreader;
                myreader = selctcommand.ExecuteReader();
                count = 0;
                while (myreader.Read())
                {
                    count +=1;
                        
                    
                }
                Connectioncs.conn.Close();
                if(count>0)
                {
                    SqlDataAdapter sda = new SqlDataAdapter();
                    sda.SelectCommand = selctcommand;
                    DataTable dbdataset = new DataTable();
                    sda.Fill(dbdataset);
                    BindingSource bSourse = new BindingSource();
                    bSourse.DataSource = dbdataset;
                    dataGridView3.DataSource = bSourse;
                    sda.Update(dbdataset);
                    if (dataGridView1.Rows.Count != 0)
                    {
                        found1 = true;
                    }
                        
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No user Found");
            }
            
        }

        private void btn_go_customer_Click(object sender, EventArgs e)
        {
            if(found1==true)
            { 
            Popupform form = new Popupform();

            form.txt_serialno.Text = this.dataGridView3.CurrentRow.Cells[0].Value.ToString();

            form.txt_customername.Text = this.dataGridView3.CurrentRow.Cells[1].Value.ToString();
            form.txt_telno.Text = this.dataGridView3.CurrentRow.Cells[2].Value.ToString();
            form.txt_maidname.Text = this.dataGridView3.CurrentRow.Cells[3].Value.ToString();
            form.txt_fin.Text = this.dataGridView3.CurrentRow.Cells[4].Value.ToString();
            form.txt_nationality.Text = this.dataGridView3.CurrentRow.Cells[5].Value.ToString();
            form.txt_servicefee.Text = this.dataGridView3.CurrentRow.Cells[6].Value.ToString();
            form.txt_momapplicationfee.Text = this.dataGridView3.CurrentRow.Cells[7].Value.ToString();
            form.txt_insurance.Text = this.dataGridView3.CurrentRow.Cells[8].Value.ToString();
            form.txt_meetingservice.Text = this.dataGridView3.CurrentRow.Cells[9].Value.ToString();
            form.txt_medicalcheck.Text = this.dataGridView3.CurrentRow.Cells[10].Value.ToString();
            form.txt_sip_soc.Text = this.dataGridView3.CurrentRow.Cells[11].Value.ToString();
            form.txt_poea.Text = this.dataGridView3.CurrentRow.Cells[12].Value.ToString();
            form.txt_inbound.Text = this.dataGridView3.CurrentRow.Cells[13].Value.ToString();
            form.txt_overseas.Text = this.dataGridView3.CurrentRow.Cells[14].Value.ToString();
            form.txt_localservice.Text = this.dataGridView3.CurrentRow.Cells[15].Value.ToString();
            form.txt_misc.Text = this.dataGridView3.CurrentRow.Cells[16].Value.ToString();
            form.ShowDialog();
            }
            else { found1 = false; }
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(accounttype=="admin")
            { 
            this.Hide();
            Choose form = new Choose(accounttype);
            form.ShowDialog();
            }
            else
            {
                this.Hide();
                Choose_user form = new Choose_user(accounttype);
                form.ShowDialog();
            
            }
        }

        private void btn_go_date_Click(object sender, EventArgs e)
        {
            Connectioncs connec = new Connectioncs();

            SqlCommand selctcommand = new SqlCommand("select * from builling_modules where time between '"+ this.dateTimePicker1.Text + "' and '"+this.dateTimePicker2.Text+"';", Connectioncs.conn);
            try
            {
                Connectioncs.conn.Open();
                SqlDataReader myreader;
                myreader = selctcommand.ExecuteReader();
                count = 0;
                while (myreader.Read())
                {
                    count += 1;


                }
                Connectioncs.conn.Close();
                if (count > 0)
                {
                    SqlDataAdapter sda = new SqlDataAdapter();
                    sda.SelectCommand = selctcommand;
                    DataTable dbdataset = new DataTable();
                    sda.Fill(dbdataset);
                    BindingSource bSourse = new BindingSource();
                    bSourse.DataSource = dbdataset;
                    dataGridView4.DataSource = bSourse;
                    sda.Update(dbdataset);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No user Found");
            }
        }
    }
}
