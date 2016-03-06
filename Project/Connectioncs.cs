using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.IO;
namespace Project_Khuram
{
    class Connectioncs 
    {
        public static SqlConnection conn=null;
         public void Connectdatabase()
         {
             StreamReader stream = new StreamReader("Text_File.Text");
             string line_value = "";
             string[] values = new string[4];
             int i = 0;
             while (line_value != null)
             {
                 line_value = stream.ReadLine();
                 if (line_value != null)
                 {
                     values[i]=line_value;
                 }
                 i++;
             }
             stream.Close();
             try{
//                 Data Source=190.190.200.100,1433;Network Library=DBMSSOCN;
//Initial Catalog=myDataBase;User ID=myUsername;Password=myPassword;
                 conn = new SqlConnection("Data Source=invisible\\sqlexpress;Initial Catalog=project;Integrated Security=True");
                 //conn = new SqlConnection(" Data Source="+values[3]+";Network Library=DBMSSOCN;Initial Catalog="+values[0]+";User ID="+values[1]+";Password="+values[2]+";");               
               
                 conn.Open();
                 }
             catch(Exception ex)
             {
                 MessageBox.Show("Sql Exception "+ex);
             }
        }
    }
}
