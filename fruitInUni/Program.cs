using fruitInUni.Models;

namespace fruitInUni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Apple apple = new Apple(1, "ciqanka", 4, 2);
            Orange orange = new Orange(21, "apelsin", 3);
            Pineapple pineapple = new Pineapple(1, "afrika ananasi", 4, 2);

            Fruit[] Basket = { apple, orange, pineapple };
            foreach (var fruit in Basket)
            {
                //if (fruit is Apple app)
                //{
                //    Console.WriteLine(app.vitaminA);
                //}
                //else if (fruit is Orange or)
                //{
                //    Console.WriteLine(or.vitaminC);

                //}
                //else if (fruit is Pineapple pin)
                //{
                //    pin.Taste();
                //}
                var type = fruit.GetType();
                Console.WriteLine(type.Name);
                foreach (var item in type.GetFields())
                {
                    Console.WriteLine(item.GetValue(fruit));
                }
            }

            

        }
    }
}