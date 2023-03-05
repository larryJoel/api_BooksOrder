using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibreriaApi.Models
{
    public class Libro
    {
       public Guid Id { get; set; }
       public Guid IdCategoria { get; set; }
       public string Titulo { get; set; }
       public string Autor { get; set; }
       public int ISBN { get; set; }
       public DateTime FechaPublica { get; set; }
       public string Editoria { get; set; }
       public int Stock { get; set; }
       public double PrecioVenta { get; set; }
       public virtual Categoria Categoria { get; set; }
       public Presentacion Presentacion { get; set; }
        
    }

    public enum Presentacion{
        TapaDura,
        TapaBlanda,
        Economica
    }
}