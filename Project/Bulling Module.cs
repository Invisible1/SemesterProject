using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Data.SqlClient;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;



namespace Project_Khuram
{

    public partial class Bulling_Module : Form
    {
        public string account_type = null;
        public string serialnumber;
        public float totalpayable;
        public int val;
        public int count = 0;
        public DateTime now;
        public Bulling_Module(string account_type)
        {
            InitializeComponent();
            now = DateTime.Now;
            //Connectioncs.conn.Close();
            this.account_type = account_type;
            if(account_type=="user")
            {
                menuStrip1.Items.RemoveAt(1);
            }
            try
            {
                Connectioncs conn = new Connectioncs();
                SqlCommand selctcommand = new SqlCommand("select MAX(serial_no) As serial from builling_modules ;", Connectioncs.conn);
                SqlDataReader myreader;
                
                Connectioncs.conn.Open();
                conn.Connectdatabase();
                myreader = selctcommand.ExecuteReader();
                
                
                while (myreader.Read())
                {
                   if(myreader["serial"]==DBNull.Value)
                   {
                       serialnumber = "S000000";
                   }
                   else
                   { 
                    serialnumber = (string)myreader["serial"];
                    count += 1;
                   }
                       
                 }
                Connectioncs.conn.Close();
            }catch(Exception ex )
            {
                MessageBox.Show("Error "+ex);
            }
            
        }
       
        private void Bulling_Module_Load(object sender, EventArgs e)
        {
            txt_sip.Items.Add("SIP");
            txt_sip.Items.Add("SOC");
           
        }
        private void btn_save_Click(object sender, EventArgs e)
        {
            if (txt_customername.Text == "" || txt_fin.Text == "" ||
            txt_tel.Text == "" ||
            txt_Nationality.Text == "" ||
            txt_servicefee.Text == "" ||
            txt_momfee.Text == "" ||
            txt_insurance.Text == "" ||
            txt_medicalcheckup.Text == "" ||
            txt_meetingservice.Text == "" ||
            txt_sip.Text == "" ||
            txt_inbound.Text == "" ||
            txt_poea.Text == "" ||
            txt_overseas.Text == "" ||
            txt_localservice.Text == "" ||
            txt_maidname.Text == "" ||
            txt_misc.Text == "")
            {
                MessageBox.Show("Some fields are not complete");
            }
            else
            {
                Connectioncs.conn.Close();
                if(count>0)
                { 
                totalpayable = float.Parse(txt_servicefee.Text) + float.Parse(txt_momfee.Text) + float.Parse(txt_localservice.Text);
                string str = serialnumber.Substring(serialnumber.LastIndexOf('S') + 1);
                int i = Convert.ToInt32(str);
                i++;
                serialnumber = i.ToString("D" + 6);
                serialnumber = "S" + serialnumber;
                }  
                lb_formnumber.Text = serialnumber;
                Connectioncs.conn.Open();
                string format = "yyyy-MM-dd HH:mm:ss ";

                string query = "insert into builling_modules (serial_no,cst_name,tel_no,maid_name,fin_txt,nationality,servicefee,momfee,insurance,meetingservice,medical_checkup,sip,poea,inboundflight,overseas,localservices,misc,time)  values ('" + serialnumber + "','" + txt_customername.Text + "','" + txt_tel.Text + "','" + txt_maidname.Text + "','" + txt_fin.Text + "','" + txt_Nationality.Text + "','" + txt_servicefee.Text + "','" + txt_momfee.Text + "','" + txt_insurance.Text + "','" + txt_meetingservice.Text + "','" + txt_medicalcheckup.Text + "','" + txt_sip.Text + "','" + txt_poea.Text + "','" + txt_inbound.Text + "','" + txt_overseas.Text + "','" + txt_localservice.Text + "','" + txt_misc.Text + "','"+now.ToString(format)+"')";
                SqlCommand cmdDtaBase = new SqlCommand(query, Connectioncs.conn);
                SqlDataReader myReader;
                try
                {
                    myReader = cmdDtaBase.ExecuteReader();
                    while (myReader.Read())
                    {

                    }
                    Connectioncs.conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error Message " + ex);
                }
            }
        }

        private void txt_tel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(char.IsNumber(e.KeyChar))
            {

            }
            else
            {
                e.Handled = e.KeyChar != (char)Keys.Back;
            }
        }

        private void btn_generatebill_Click(object sender, EventArgs e)
        {
            
            Bill_Generation billform = new Bill_Generation(serialnumber,totalpayable);
            billform.Show();
        }

