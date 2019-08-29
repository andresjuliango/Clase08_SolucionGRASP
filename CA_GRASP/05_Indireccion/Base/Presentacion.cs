using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_GRASP._05_Indireccion.Base
{
    public class Presentacion
    {
        Log4Net _log4Net;

        public void MetodoPresentacion()
        {
            _log4Net.Log("Algo ha sucedido...");
        }
    }
}
