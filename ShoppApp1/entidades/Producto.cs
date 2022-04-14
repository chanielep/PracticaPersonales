using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppApp1.entidades
{
  public  class Producto : Entity
    {
        public int productid { get; set; }
        public string productname { get; set; }
        public int  supplierid { get; set; }
        public int categoryid { get; set; }
        public double unitprice { get; set; }
        public bool discontinued { get; set; }
    }
}
