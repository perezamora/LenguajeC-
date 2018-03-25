using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LenguajeLinq.RestrictionOperators;

namespace LenguajeLinq.ProjectionOperators
{
    class LinqSamples1
    {
        public void Linq6()
        {
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            var numsPlusOne =
                from n in numbers
                select n + 1;

            Console.WriteLine("Numbers + 1:");
            foreach (var i in numsPlusOne)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Convertir Inmutable (LINQ) a list y utilizar Lamda \n");
            numsPlusOne.ToList().ForEach((item) => Console.WriteLine(item));

            Console.ReadKey();
        }

        public void Linq7()
        {
            LinqSamples samples = new LinqSamples();
            List<Product> products = samples.GetProductList();

            var productNames =
                from p in products
                select p.ProductName;

            Console.WriteLine("Product Names:");
            foreach (var productName in productNames)
            {
                Console.WriteLine(productName);
            }

            Console.ReadKey();
        }

        public void Linq8()
        {
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            string[] strings = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            var textNums =
                from n in numbers
                select strings[n];

            Console.WriteLine("Number strings:");
            foreach (var s in textNums)
            {
                Console.WriteLine(s);
            }

            Console.ReadKey();
        }
    }
}
