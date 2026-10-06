using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello__World_
{
    internal class Message
    {
        private string _text;

        public Message(string text)
        { 
            this._text = text; 
        }
        public void Print()
        {
            Console.WriteLine(_text);
        }
    }
   
}   
