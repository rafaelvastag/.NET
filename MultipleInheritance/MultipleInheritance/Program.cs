using Devices;
using Devices.Impl;
using System;

namespace MultipleInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            ComboDevice combo = new ComboDevice() { SerialNumber = 3921 };

            combo.ProcessDoc("My dissertation");
            combo.Print("My dissertation");
            Console.WriteLine(combo.Scan());
        }
    }
}
