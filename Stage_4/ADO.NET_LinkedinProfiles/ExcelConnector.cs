using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using System.IO;

namespace ADO.NET_LinkedinProfiles
{
    public class ExcelConnector
    {
        private static FileStream fs;
        public static void WriteOnExcel(List<Profiles> profiles)
        {
            string path = Environment.CurrentDirectory + "\\LinkeidnProfiles.xlsx";
            try
            {
                using (fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.ReadWrite))
                {
                    var s = $"Provider=Microsoft.OLEDB.16.0;Data Source={Path.GetFullPath(path)};Extended Properties='Excel 16.0 Xml;HDR=YES;IMEX=1;MAXSCANROWS=0'";
                    using (OleDbConnection connect = new OleDbConnection(s))
                    {
                        connect.Open();
                        Console.WriteLine(connect.State);
                        string query = "Insert into [Sheet1$] (EMPLOYEE_ID,ADDRESS1) values('5','e')";
                        using (OleDbDataAdapter objDA = new OleDbDataAdapter(query, connect))
                        {
                            using (DataSet excelDataSet = new DataSet())
                            {
                                objDA.Fill(excelDataSet);
                                DataTable dataTable = excelDataSet.Tables[0];
                            }
                        }
                    }
                    
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
        }
    }
}
