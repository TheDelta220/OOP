using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace OOPTest
{
    internal class Folder : Thing
    {
        private List<Thing> _contents;
        

        public Folder(string name) : base(name)
        {
            _contents = new List<Thing>();
            
        }

        public void Add (Thing toAdd)
        {
            _contents.Add(toAdd);
        }

        public override int Size()
        {
            int totalSize = 0;
            foreach(Thing file in _contents)
            {
                totalSize += file.Size(); 
            }
           return totalSize;
        }

        public override void Print()
        {
            int FolderSize = Size();
           Console.WriteLine($"Folder:{Name} contains {_contents} file totaling {FolderSize} bytes");
            foreach(Thing file in _contents)
            {
                file.Print();
            }
                
        }

        
    }
}
