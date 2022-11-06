using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conciertos
{
    public class Conexion
    {
        public SqlConnection cnx;

        public Conexion()
        {
            try
            {
                cnx = new SqlConnection("Data Source=WINAPQLK96JDE4A\\SQLEXPRESS;Initial Catalog=Conciertos;Integrated Security=True");
                Console.WriteLine("Éxito al conectar.");
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error al conectar. " + ex.Message);
            }
        }
    }
}
