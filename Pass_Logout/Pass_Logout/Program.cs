using System;
using System.Data;
using System.Data.SqlClient;

namespace Pass_Logout
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=HRM;Integrated Security=True");

            Console.Write("Enter the employee id :");

            int Emp_ID = Convert.ToInt32(Console.ReadLine());
            int Change = 1;

            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;

            cmd.CommandText = "UPDATE  PASS  SET LOG_IN_OUT ='"+Change+"'  WHERE EMP_ID = '" + Emp_ID + "' ";
            
            cmd.ExecuteNonQuery();
            con.Close();

            Console.WriteLine("Success full update");
        }
    }
}
