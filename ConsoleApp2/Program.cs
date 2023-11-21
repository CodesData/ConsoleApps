using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ConsoleApp2
{
    internal class Program
    {
        static string ConnectionString = @"SERVER = DESKTOPHP\SQLEXPRESS; DATABASE = Database1; USER ID = sa; PASSWORD = 12345;";
        static SqlConnection MyConn = new SqlConnection(ConnectionString);
        static void Main(string[] args)
        {
            using (MyConn)
            {
                try
                {
                    MyConn.Open();
                    SqlCommand MyCMD = new SqlCommand("SELECT COUNT (*) FROM tblUsers", MyConn);
                    int Result = (int)MyCMD.ExecuteScalar();
                    Console.WriteLine(Result);
                    MyConn.Close();
                    if (Result > 0)
                    {
                        Console.WriteLine("Successful Login");
                    }
                    else
                    {
                        Console.WriteLine("Incorrect Login");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    Console.ReadKey();
                }
            }
        }
    }
}