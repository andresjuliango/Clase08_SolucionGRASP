using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_GRASP._06_VariacionesProtegidas.Base
{
    public class MostrarImagenController
    {
        public void RedimensionarImagen(ImagenJpg imagenJpg)
        {
            imagenJpg.Redimensionar(20,10);
        }
    }
}
