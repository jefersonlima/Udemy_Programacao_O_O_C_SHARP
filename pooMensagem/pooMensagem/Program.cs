using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pooMensagem
{
    class Program
    {
        static void Main(string[] args)
        {
            Message msg1, msg2;
            msg1 = new Message();
            //msg1.TextMessage = "Hello World";
            //msg1.setTextMessage("Hello World");
            //Console.WriteLine(msg1.getTextMessage().ToLower());
            //msg1.ShowMessage();

            msg1.TextoMensagem = "Hello World";
            msg1.ShowMessage();

            //msg2 = new Message();
            //msg2.TextMessage = "Second Object";
            //msg2.ShowMessage();

            Console.ReadKey();
        }
    }
}
