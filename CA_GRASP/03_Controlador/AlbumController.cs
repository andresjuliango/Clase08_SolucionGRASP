using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_GRASP._03_Controlador
{
    public class AlbumController
    {
        public RepositorioFotos _repositorioFotos;

        public void EtiquetarFoto(string nuevaEtiqueta)
        {
            var foto = _repositorioFotos.LeerFoto();
            foto.AgregarEtiqueta(nuevaEtiqueta);
            _repositorioFotos.ActualizarFoto(foto);

        }
    }
}