        private void txt_keypressvalue(object sender, KeyPressEventArgs e)
        {

            if (char.IsNumber(e.KeyChar) || e.KeyChar == '.')
           {
               
           }
           else
           {
               e.Handled = e.KeyChar != (char)Keys.Back;
           }
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
            Connectioncs.conn.Close();
          }

        private void refundToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (account_type == "admin")
            {
                Refundform refund = new Refundform();
                refund.Show();
            }
            else MessageBox.Show("This Fuctionality is not avaliable to you\n\n\n\tThanks");
             }

        private void btn_generateinvoice_Click(object sender, EventArgs e)
        {
            Document doc = new Document(iTextSharp.text.PageSize.LETTER, 10, 10, 42, 35);
            PdfWriter wri = PdfWriter.GetInstance(doc, new FileStream("F:\\Gujjar Project\\"+serialnumber+".pdf", FileMode.Create));
            doc.Open();
            Paragraph temp=new Paragraph();
            Paragraph para = new Paragraph("                                                                  DELTA    EMP    VAULT    ");
            doc.Add(para);
            doc.Add(temp);
            Paragraph paragraph = new Paragraph("Customer Name:      "+txt_customername.Text+".                                                                Telephone no:          "+txt_tel.Text+".");
            doc.Add(paragraph);
            doc.Add(temp); 
            Paragraph paragraph1 = new Paragraph("Maid Name:      " + txt_maidname.Text + ".");                 
            doc.Add(paragraph1);
            doc.Add(temp);
            Paragraph paragraph2 = new Paragraph("FIN :      " + txt_fin.Text + ".                                                                             Nationality:          " + txt_Nationality.Text + ".");
            doc.Add(paragraph2);
            doc.Add(temp);
            Paragraph paragraph3 = new Paragraph("        1.  Service Fee:      " + txt_servicefee.Text + ".$");
            doc.Add(paragraph3);
            doc.Add(temp);
            Paragraph paragraph4 = new Paragraph("        2.  Mom Application Fee:      " + txt_maidname.Text + ".$");
            doc.Add(paragraph4);
            doc.Add(temp);
            Paragraph paragraph5 = new Paragraph("        3.  Insurance:      " + txt_insurance.Text + ".");
            doc.Add(paragraph5);
            doc.Add(temp);
            Paragraph paragraph6 = new Paragraph("        4.  Meeting Services:      " + txt_meetingservice.Text + ".");
            doc.Add(paragraph6);
            doc.Add(temp);
            Paragraph paragraph7 = new Paragraph("        5.  Medical Check Up:      " + txt_medicalcheckup.Text + ".");
            doc.Add(paragraph7);
            doc.Add(temp);
            Paragraph paragraph8 = new Paragraph("        6.  Sip>Soc:      " + txt_sip.Text + ".");
            doc.Add(paragraph8);
            doc.Add(temp);
            Paragraph paragraph9 = new Paragraph("        7.  POEA / Embassy Contract and Passport Paperwork:      " + txt_poea.Text + ".");
            doc.Add(paragraph9);
            doc.Add(temp);
            Paragraph paragraph10 = new Paragraph("       8.  InBound Flight:      " + txt_inbound.Text + ".");
            doc.Add(paragraph10);
            doc.Add(temp);
            Paragraph paragraph11 = new Paragraph("       9.  Overseas:      " + txt_overseas.Text + ".");
            doc.Add(paragraph11);
            doc.Add(temp);
            Paragraph paragraph12 = new Paragraph("      10.  Local Service Fee:      " + txt_localservice.Text + ".$");
            doc.Add(paragraph12);
            doc.Add(temp);
            Paragraph paragraph13 = new Paragraph("      11.  MISC:      " + txt_misc.Text + ".");
            doc.Add(paragraph13);
            doc.Add(temp);
            doc.Close();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txt_customername.Text = "";
            txt_fin.Text = "";
            txt_tel.Clear();
            txt_Nationality.Clear();
            txt_servicefee.Clear();
            txt_momfee.Clear();
            txt_insurance.Text = "";
            txt_medicalcheckup.Text = "";
            txt_meetingservice.Text = "";
            txt_sip.Text="";
            txt_inbound.Text = "";
            txt_poea.Text = "";
            txt_overseas.Text = "";
            txt_localservice.Text = "";
            txt_maidname.Text = "";
            txt_misc.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(account_type=="user")
            {
                this.Hide();
                Choose_user form = new Choose_user(account_type);
                form.ShowDialog();
            }
            else
            {
                this.Hide();
                Choose form = new Choose(account_type);
                form.ShowDialog();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
            Connectioncs.conn.Close();
        }

        private void userAccessControlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(account_type=="admin")
            {
                SignUp form = new SignUp(account_type);
                form.ShowDialog();
            }
        }
       

    }
    
}
