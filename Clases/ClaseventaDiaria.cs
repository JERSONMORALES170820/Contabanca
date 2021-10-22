using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class ClaseventaDiaria
    {
        public List<tbl_VentasDiarias> venta()
        {
            try
            {
                BaseDeDatosDataContext dc = new BaseDeDatosDataContext();
                List<tbl_VentasDiarias> listaVentasDiarias = (from _ventas in dc.tbl_VentasDiarias select _ventas).ToList();
                return listaVentasDiarias;
            }
            catch (Exception)
            {

                return new List<tbl_VentasDiarias>();
            }
        }
    }
}
