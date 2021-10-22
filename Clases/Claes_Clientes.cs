using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Claes_Clientes
    {
        public List<Tbl_Clientes__credito> ListaDeClientes()
        {

            try
            {
                BaseDeDatosDataContext dc =new  BaseDeDatosDataContext();
                List<Tbl_Clientes__credito> ListaDeClientes = (from _Clientes in dc.Tbl_Clientes__credito select _Clientes).ToList();
                return ListaDeClientes;

            }
            catch (Exception)
            {
                
                return new List<Tbl_Clientes__credito>();
            }
        }

        public void GuardarCliente  ( int Telefono,
            string NombreCliente,
            string Apellido ,
            string Direccion ,
            string Cedula)
        {

            Tbl_Clientes__credito Guardar = new Tbl_Clientes__credito();
            Guardar.Nombre = NombreCliente;
            Guardar.apellidos = Apellido;
            Guardar.Direccion = Direccion;
            Guardar.Telefono = Telefono;
            Guardar.Cedula = Cedula;

            BaseDeDatosDataContext dc = new BaseDeDatosDataContext();
            dc.Tbl_Clientes__credito.InsertOnSubmit(Guardar);
            dc.SubmitChanges();




        }
    }
}
