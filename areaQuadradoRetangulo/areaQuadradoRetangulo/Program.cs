using System;

namespace areaQuadradoRetangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            QuadradoRetangulo qr1 = new QuadradoRetangulo();

            Console.Write("Informe a Base do Quadrado Retangulo: ");
            qr1.BaseQuadrado = Convert.ToDouble(Console.ReadLine());

            Console.Write("Informe a Altura do Quadrado Retangulo: ");
            qr1.AlturaQuadrado = Convert.ToDouble(Console.ReadLine());

            qr1.ExibirAreaQuadradoRetangulo();
            qr1.ExibirTodosDadosQuadradoRetangulo();

            Console.ReadKey();
        }
    }
}
