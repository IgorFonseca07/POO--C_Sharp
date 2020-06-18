using System;
using Heranca.Entities;

namespace Heranca
{
    class Program
    {
        static void Main(string[] args)
        {
            BusinessAccount businessAccount = new BusinessAccount(452, "Igor", 566.23, 1000.00);

            Console.WriteLine(businessAccount.Balance);   //se estivesse protected get, não seria possível visualizar
                                                          //protected apenas permite a leitura em subclasses
            businessAccount.Balance = 700.00;   //protected apenas permite a edição em subclasses
        }
    }
}
