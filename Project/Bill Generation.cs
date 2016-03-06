using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using System.Drawing.Printing;
namespace Project_Khuram
{
    public partial class Bill_Generation : Form
    {
        public Bill_Generation(string reciptnumber,float total)
        {
            
            InitializeComponent();
            reciptnoinvoice.Text = reciptnumber;
            labl_totallable.Text = total.ToString();
        }

        private void Bill_Generation_Load(object sender, EventArgs e)
        {
            txt_paymentcombo.Items.Add("Cash");
            txt_paymentcombo.Items.Add("Nets");
            txt_paymentcombo.Items.Add("Credit Card");
            txt_paymentcombo.Items.Add("Bank Transfer");
            
        
        }

        private void btn_generatebill_Click(object sender, EventArgs e)
        {
            Document doc = new Document(iTextSharp.text.PageSize.LETTER, 10, 10, 42, 35);
            PdfWriter wri = PdfWriter.GetInstance(doc, new FileStream("F:\\Gujjar Project\\Bill "+reciptnoinvoice.Text+".pdf", FileMode.Create));
            doc.Open();
            Paragraph temp = new Paragraph();
            Paragraph para = new Paragraph("                EMPLOY MENT SERVICES CENTER                                                              OFFICIAL RECEPT");
            doc.Add(para);
            Paragraph paragraph = new Paragraph("               Blk 133 Jurong Gateway Road #03-303, Singapore 600133.");
            doc.Add(paragraph);
            Paragraph paragraph1 = new Paragraph("               Tel: 65606689 Fax:65606242                                                          NO:JE   "+reciptnoinvoice.Text+"");
            doc.Add(paragraph1);
            Paragraph paragraph2 = new Paragraph("               Agency Licence No: 00C5666");
            doc.Add(paragraph2);
            Paragraph paragraph3 = new Paragraph("                                                                                                                Date:"+DateTime.Now+"");
            doc.Add(paragraph3);
            doc.Add(temp);
            doc.Add(temp);
            doc.Add(temp);
            doc.Add(temp);
            Paragraph paragraph4 = new Paragraph("Recieved From                            "+txt_recievedfrom.Text+"");
            doc.Add(paragraph4);
            
            doc.Add(temp);
            Paragraph paragraph5 = new Paragraph("The Sum of dollars                      " + labl_totallable.Text + "");
            doc.Add(paragraph5);
            doc.Add(temp);

            Paragraph paragraph6 = new Paragraph("Being Payment of                       " + txt_payment.Text + "");
            doc.Add(paragraph6);
            doc.Add(temp);
            Paragraph paragraph7 = new Paragraph("$" + txt_payment.Text + "                                                                                              BY                  ");
            doc.Add(paragraph7);
            Paragraph paragraph8 = new Paragraph("" + txt_paymentcombo.Text + "");
            doc.Add(paragraph8);
            doc.Add(temp);

            doc.Close();
        }
        void printDocument_Printpage(object sender,PrintPageEventArgs e)
        {
            Graphics graphic = e.Graphics;
            //Font fount = new Font("Courier New",12);
            //float fountheight = fount.GetHeight();
            //int startx = 10;
            //int starty = 10;
            //int offset = 40;
            //graphic.DrawString("Delta Employment Vault (DEV)\n", new Font("Courier New", 18),new SolidBrush(Color.Black),startx,starty);
            //offset = offset + 20;
            //graphic.DrawString("Recieved From \t\t" + txt_recievedfrom.Text + "\n", new Font("Courier New", 18), new SolidBrush(Color.Black), startx, starty);
            //offset = offset + 20;
            //graphic.DrawString("Sume of Dollars\t\t" + labl_totallable.Text + "\n", new Font("Courier New", 18), new SolidBrush(Color.Black), startx, starty);
            //offset = offset + 20;
            //graphic.DrawString("Being Payment off\t\t" + txt_payment.Text + "\n", new Font("Courier New", 18), new SolidBrush(Color.Black), startx, starty);
            //offset = offset + 20;
            //graphic.DrawString("Payment By \t\t" + txt_paymentcombo.Text + "\n", new Font("Courier New", 18), new SolidBrush(Color.Black), startx, starty);


        }
        private void print_Click(object sender, EventArgs e)
        {
            PrintDialog printdialog = new PrintDialog();
            PrintDocument printdocument = new PrintDocument();
            printdialog.Document = printdocument;
            printdocument.PrintPage += new PrintPageEventHandler(printDocument_Printpage);
            DialogResult reult = printdialog.ShowDialog();
            if(reult==DialogResult.OK)
            {
                printdocument.Print();
            }
        }
    }
}
