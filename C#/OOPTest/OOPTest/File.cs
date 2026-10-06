using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace OOPTest
{
    internal class File : Thing
    {
        
        private string _extention;
        private int _size;

        public File(string name, string extention, int size) : base(name)
        {
           
            _extention = extention;
            _size = size;
        }

        public override int Size() 
        {
            return _size;
        }

        

        public override void Print() 
        { 
            Console.WriteLine(Name + "\n" + _extention + "\n" + _size + "bytes");
        }

       
    }
}
