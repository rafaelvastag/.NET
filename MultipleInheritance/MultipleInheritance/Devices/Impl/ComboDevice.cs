using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devices.Impl
{
    class ComboDevice : Device, IScanner, IPrinter
    {
        public void Print(string document)
        {
            Console.WriteLine("ComboDevice printing doc: " + document);
        }

        public override void ProcessDoc(string document)
        {
            Console.WriteLine("ComboDevice processing doc: " + document);
        }

        public string Scan()
        {
            return "ComboDevice scanning with Serial: " + SerialNumber;
        }
    }
}
