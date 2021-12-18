using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pooPerguntaEResposta
{
    class Program
    {
        static void Main(string[] args)
        {
            Pergunta p = new Pergunta();

            PerguntaPlus pp = new PerguntaPlus();
            pp.Texto = "Quem vai se tornar um ótimo programador?";
            pp.Resposta = "Jeferson Lima de Souza";
            pp.Dica = "é quem criou esse programa!";
            //pp.test1 = "Test de herança 1 public";

            Console.WriteLine("Responda a pergunta!");
            Console.WriteLine("Pergunta: " + pp.Texto);
            Console.WriteLine("Dica " + pp.Dica);
            Console.Write("Resposta: " );
            String resposta = Console.ReadLine();

            if (resposta.ToUpper() == pp.Resposta.ToUpper())
            {
                Console.WriteLine("Você acertou!! Parabens!!!");
            }
            else
            {
                Console.WriteLine("Você errou! a resposta correta é: " + pp.Resposta);
            }

            Console.ReadKey();
        }
    }
}
