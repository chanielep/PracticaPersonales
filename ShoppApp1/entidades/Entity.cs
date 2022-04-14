using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppApp1.entidades
{
   public class Entity
    { public DateTime creation_date { get; set; }
        public int creation_user { get; set; }
        public DateTime? modify_date { get; set; }
        public int? modify_user { get; set; }
        public DateTime? delete_user { get; set; }
        public bool deleted { get; set; }
    }
}
