using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fruitInUni.Models
{
    internal class Apple : Fruit
    {
       public int vitaminA;
       public int vitaminB;





        public Apple(decimal price, string sort, int vitaminA, int vitaminB ) : base(price, sort)
        {
            this.vitaminA = vitaminA;
            this.vitaminB = vitaminB;

        }

        public override void Taste()
        {
            Console.WriteLine("Alma dai verir");
        }
    }
}
