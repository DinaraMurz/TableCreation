using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateTable
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection conection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\МырзабекДи\source\repos\CreateTable\CreateTable\Database.mdf;Integrated Security=True");
            string query =
            @"CREATE TABLE [dbo].[Gruppa]
                (
	                Id int IDENTITY(1,1) PRIMARY KEY,
	                Name nvarchar(MAX) NOT NULL
                );";
            SqlCommand cmd = new SqlCommand(query, conection);
            try
            {
                conection.Open();
                cmd.ExecuteNonQuery();
                Console.WriteLine("Таблица создана");
            }
            catch (Exception exception)
            {
                Console.WriteLine("Ошибка: " + exception.ToString());
            }

             conection.Close();
             Console.ReadLine();
        }
    }
}
