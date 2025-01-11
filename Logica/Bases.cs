using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;

namespace KaraokeCurso.Logica
{
   public class Bases
    {
        public static string ObtenerIp(ref string valorIp)
        {
            valorIp = Dns.GetHostEntry(Environment.MachineName).AddressList.FirstOrDefault((i) => i.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork).ToString();
            return valorIp;
        }
    }
}
