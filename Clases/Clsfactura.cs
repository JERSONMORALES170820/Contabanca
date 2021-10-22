using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Clsfactura
    {
        public List<Tbl_Factura> facturas()
        {
            try
            {
                BaseDeDatosDataContext dc = new BaseDeDatosDataContext();
                List<Tbl_Factura> ListaDeFactura = (from _factura in dc.Tbl_Factura select _factura).ToList();
                return ListaDeFactura;

            }
            catch (Exception)
            {
                
                return new List<Tbl_Factura>();
            }
        }
    }
}
