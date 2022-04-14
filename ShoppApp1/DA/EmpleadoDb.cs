
using ShoppApp1.entidades;
using ShoppApp1.DA.Interfaces;
using System.Linq;
using System;
using ShoppApp1.Exceptions;

namespace ShoppApp1.DA
{
    public class EmpleadoDb : BaseDa<Empleado>, IEmpleadoDb
    {

        public bool AgregarEmpleado(Empleado empleado)
        {
            bool resultado = false;
            try
            {
                empleado.empid = base.entities.Count + 1;

                base.Agregar(empleado);

                resultado = true;
            }
            catch (Exception)
            {
                throw;
            }
            return resultado;
        }

        public bool EliminarEmpleado(int id)
        {
            bool resultado = false;
            try
            {
                Empleado empleado = this.ObtenerEmpleadoPorId(id);
                base.Quitar(empleado);
                resultado = true;


            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return resultado;

        }

        public Empleado ObtenerEmpleadoPorId(int empleadoid)
        {
            Empleado em = null;

            try
            {
                em = base.entities.FirstOrDefault(empleado => empleado.empid == empleadoid);
            }
            catch (EmployeeException e)
            {
                throw new EmployeeException($"Cliente {empleadoid} no existe");
            }

            return em;
        }
    }
}