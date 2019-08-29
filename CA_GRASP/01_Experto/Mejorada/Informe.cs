using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_GRASP._01_Experto.Mejorada
{
    public class Informe
    {
        public int[] Parciales { get; set; }

        public void CalcularTotal()
        {
            var total = 0;

            foreach (var parcial in Parciales)
            {
                total += parcial;
            }
        }
    }
}
