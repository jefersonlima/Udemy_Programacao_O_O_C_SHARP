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
            //string nome;
            ////ModoTexto.Escrever("Qual é o seu nome?");
            ////nome = ModoTexto.Ler();
            //nome = ModoTexto.Ler("Qual é o seu nome?");
            //ModoTexto.Escrever("Olá " + nome);
            //ModoTexto.Pausar();

            string nome = "Jeferson Lima";
            ModoTexto.log = nome;
            ModoTexto.Escrever("Olá " + ModoTexto.log);
            ModoTexto.Pausar();
        }
    }
}
