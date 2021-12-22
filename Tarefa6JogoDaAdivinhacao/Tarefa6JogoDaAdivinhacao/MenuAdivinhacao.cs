using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarefa6JogoDaAdivinhacao
{
    public class MenuAdivinhacao
    {
        public int MenuJogo()
        {
            Console.WriteLine("Jogo de adivinhação");
            Console.WriteLine("0 - Sair do jogo");
            Console.WriteLine("1 - Listar todas perguntas!");
            Console.WriteLine("2 - Escolher e responder!");
            Console.WriteLine("3 - Responder uma pergunta aleatória!");
            Console.WriteLine("Escolha uma opção: ");
            int resp = Convert.ToInt32(Console.ReadLine());

            return resp;
        }
    }
}
