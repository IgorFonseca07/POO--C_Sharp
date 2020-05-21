using System.Globalization;

namespace Prop {
    class Produto {

        private string _nome;

        /*Auto Propertie abaixo, é possível pois não há lógicas particulares para ambos. */
        public double Preco { get; private set; }
        public int Quantidade { get; private set; }


        public Produto() {
        }

        public Produto(string nome, double preco, int quantidade) {
            _nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        /* Propertie: maior facilidade para acesso dos dados */
        /* Propertie abaixo para não usar Get e Set no Program, deixar a sintaxe mais amigável, intuitiva */

        /* Propertie abaixo possui uma condição, então não é possível o auto propertie dela */
        public string Nome {
            get { return _nome; }
            set {
                if (value != null && value.Length > 1) {
                    _nome = value;
                }
            }
        }

        

        public double ValorTotalEmEstoque() {
            return Preco * Quantidade;
        }
        public void AdicionarProdutos(int quantidade) {
            Quantidade += quantidade;
        }
        public void RemoverProdutos(int quantidade) {
            Quantidade -= quantidade;
        }
        public override string ToString() {
            return _nome
            + ", $ "
            + Preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + Quantidade
            + " unidades, Total: $ "
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}