using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace controleDeAnimais
{
    class Program
    {
        static void Main(string[] args)
        {
            int countCachorro = 0, countGato = 0, countPeixe = 0;
            int tipo = 0;
            Animais animal1 = new Animais();
            //Animais animal2 = new Animais();
            //Animais animal3 = new Animais();
            //Animais animal4 = new Animais();
            //Animais animal5 = new Animais();

            Console.WriteLine("Informe o Nome do Animal: ");
            //String nomeAnimal1 = Console.ReadLine();
            animal1.Nome = Console.ReadLine();
            Console.WriteLine("Informe o Tipo do Animal (Cachorro - 0, Gato - 1 ou Peixe - 2): ");
            //String tipoAnimal1 = Console.ReadLine();
            try
            {
                tipo = Convert.ToInt32(Console.ReadLine());
                if (tipo < 0) tipo = 2;
                if (tipo > 2) tipo = 2;
            }
            catch (Exception)
            {
                tipo = 2;
            }
             animal1.Tipo = (TipoAnimal)tipo;

            //Animais animal1 = new Animais(nomeAnimal1, tipoAnimal1);
            if (animal1.Tipo == TipoAnimal.Cachorro) countCachorro++;
            if (animal1.Tipo == TipoAnimal.Gato) countGato++;
            if (animal1.Tipo == TipoAnimal.Peixe) countPeixe++;
            //Console.WriteLine(animal1.Nome + animal1.Tipo);

            //Console.WriteLine("Informe o Nome do Animal: ");
            ////String nomeAnimal2 = Console.ReadLine();
            //animal2.Nome = Console.ReadLine();
            //Console.WriteLine("Informe o Tipo do Animal: ");
            ////String tipoAnimal2 = Console.ReadLine();
            //animal2.Tipo = Console.ReadLine();
            ////Animais animal2 = new Animais(nomeAnimal2, tipoAnimal2);
            //if (animal2.Tipo == "Cachorro") countCachorro++;
            //if (animal2.Tipo == "Gato") countGato++;
            //if (animal2.Tipo == "Peixe") countPeixe++;
            ////Console.WriteLine(animal2.Nome, animal2.Tipo);

            //Console.WriteLine("Informe o Nome do Animal: ");
            ////String nomeAnimal3 = Console.ReadLine();
            //animal3.Nome = Console.ReadLine();
            //Console.WriteLine("Informe o Tipo do Animal: ");
            ////String tipoAnimal3 = Console.ReadLine();
            //animal3.Tipo = Console.ReadLine();
            ////Animais animal3 = new Animais(nomeAnimal3, tipoAnimal3);
            //if (animal3.Tipo == "Cachorro") countCachorro++;
            //if (animal3.Tipo == "Gato") countGato++;
            //if (animal3.Tipo == "Peixe") countPeixe++;

            //Console.WriteLine("Informe o Nome do Animal: ");
            ////String nomeAnimal4 = Console.ReadLine();
            //animal4.Nome = Console.ReadLine();
            //Console.WriteLine("Informe o Tipo do Animal: ");
            ////String tipoAnimal4 = Console.ReadLine();
            //animal4.Tipo = Console.ReadLine();
            ////Animais animal4 = new Animais(nomeAnimal4, tipoAnimal4);
            //if (animal4.Tipo == "Cachorro") countCachorro++;
            //if (animal4.Tipo == "Gato") countGato++;
            //if (animal4.Tipo == "Peixe") countPeixe++;

            //Console.WriteLine("Informe o Nome do Animal: ");
            ////String nomeAnimal5 = Console.ReadLine();
            //animal5.Nome = Console.ReadLine();
            //Console.WriteLine("Informe o Tipo do Animal: ");
            ////String tipoAnimal5 = Console.ReadLine();
            //animal5.Tipo = Console.ReadLine();
            ////Animais animal5 = new Animais(nomeAnimal5, tipoAnimal5);
            //if (animal5.Tipo == "Cachorro") countCachorro++;
            //if (animal5.Tipo == "Gato") countGato++;
            //if (animal5.Tipo == "Peixe") countPeixe++;

            Console.WriteLine("Total de Animais!");
            Console.WriteLine("Quantidade de Cachorros: " + countCachorro);
            Console.WriteLine("Quantidade de Gatos: " + countGato);
            Console.WriteLine("Quantidade de Peixes: " + countPeixe);

            Console.ReadKey();

        }
    }
}
