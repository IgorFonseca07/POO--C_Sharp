using System;

namespace Heranca_Interface_Interface.Devices
{
    class Printer : Device, IPrinter
    {
        public Printer (int serialNumber) : base(serialNumber)
        {
        }

        public override void ProcessDoc(string document)
        {
            Console.WriteLine("Printer processing: " + document);
        }

        public void Print(string document)
        {
            Console.WriteLine("Printer print: " + document);
        }
    }
}
