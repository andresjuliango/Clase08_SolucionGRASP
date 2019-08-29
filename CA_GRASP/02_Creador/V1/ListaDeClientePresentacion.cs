using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_GRASP._02_Creador.V1
{
    public class ListaDeClientePresentacion
    {
        Cliente _clientes;

        public void AgregarBtnClicked()
        {
            _clientes.AgregarPedido();
        }
    }
}
