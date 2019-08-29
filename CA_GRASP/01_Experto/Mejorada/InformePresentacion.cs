using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_GRASP._01_Experto.Mejorada
{
    public class InformePresentacion
    {
        private Informe _informe;

        public void CalcularTotalButtonClick()
        {
            _informe.CalcularTotal();
        }
    }
}
