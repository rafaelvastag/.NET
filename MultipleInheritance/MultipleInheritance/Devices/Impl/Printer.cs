using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devices.Impl
{
    class Printer : Device, IPrinter
    {
        public void Print(string document)
        {
            Console.WriteLine("Printer processing doc: " + document);
        }

        public override void ProcessDoc(string document)
        {
            Console.WriteLine("Printer printing doc: " + document);
        }
    }
}
