using System;
using System.Collections.Generic;
using System.Text;
using ShoppApp1.DA.Interfaces;
namespace ShoppApp1.DA.Interfaces
{
 public interface IBaseDa<TEntity> where TEntity : class
    {

        bool Agregar(TEntity entity);
        bool Quitar(TEntity entity);


    }
}
