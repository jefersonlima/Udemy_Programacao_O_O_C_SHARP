using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pooPolimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            Quadrado q1 = new Quadrado(2, 2);
            Console.WriteLine(q1.FormaGeometrica);
            Console.WriteLine(q1.CalcularArea());

            Triangulo t1 = new Triangulo(2, 2);
            Console.WriteLine(t1.FormaGeometrica);
            Console.WriteLine(t1.CalcularArea());
            
            
            Console.ReadKey();
        }
    }
}
