using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryToDie
{
   public abstract class Products
    {
         
        public string Name { get; set; }
        public string Size { get; set; }

        public abstract double CalcDefaultCost();
    }
}
