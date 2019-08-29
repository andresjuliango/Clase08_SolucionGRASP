using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_GRASP._05_Indireccion.Mejorada
{
    public class ServicioLog
    {
        private Log4Net _log4Net;

        public void Log(string mensaje)
        {
            _log4Net.Log(mensaje);
        }
    }
}
