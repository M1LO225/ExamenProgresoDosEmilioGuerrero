using ExamenProgresoDosEmilioGuerrero.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenProgresoDosEmilioGuerrero.Interfaces
{
    public interface IUsuarioRecarga

    {
        IEnumerable<IUsuarioRecarga> DevuelveListadoUsuario();
        UsuarioRecarga DevuelveUsuario(int Numero);
        bool CrearUsuarioRecarga(UsuarioRecarga usuario);
        bool ActualizarUsuarioRecarga(UsuarioRecarga usuario);
        bool EliminarUsuarioRecarga(int Numero);
        UsuarioRecarga DevuelveUsuario(object numero);
    }
}
