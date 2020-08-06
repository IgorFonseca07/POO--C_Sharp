using System;

namespace Heranca_Interface_Interface.Devices
{
    class Scanner : Device, IScanner
    {
        public Scanner(int serialNumber) : base(serialNumber)
        {
        }

        public override void ProcessDoc(string document)
        {
            Console.WriteLine("Scanner processing: " + document);
        }

        public string Scan()
        {
            return "Scanner scan result";
        }
    }
}
