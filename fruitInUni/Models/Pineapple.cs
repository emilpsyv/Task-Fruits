using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fruitInUni.Models
{
    internal class Pineapple : Fruit
    {

       public int vitaminE;
       public int vitaminD;




      






        public Pineapple(decimal price, string sort, int vitaminE, int vitaminD) : base(price, sort)
        {
            this.vitaminE = vitaminE;
            this.vitaminD = vitaminD;
        }

        public override void Taste()
        {
            Console.WriteLine("ananas dadi");
        }
    }
}
