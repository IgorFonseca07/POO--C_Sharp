using System;
using System.Collections.Generic;
using System.Text;

namespace Heranca.Entities
{
    class SavingsAccountPlus : SavingsAccount
    {
        // Como selei a classe SavingsAccount, nenhuma classe pode herdar ela

        public override void Withdraw(double amount)    // Como já foi selado o primeiro override, não se pode
        {                                               //  mais sobrepor em nenhuma subclasse.

        }
    }
}
