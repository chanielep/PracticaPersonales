using System;
using System.Collections.Generic;
using System.Text;
using ShoppApp1.entidades;

namespace ShoppApp1.DA.Interfaces
{
    public interface IProductoDb
    {
        public bool Agregar(Producto producto);
        public bool Eliminar(int id);
    }
}
