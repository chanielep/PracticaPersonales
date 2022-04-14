using System;
using System.Collections.Generic;
using ShoppApp1.entidades;
using ShoppApp1.DA.Interfaces;
using System.Linq;

namespace ShoppApp1.DA
{
    public class ClienteDb : BaseDa<Cliente>, IClienteDb
    {
        public bool Agregar(Cliente cliente)
        {
            bool result = false;
            try
            {
                cliente.custid = base.entities.Count + 1;
                base.Agregar(cliente);
                result = true;


            }
            catch (Exception)
            {
                throw;
            }
            return result;
        }
        //  Debes ser igual a lo que esa en la interfaz
        public bool Eliminar(int id)
        {
            bool resultado = false;
            try
            {
                Cliente cliente = this.ObtenerClientePorId(id);
                base.Quitar(cliente);

                resultado = true;
            }
            catch (Exception)
            {

            }
            return resultado;
        }
        public Cliente ObtenerClientePorId(int clienteid)
        {

            Cliente c = new Cliente();
            try
            {
                c=base.entities.FirstOrDefault(cliente => cliente.custid == clienteid);
            }
            catch (Exception e)
            {
                throw new NullReferenceException();
            }

            return c;
        }

    }
}
