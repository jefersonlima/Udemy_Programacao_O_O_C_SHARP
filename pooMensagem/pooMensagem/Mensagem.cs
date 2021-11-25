using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pooMensagem
{
    public class Message
    {
        public String TextMessage;

        public void ShowMessage()
        {
            Console.WriteLine(this.TextMessage);
        }
    }
}
