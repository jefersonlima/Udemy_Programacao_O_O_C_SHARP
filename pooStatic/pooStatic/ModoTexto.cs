using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pooStatic
{
    public class ModoTexto
    {
        static public String log;
        static public String Ler()
        {
            return Console.ReadLine();
        }
        static public String Ler(String texto)
        {
            Console.Write(texto);
            return Console.ReadLine();
        }
        static public void Escrever(String texto)
        {
            Console.WriteLine(texto);
        }

        static public void Pausar()
        {
            Console.ReadKey();
        }
    }
}
