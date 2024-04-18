using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fruitInUni.Models
{
     abstract class Fruit
    {
        public decimal _price;
        public string _sort;



       




        public Fruit(decimal price,string sort)
        {
            _price= price;
            _sort= sort;
        }
        
        
        
        
        
        
        
        public abstract void Taste();
        






    }
}
