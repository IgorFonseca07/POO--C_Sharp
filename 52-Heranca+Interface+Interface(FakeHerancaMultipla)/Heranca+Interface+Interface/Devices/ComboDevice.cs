using System;

namespace Heranca_Interface_Interface.Devices
{
    class ComboDevice : Device, IPrinter, IScanner
    {
        public ComboDevice(int serialNumber) : base(serialNumber)
        {
        }

        public void Print(string document)
        {
            Console.WriteLine("ComboDevice print " + document);
        }

        public override void ProcessDoc(string document)
        {
            Console.WriteLine("ComboDevice processing " + document);
        }

        public string Scan()
        {
            return "Combodevice scan result";
        }
    }
}
