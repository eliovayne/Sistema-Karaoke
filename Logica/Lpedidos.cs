using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KaraokeCurso.Logica
{
   public  class Lpedidos
    {
        public int IdPedido { get; set; }
        public int IdMesa { get; set; }
        public int IdCancion { get; set; }
        public string Estado { get; set; }
        public string Mensaje { get; set; }
    }
}
