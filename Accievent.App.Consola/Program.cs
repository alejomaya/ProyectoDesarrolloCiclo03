using System;
using Accievent.App.Dominio;
using Accievent.App.Persistencia;

namespace Accievent.App.Consola
{
    class Program
    {

        private static IRepositorioUsuario _repoUsuario = new RepositorioUsuario(new Persistencia.AppContext());

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World Funcionaaaaaaaaaaaaaaaaa!");
            // AddUsuario();
            // BuscarUsuario(1);
            // EliminarUsuario(1); este metodo me da error 

            var usuarioActualizar = new Usuario {
                Id = 1,
                TipoDocumento = "CC",
                NumeroDocumento = "1085325288",
                Nombres = "Probando 01",
                Apellidos = "Probando 02",
                NumeroTelefono = "5646411",
                Genero = Genero.masculino,
                Edad = 85,
                Correo = "Kenishi@gmail.com"
            };

            ActualizarUsuario(usuarioActualizar);
        }

        private static void AddUsuario() {
            var usuario = new Usuario{
                Id = 1,
                TipoDocumento = "CC",
                NumeroDocumento = "1085325287",
                Nombres = "Christian",
                Apellidos="Lazo",
                NumeroTelefono = "3163746523",
                Genero = Genero.masculino,
                Edad = 25,
                Correo = "Kenishi.cristian@Hotmail.com"
            };

            _repoUsuario.AddUsuario(usuario);
        }

        private static void BuscarUsuario(int IdUsuario) {
            var usuario = _repoUsuario.GetUsuario(IdUsuario);
            Console.WriteLine(usuario.Nombres + " " + usuario.Apellidos);
        }

        // private static void EliminarUsuario(int IdUsuario) {
        //     var usuario = _repoUsuario.DeleteUsuario(IdUsuario);

        //     Console.WriteLine("El usuario "+usuario.Nombres + " " + usuario.Apellidos+ " Ha sido Eliminado");
        // }

        private static void ActualizarUsuario(Usuario usuario) {

            var usuarioAct = _repoUsuario.UpdateUsuario(usuario);

            if(usuarioAct != null) {
                Console.WriteLine("Usuario actualizado");
            }
            
        }
    }
}
