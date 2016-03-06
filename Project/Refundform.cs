using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using System.IO;
using iTextSharp.text.pdf;

namespace Project_Khuram
{
    public partial class Refundform : Form
    {
        public DateTime now;
        public string refundserialnumber = null;
        public bool found = false;
        public int val;
        public string serialno=null;
        public int count = 0;
        public Refundform()
        {
            InitializeComponent();

            txt_refundedto.Enabled = false;
            txt_toataldollar.Enabled = false;
            txt_payment.Enabled = false;
            txt_combovalues.Enabled = false;
            txt_combovalues.Items.Add("Cash");
            txt_combovalues.Items.Add("Nets");
            txt_combovalues.Items.Add("Credit Card");
            txt_combovalues.Items.Add("Bank Transfer");
            Connectioncs conne = new Connectioncs();
            //Connectioncs.conn.Open();
            SqlCommand selctcommand = new SqlCommand("select MAX(refendserialno) As serial from refundata;", Connectioncs.conn);
            SqlDataReader myreader;
            try
            {
                myreader = selctcommand.ExecuteReader();
                while (myreader.Read())
                {
                    if(myreader["serial"]==DBNull.Value)
                    { refundserialnumber = "R000000"; 
                        
                    }
                    else
                    { 
                    refundserialnumber = (string)myreader["serial"];
                    count += 1;
                    }
                }
                Connectioncs.conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
           
            if(found==true)
            {
                if(txt_combovalues.Text=="" || txt_payment.Text==""||txt_refundedto.Text==""||txt_toataldollar.Text=="")
                {
                    MessageBox.Show(" Some Fields Missing ");
                }
                else
                { 
                try
                {
                    if(count>0)
                    { 
                        string str = refundserialnumber.Substring(refundserialnumber.LastIndexOf('R') + 1);
                        int i = Int32.Parse(str);
                        i++;
                        refundserialnumber = i.ToString("D" + 6);

                        refundserialnumber = "R" + refundserialnumber;
                    }  
                    refundserialnumber = serialno+"_"+refundserialnumber;
                    lbl_newinvoicerefundnumber.Text = refundserialnumber;
                    now = DateTime.Now;
                    string format = "yyyy-MM-dd HH:mm:ss ";
                    string query = "insert into refundata (refendserialno,refundto_name,totalammount,payedammount,modeofPayment,Original_invoicenumber,time_system)  values ('" + refundserialnumber + "','" + txt_refundedto.Text + "','" + txt_toataldollar.Text + "','" + txt_payment.Text + "','" + txt_combovalues.Text + "','" + serialno.ToString() + "','"+now.ToString(format)+"')";
                    Connectioncs connect = new Connectioncs();
                    Connectioncs.conn.Open();
                    SqlCommand selctcommand = new SqlCommand(query, Connectioncs.conn);
                    SqlDataReader myreader;
                    myreader = selctcommand.ExecuteReader();
                    while (myreader.Read())
                    {

                    }
                    MessageBox.Show("SAVED");
                    Connectioncs.conn.Close();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                }
            }
        }
        void printDocument_Printpage(object sender, PrintPageEventArgs e)
        {
            Graphics graphic = e.Graphics;
           // Font fount = new Font("Courier New", 12);
          //  float fountheight = fount.GetHeight();
            int startx = 10;
            int starty = 10;
           // int offset = 40;
          //  graphic.DrawString("Delta Employment Vault (DEV)", new Font("Courier New", 18), new SolidBrush(Color.Black), startx, starty);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Document doc = new Document(iTextSharp.text.PageSize.LETTER, 10, 10, 42, 35);
            PdfWriter wri = PdfWriter.GetInstance(doc, new FileStream("F:\\Gujjar Project\\Bill " + lbl_newinvoicerefundnumber.Text + ".pdf", FileMode.Create));
            doc.Open();
            Paragraph temp = new Paragraph();
            Paragraph para = new Paragraph("                EMPLOY MENT SERVICES CENTER                                          OFFICIAL RECEPT");
            doc.Add(para);
            Paragraph paragraph = new Paragraph("               Blk 133 Jurong Gateway Road #03-303, Singapore 600133.");
            doc.Add(paragraph);
            Paragraph paragraph1 = new Paragraph("               Tel: 65606689 Fax:65606242                                             NO:JE   " + lbl_newinvoicerefundnumber.Text + "");
            doc.Add(paragraph1);
            Paragraph paragraph2 = new Paragraph("               Agency Licence No: 00C5666");
            doc.Add(paragraph2);
            Paragraph paragraph3 = new Paragraph("                                                                                                      Date:" + DateTime.Now + "");
            doc.Add(paragraph3);
            doc.Add(temp);
            doc.Add(temp);
            doc.Add(temp);
            doc.Add(temp);
            Paragraph paragraph4 = new Paragraph("txt_refundedto                          " + txt_refundedto.Text + "");
            doc.Add(paragraph4);

            doc.Add(temp);
            Paragraph paragraph5 = new Paragraph("The Sum of dollars                        " + txt_toataldollar.Text + "");
            doc.Add(paragraph5);
            doc.Add(temp);

            Paragraph paragraph6 = new Paragraph("Being Payment of                          " + txt_payment.Text + "");
            doc.Add(paragraph6);
            doc.Add(temp);
            Paragraph paragraph7 = new Paragraph("$" + txt_payment.Text + "                                                                                              BY                  ");
            doc.Add(paragraph7);
            Paragraph paragraph8 = new Paragraph("" + txt_combovalues.Text + "");
            doc.Add(paragraph8);
            doc.Add(temp);

            doc.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Connectioncs connect = new Connectioncs();
            Connectioncs.conn.Close();
            SqlCommand selctcommand = new SqlCommand("select * from builling_modules where serial_no='" + txt_reciptnumber.Text + "';", Connectioncs.conn);
            try
            {
                Connectioncs.conn.Open();
                SqlDataReader myreader;
                  myreader = selctcommand.ExecuteReader();
                  int rowCount = dataGridView1.Rows.Count;
                if(rowCount>=1)
                { 
                  for (int i = 0; i < rowCount; i++)
                  {

                      dataGridView1.Rows.RemoveAt(i);
                      found = false;
                      --rowCount;
                  }
                }
                dataGridView1.Refresh();
                     while (myreader.Read())
                {
                    if (myreader["serial_no"] == DBNull.Value)
                    {
                        MessageBox.Show("NO Record Found");
                        Connectioncs.conn.Close();
                    }
                    else
                    {
                        

                        Connectioncs.conn.Close();
                        SqlDataAdapter sda = new SqlDataAdapter();
                        sda.SelectCommand = selctcommand;
                        DataTable dbdataset = new DataTable();
                        sda.Fill(dbdataset);
                        BindingSource bSourse = new BindingSource();
                        bSourse.DataSource = dbdataset;
                        dataGridView1.DataSource = bSourse;
                        sda.Update(dbdataset);
                        serialno = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                        if (dataGridView1.Rows.Count > 0)
                        {
                            found = true;
                        }
                        Connectioncs.conn.Close();
                        
                        break;
                    }

                }
                Connectioncs.conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            if(found==true)
            { 
                txt_refundedto.Enabled = true;
                txt_toataldollar.Enabled = true;
                txt_payment.Enabled = true;
                txt_combovalues.Enabled = true;
            }
            else
            {
                txt_combovalues.Text="" ;
                txt_payment.Text="";
                txt_refundedto.Text="";
                txt_toataldollar.Text = "";
                txt_reciptnumber.Text = "";
                txt_refundedto.Enabled = false;
                txt_toataldollar.Enabled = false;
                txt_payment.Enabled = false;
                txt_combovalues.Enabled = false;
            }

        }
    }
}
