using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conciertos
{
    public class Conciertos
    {

        public int? Id { get; set; }

        public string nombre { get; set; }

        public DateTime fechaConcierto { get; set; }

        public int precioEntrada { get; set; }

        public int numeroAsiento { get; set; }

        public string descripcion { get; set; }
    }
}
