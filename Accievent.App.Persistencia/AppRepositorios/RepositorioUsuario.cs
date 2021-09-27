using System.Collections.Generic;
using System.Linq;
using Accievent.App.Dominio;

namespace Accievent.App.Persistencia
{
    public class RepositorioUsuario : IRepositorioUsuario {

        private readonly AppContext _appContext;

        public RepositorioUsuario(AppContext appContext) {
            _appContext = appContext;
        }

        Usuario IRepositorioUsuario.AddUsuario(Usuario usuario) {
            var usuarioAdicionado = _appContext.Usuarios.Add(usuario);
            _appContext.SaveChanges();
            return usuarioAdicionado.Entity;
        }

        void IRepositorioUsuario.DeleteUsuario(int IdUsuario) {
            var usuarioEncontrado = _appContext.Usuarios.FirstOrDefault( u => u.Id == IdUsuario);

            if(usuarioEncontrado == null) {
                return;
            }
            _appContext.Usuarios.Remove(usuarioEncontrado);
            _appContext.SaveChanges();
        }

        IEnumerable<Usuario> IRepositorioUsuario.GetAllUsuarios() {
            return _appContext.Usuarios;
        }

        Usuario IRepositorioUsuario.GetUsuario(int IdUsuario) {
            var usuarioEncontrado = _appContext.Usuarios.FirstOrDefault( u => u.Id == IdUsuario);

            return usuarioEncontrado;
        }

        Usuario IRepositorioUsuario.UpdateUsuario(Usuario usuario) {
            var usuarioEncontrado = _appContext.Usuarios.FirstOrDefault(u => u.Id == usuario.Id);

            if(usuarioEncontrado != null) {
                usuarioEncontrado.TipoDocumento = usuario.TipoDocumento;
                usuarioEncontrado.NumeroDocumento = usuario.NumeroDocumento;
                usuarioEncontrado.Nombres = usuario.Nombres;
                usuarioEncontrado.Apellidos = usuario.Apellidos;
                usuarioEncontrado.NumeroTelefono = usuario.NumeroTelefono;
                usuarioEncontrado.Genero = usuario.Genero;
                usuarioEncontrado.Edad = usuario.Edad;
                usuarioEncontrado.Correo = usuario.Correo;

                _appContext.SaveChanges();
            }

            return usuarioEncontrado;

        //      public string TipoDocumento {get;set;}
        // public string NumeroDocumento {get;set;}
        // public string Nombres {get;set;}
        // public string Apellidos {get;set;}
        // public string NumeroTelefono {get;set;}
        // public Genero Genero {get;set;}
        // public int Edad {get;set;}
        // public string correo {get;set;}
        }
    }
}