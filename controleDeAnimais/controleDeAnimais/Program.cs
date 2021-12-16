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
            //int countCachorro = 0, countGato = 0, countPeixe = 0;
            //int tipo = 0;
            //Animais animal1 = new Animais();
            ////Animais animal2 = new Animais();
            ////Animais animal3 = new Animais();
            ////Animais animal4 = new Animais();
            ////Animais animal5 = new Animais();

            //Console.WriteLine("Informe o Nome do Animal: ");
            ////String nomeAnimal1 = Console.ReadLine();
            //animal1.Nome = Console.ReadLine();
            //Console.WriteLine("Informe o Tipo do Animal (Cachorro - 0, Gato - 1 ou Peixe - 2): ");
            ////String tipoAnimal1 = Console.ReadLine();
            //try
            //{
            //    tipo = Convert.ToInt32(Console.ReadLine());
            //    if (tipo < 0) tipo = 2;
            //    if (tipo > 2) tipo = 2;
            //}
            //catch (Exception)
            //{
            //    tipo = 2;
            //}
            // animal1.Tipo = (TipoAnimal)tipo;

            ////Animais animal1 = new Animais(nomeAnimal1, tipoAnimal1);
            //if (animal1.Tipo == TipoAnimal.Cachorro) countCachorro++;
            //if (animal1.Tipo == TipoAnimal.Gato) countGato++;
            //if (animal1.Tipo == TipoAnimal.Peixe) countPeixe++;
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

            int countCachorro = 0, countGato = 0, countPeixe = 0;
            int tl = 0;
            int tipo = 0;

            //instancia um obj do tipo animal
            Animais animal;


            //Leitura da quantidade de animais
            try
            {
                Console.Write("Quantos animais deseja informar (Máximo 20): ");
                tl = Convert.ToInt32(Console.ReadLine());
                if (tl > 20) tl = 20;
                if (tl < 0) tl = 0;
            }
            catch (Exception)
            {

                tl = 0;
            }
            //instancia um array do tipo animal onde é possivel colocar 20 objetos animais
            Animais[] animais = new Animais[tl];
            for (int i = 0; i < tl; i++)
            {
                //Criando um objeto
                animal = new Animais();

                //Leitura do animal
                Console.WriteLine("Informe o Nome do Animal: ");
                animal.Nome = Console.ReadLine();
                Console.WriteLine("Informe o Tipo do Animal (Cachorro - 0, Gato - 1 ou Peixe - 2): ");
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
                animal.Tipo = (TipoAnimal)tipo;

                //Contagem de animais
                if (animal.Tipo == TipoAnimal.Cachorro) countCachorro++;
                if (animal.Tipo == TipoAnimal.Gato) countGato++;
                if (animal.Tipo == TipoAnimal.Peixe) countPeixe++;

                //Armazena o animal no Array animais
                animais[i] = animal;
            }

            Console.WriteLine("Total de Animais!");
            Console.WriteLine("Quantidade de Cachorros: " + countCachorro);
            Console.WriteLine("Quantidade de Gatos: " + countGato);
            Console.WriteLine("Quantidade de Peixes: " + countPeixe);

            //imprime todos elementos do array
            for (int i = 0; i < animais.Length; i++)
            {
                Console.WriteLine("Animal " + Convert.ToInt32(i+1) + " Nome: " + animais[i].Nome + " Tipo: " + animais[i].Tipo);
            }
            Console.ReadKey();

        }
    }
}
