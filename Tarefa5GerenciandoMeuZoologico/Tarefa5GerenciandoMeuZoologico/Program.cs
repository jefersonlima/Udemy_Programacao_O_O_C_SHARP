using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarefa5GerenciandoMeuZoologico
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Descrição da Tarefa
            //Implemente um programa que deverá informar quantos animais são carnívoros e quantos animais são herbívoros de 10 animais 
            //informados pelo usuário. O usuário deverá informar a espécie(exemplos: leão, jacaré, tucano, etc), peso(exemplos: 30, 90.55, 100)
            //e tipo de alimentação(exemplos: carnívoro, herbívoro) do animal.

            //IMPORTANTE
            //É obrigatório criar / utilizar uma classe quer herde a classe Animal para representar um animal em seu programa. 
            //Você deverá implementar nessa classe todas as características / métodos que não estiverem presentes na classe base Animal.
            //A classe também deverá possuir um método que exiba todos os dados do animal.
            #endregion

            #region Instanciando Listas
            List<Carnivoro> c = new List<Carnivoro>();
            List<Herbivoro> h = new List<Herbivoro>();
            #endregion

            #region Instanciando Objetos
            Carnivoro carnivoro;
            Herbivoro herbivoro;
            #endregion

            #region Coletando Dados dos animais
            Console.WriteLine("Informe 10 animais!");
            int i = 0;
            while ( i < 10 )
            {
                Console.Write("Informe a espécie do animal: ");
                String especie = Console.ReadLine();
                Console.Write("Informe o peso do animal: ");
                double peso = Convert.ToDouble(Console.ReadLine());
                Console.Write("Informe o tipo do animal (0 - Carnivoro 1 - Herbivoro): ");
                int tipoAnimal = Convert.ToInt32(Console.ReadLine());
                if (tipoAnimal == 0)
                {
                    carnivoro = new Carnivoro( especie, peso);
                    c.Add(carnivoro);
                }
                else if( tipoAnimal == 1 ){
                    herbivoro = new Herbivoro(especie, peso);
                    h.Add(herbivoro);
                }
                i++;
            }
            #endregion

            #region Verificando a quantidade de cada tipo de animal
            Console.WriteLine("quantidade de Carnivoros: " + c.Count());
            Console.WriteLine("quantidade de Herbivoros: " + h.Count());
            #endregion

            #region Imprimimindo todos Animais
            i = 0;
            while ( i < c.Count())
            {
                if (i == 0)
                {
                    Console.WriteLine("Carnivoros: ");
                }
                Console.WriteLine(c[i].ToString());
                i++;
            }
            i = 0;
            while (i < h.Count())
            {
                if (i == 0)
                {
                    Console.WriteLine("Herbivoros: ");
                }
                Console.WriteLine(h[i].ToString());
                i++;
            }
            #endregion

            Console.ReadKey();
        }
    }
}
