using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibreriaApi.Models
{
    public class Prestamo
    {
      public Guid Id {get;set;}
      public Guid IdLibro {get;set;}
      public Guid IdCliente {get;set;}
      public DateTime FechaPrestamo{get;set;}
      public DateTime FechaDevolucion{get;set;}

    }
}