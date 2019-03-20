using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayofFruit
{
    /// <summary>
    /// Fruit Array
    /// </summary>
    class Program
    {
        //
        // App: Array of Fruit
        // Author: Witte
        //

        public enum fruit
        {
            none,
            banana,
            apple,
            orange,
            strawberry
           
        }
        
        
        static void Main(string[] args)
        {
            fruit[] fruits = new fruit[4];
            string userResponse;

            for (int index = 0; index < 4; index++)
            {
                Console.Write($"Enter Fruit #{index + 1}:");
                userResponse = Console.ReadLine();
                Enum.TryParse(userResponse,out fruits[index]);
            }

            Console.WriteLine();

            foreach (fruit Fruit in fruits)
            {
                Console.WriteLine(fruits);
            }

            Console.ReadKey();
        }
    }
}
