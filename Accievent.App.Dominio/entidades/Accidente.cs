using System;

namespace Accievent.App.Dominio
{
    public class Accidente {

        public int Id {get;set;}
        public AgenteDeTransito AgenteDeTransito {get;set;}
        public Vehiculo Vehiculo {get;set;}
        public Victima Victima {get;set;}
        public int CodigoAccidente{get;set;}
        public string Direccion {get;set;}
        public int Latitud {get;set;}
        public int Longitud {get;set;}
        public string Barrio {get;set;}
        public string Ciudad {get;set;}
        public string Fecha {get;set;}
        public string Hora {get;set;}
        public string CodigoAgente {get;set;}
        public string Colision {get;set;}
        public string Causa {get;set;}
        public string ClaseDeAccidente {get;set;}
        
    }
}