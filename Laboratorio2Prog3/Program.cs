using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio2Prog3
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\dlobato\Desktop\Lab2\Laboratorio2Prog3\Laboratorio2Prog3\MyData.mdf;Integrated Security=True");
            connection.Open();
            Console.WriteLine(connection.State);
            string Salir = "no";
            while (Salir.ToLower() == "no")
            {
                Console.Write("Nombres: ");
                string name = Console.ReadLine();
                Console.Write("Apellidos: ");
                string lastName = Console.ReadLine();

                SqlCommand command = new SqlCommand($"insert into TblTest(Nombre, Apellidos) Values('{name}','{lastName}')");
                int CantidadRegistros = command.ExecuteNonQuery();

                Console.WriteLine($"Registros afectados: {CantidadRegistros}");
                Console.Write("Desea Salir: ");
                Salir = Console.ReadLine();
            }
            Console.ReadKey();
        }
    }
}
