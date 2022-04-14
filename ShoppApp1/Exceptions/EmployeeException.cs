using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppApp1.Exceptions
{
    public class EmployeeException : Exception
    {
        public EmployeeException(string message) : base(message)
        {
            Console.WriteLine(message);
        }

    }
}
