using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LenguajeLinq.ProjectionOperators;
using LenguajeLinq.RestrictionOperators;

namespace LenguajeLinq
{
    class Program
    {
        static void Main(string[] args)
        {

            // Ejemplos Lenguaje LINQ C# (Restriction Operators)
            LinqSamples samples = new LinqSamples();
            //samples.Linq1(); 
            //samples.Linq2(); 
            //samples.Linq3();
            //samples.Linq4();
            //samples.Linq5();

            // Ejemplos Lenguaje LINQ C# (Projection Operators)
            LinqSamples1 samples1 = new LinqSamples1();
            samples1.Linq6();
            samples1.Linq7();
            samples1.Linq8();
        }
    }
}
