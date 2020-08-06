using Heranca_Interface_Interface.Devices;
using System;

namespace Heranca_Interface_Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Printer p = new Printer(1080);
            p.ProcessDoc("My letter");
            p.Print("My letter");

            Scanner s = new Scanner(2003);
            s.ProcessDoc("My E-mail");
            Console.WriteLine(s.Scan());

            ComboDevice cv = new ComboDevice(3921);
            cv.ProcessDoc("My dissertation");
            cv.Print("My dissertation");
            Console.WriteLine(cv.Scan());
        }
    }
}
