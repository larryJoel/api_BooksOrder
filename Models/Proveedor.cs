using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibreriaApi.Models
{
    public class Proveedor
    {
        public Guid Id{get;set;}
        public string Nombre{get; set;}
        public string Direccion{get;set;}
        public string Telefono{get; set;}
        public string Email{get; set;}

    }
}