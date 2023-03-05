using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibreriaApi.Models
{
    public class Cliente
    {
        public int Id{get;set;}
        public string Nombre{get; set;}
        public string Apellido{get;set;}
        public string? Dirección{get;set;}
        public string? Teléfono{get; set;}
        public string? Email{get;set;}

    }
}