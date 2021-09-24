using System;

namespace Accievent.App.Dominio
{
    public class Vehiculo {
        public int Id {get;set;}
        public Conductor Conductor {get;set;}
        public string NumeroPlaca {get;set;}
        public string Clase {get;set;}
        public string Modelo {get;set;}
        public string Marca {get;set;}
        public bool Soat {get;set;}
        public string Servicio {get;set;}
    }
}