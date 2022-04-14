using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppApp1.entidades
{
    public class Cliente : Entity
    {
        public int custid { get; set; }
        public string companyname { get; set; }
        public string contctname { get; set;  }
        public string address { get; set; }
        public string email { get; set; }
        public string city { get; set; }
        public string? region { get; set;  }
        public string? postalcode { get; set; }
        public string country { get; set; }
        public string phone { get; set; }
        public string? fax { get; set; }

    }
}
