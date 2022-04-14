using System;
using System.Collections.Generic;
using System.Text;
using ShoppApp1.entidades;

namespace ShoppApp1.DA.Interfaces
{
   public interface IClienteDb
    {
        public bool Agregar(Cliente cliente);
        public bool Eliminar(int id);
        public Cliente ObtenerClientePorId(int clienteid);
    }
}
