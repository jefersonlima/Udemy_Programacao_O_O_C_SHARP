﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pooMensagem
{
    public class Message
    {
        //private String TextMessage;

        //public void ShowMessage()
        //{
        //    Console.WriteLine(this.TextMessage);
        //}

        //public String getTextMessage()
        //{
        //    return this.TextMessage;
        //}

        //public void setTextMessage(String valor)
        //{
        //    this.TextMessage = valor.ToUpper();
        //}

        private String textoMensagem;

        public String TextoMensagem
        {
            get
            {
                return this.textoMensagem;
            }

            set
            {
                this.textoMensagem = value.ToUpper();
            }
        }

        public void ShowMessage()
        {
            Console.WriteLine(this.textoMensagem);
        }


    }
}
