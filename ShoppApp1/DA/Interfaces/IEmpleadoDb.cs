using System;
using System.Collections.Generic;
using System.Text;
using ShoppApp1.entidades;
namespace ShoppApp1.DA.Interfaces
{
    public interface IEmpleadoDb
    {
        bool AgregarEmpleado(Empleado empleado);
        bool EliminarEmpleado(int id);
    }
}
