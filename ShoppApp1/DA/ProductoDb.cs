using ShoppApp1.DA.Interfaces;
using ShoppApp1.entidades;
using System.Linq;
using System;


namespace ShoppApp1.DA
{
    public class ProductoDb: BaseDa<Producto> ,IProductoDb
    {
        public bool  Agregar(Producto producto) 
        {
            bool result = false;
            try
            {
                producto.productid = base.entities.Count + 1;
                base.Agregar(producto);

                result = true;
            }
            catch(Exception)
            {
                throw;
            }
            return result;
        }
        public bool Eliminar(int id)
            
        { 
            bool resultado = false;
            try
            { 
            Producto producto = ObtenerProductoPorId(id);
           base.Quitar(producto);
           
                resultado = true;

            
           }

            catch(Exception)
           {
           throw;
           }
            return resultado;
            
        }

        public Producto ObtenerProductoPorId(int productoid)
        {
            return base.entities.FirstOrDefault(producto => producto.productid == productoid); 
        }

    }  
}
