using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pooStatic
{
    class Program
    {
        static void Main(string[] args)
        {
            Ferramenta f1, f2;
            f1 = new Ferramenta("Martelo", 100);
            f1.ExibirDados();

            f1 = new Ferramenta("Martelete", 100);
            f1.ExibirDados();

            Console.ReadKey();

            //string nome = "Jeferson Lima";
            //ModoTexto.log = nome;
            //ModoTexto.Escrever("Olá " + ModoTexto.log);
            //ModoTexto.Pausar();

            //string nome;
            ////ModoTexto.Escrever("Qual é o seu nome?");
            ////nome = ModoTexto.Ler();
            //nome = ModoTexto.Ler("Qual é o seu nome?");
            //ModoTexto.Escrever("Olá " + nome);
            //ModoTexto.Pausar();

        }
    }
}
