using System;
using System.Collections.Generic;
using System.Text;
using ShoppApp1.DA.Interfaces;

namespace ShoppApp1.DA
{   
    //Clase base Generica para utilizar en las clases hijas
    // ClienteDb,EmpleadoDb,ProductoDb
    public abstract class BaseDa<TEntity> : IBaseDa<TEntity> where TEntity : class
    {
        //Una propiedad de tipo lista generica
        public List<TEntity> entities;

        //Constructor que inicaliza la lista cuando se instancia la clase
        public BaseDa()
        {
            this.entities = new List<TEntity>();
        }

        //Metodo agregar
        public bool Agregar(TEntity entity)
        {
            this.entities.Add(entity);
            return true;
        }
        
        //Metodo Quitar
        public bool Quitar(TEntity entity)
        {
            this.entities.Remove(entity);
            return true;
        }

    }
}
