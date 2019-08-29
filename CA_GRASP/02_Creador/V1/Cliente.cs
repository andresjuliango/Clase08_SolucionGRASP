using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_GRASP._02_Creador.V1
{
    public class Cliente
    {
        List<Pedido> _pedidos;

        public void AgregarPedido()
        {
            var nuevoPedido = new Pedido();
            _pedidos.Add(nuevoPedido);
        }
    }

}
