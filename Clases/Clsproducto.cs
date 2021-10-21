using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
   public class Clsproducto
    {
       public List<tbl_producto> productos()
       {
           try
           {
               BaseDeDatosDataContext dc = new BaseDeDatosDataContext();
               List<tbl_producto> ListaProducto = (from _productos in dc.tbl_producto select _productos).ToList();
               return ListaProducto;
           }
           catch (Exception)
           {
               
               return new List<tbl_producto>();
           }
       }

    }
}
