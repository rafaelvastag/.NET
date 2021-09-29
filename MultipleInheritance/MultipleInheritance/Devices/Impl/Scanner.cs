using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devices.Impl
{
    class Scanner : Device, IScanner
    {
        public override void ProcessDoc(string document)
        {
            Console.WriteLine("Scanner processing doc: " + document);
        }

        public string Scan()
        {
            return "Scanner scanning result";
        }
    }
}
