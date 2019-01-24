using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryToDie
{
    class Pant : Products
    {
        public override double CalcDefaultCost()
        {
            double price = 0.0;
            if (Size == "S")
            {
                price = 10;
            }

            else if (Size == "M")
            {
                price = 20;
            }

            else if (Size == "L")
            {
                price = 30;
            }

            return price;
        }
    }
}
