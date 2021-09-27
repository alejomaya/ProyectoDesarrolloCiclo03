using System.Collections.Generic;
using Accievent.App.Dominio;

namespace Accievent.App.Persistencia
{
    public interface IRepositorioUsuario {
        //Aqui van los cuerpos de los metodos que queremos implementar
        //Son los encabezado o la plantilla para poder crear los metodos
        IEnumerable<Usuario> GetAllUsuarios();

        Usuario AddUsuario(Usuario usuario);

        Usuario UpdateUsuario(Usuario usuario);

        void DeleteUsuario(int IdUsuario);

        Usuario GetUsuario(int IdUsuario);

    }
}