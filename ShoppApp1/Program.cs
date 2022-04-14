using System;
using ShoppApp1.DA;
using ShoppApp1.entidades;

namespace ShoppApp1
{
    class Program
    {

        static void Main(string[] args)
        {
            //Recuerda agrega el un elemento con su nombre
            //ClienteDb db = new ClienteDb();
            //Cliente cliente1 = new Cliente();
            //cliente1.companyname = "Pedro";

            //db.Agregar(cliente1);

            //Cliente cliente2 = new Cliente();
            //cliente2.companyname = "Jose";
            //db.Agregar(cliente2);

            //db.Eliminar(2);

            //Console.WriteLine(db.ObtenerClientePorId(1).companyname);

            //Console.WriteLine(db.ObtenerClientePorId(2).companyname);


            EmpleadoDb db = new EmpleadoDb();

            Empleado empleado1 = new Empleado();
            empleado1.firstname = "Maria";

            db.AgregarEmpleado(empleado1);

            Empleado empleado2 = new Empleado();
            empleado2.firstname = "Pedro";


            db.AgregarEmpleado(empleado2);

            db.EliminarEmpleado(2);

            Console.WriteLine(db.ObtenerEmpleadoPorId(2).empid + " "
                            + db.ObtenerEmpleadoPorId(2).firstname);

            //ProductoDb db = new ProductoDb();

            //Producto producto1 = new Producto();
            //producto1.productname = " Juego de niño";

            //Producto producto2 = new Producto();
            //producto2.productname = "Agua";


            //db.Agregar(producto2);
            //db.Agregar(producto1);


            //Console.WriteLine(db.ObtenerProductoPorId(1).productid +
            //    "" + db.ObtenerProductoPorId(1).productname);

            //Console.WriteLine("\n ID: "+db.ObtenerProductoPorId(2).productid + "\t\t Name:" + db.ObtenerProductoPorId(2).productname);

        }
    }
}
