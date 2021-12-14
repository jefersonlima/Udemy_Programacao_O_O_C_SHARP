using System;

enum mes { Janeiro, Fevereiro, Marco, Abril, Maio, junho, Julho, Agosto, Setembro, Outubro, Novembro, Dezembro}

namespace pooExemploENUM
{
    class Program
    {
        static void Main(string[] args)
        {
            mes mesAniversario;

            //Jeito 1
            mesAniversario = (mes)2;
            Console.WriteLine("O meu aniversario é no mês de " + mesAniversario);

            //Jeito 2
            mesAniversario = mes.Dezembro;
            Console.WriteLine("O meu aniversario é no mês de " + mesAniversario);

            Console.ReadKey();
        }
    }
}
