using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fruitInUni.Models
{
    internal class Orange : Fruit
    {

       
       public int vitaminC;







        public Orange(decimal price, string sort,int vitaminC ) : base(price, sort)
        {
            this.vitaminC = vitaminC;
        }

        public override void Taste()
        {
            Console.WriteLine("apelsin dadi");
        }
    }
}
