using System.Globalization;

namespace Exerc08 {
    class Conta {

        public int NumeroConta { get; private set; }
        public string TitularConta { get; private set; }
        public double ValorSaldoAtual { get; private set; }


        public Conta(int numeroconta, string titularconta) {
            NumeroConta = numeroconta;
            TitularConta = titularconta;
        }

        public Conta(int numeroconta, string titularconta, double valordepositoinicial) : this(numeroconta, titularconta) {
            ValorSaldoAtual = valordepositoinicial;
        }


        public void Deposito(double deposito) {
            ValorSaldoAtual += deposito;
        }

        public void Saque(double saque) {
            ValorSaldoAtual = (ValorSaldoAtual - saque) - 5.00;
        }

        public override string ToString() {
            return "Conta "
                + NumeroConta
                + ", Titular: "
                + TitularConta
                + ", Saldo: $ "
                + ValorSaldoAtual.ToString("F2", CultureInfo.InvariantCulture);
        }


    }
}
