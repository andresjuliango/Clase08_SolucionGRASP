using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_GRASP._01_Experto.Base
{
    public class InformePresentacion
    {
        private Informe _informe;

        public void CalcularTotalButtonClick()
        {
            var total = 0;

            foreach (var parcial in _informe.Parciales)
            {
                total += parcial;
            }
        }
    }
}
