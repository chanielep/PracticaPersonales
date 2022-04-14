using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppApp1.entidades
{
    public class Empleado : Entity
    {
        public string lastname { get; set; }
        public string firstname { get; set; }
        public string title { get; set; }
        public string? titleofcourtesy { get; set; }
        public DateTime birthdate { get; set; }
        public DateTime hiredate { get; set; }
        public string addrees { get; set; }
        public string city { get; set; }
        public string? region { get; set; }
        public string? postalcode { get; set; }
        public string phone { get; set; }
        public int? megrid { get; set; }
        public int empid { get; set; }
    }
}
