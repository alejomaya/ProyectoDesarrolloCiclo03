using System;

namespace Accievent.App.Dominio

{
    public class Persona {
        public int Id {get;set;}
        public int IdPersona {get;set;}
        public string TipoDocumento {get;set;}
        public string NumeroDocumento {get;set;}
        public string Nombres {get;set;}
        public string Apellidos {get;set;}
        public string NumeroTelefono {get;set;}
        public Genero Genero {get;set;}
        public int Edad {get;set;}
        public string correo {get;set;}
    }
}