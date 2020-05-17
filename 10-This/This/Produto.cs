using System.Globalization;

namespace This {
    class Produto {

        public string Nome;
        public double Preco;
        public int Quantidade;

        /*Esse abaixo é o primeiro exemplo de this, porém não utilizado em C# pois como a regra é: 
         Atributo sempre iniciando com letra maiúscula e variável com letra minúscula, então não há chances de se 
         confundirem. */

        public Produto(string Nome) {
            this.Nome = Nome;                        
        }

        public Produto() { /* Nesse caso aqui, se você mandasse printar na tela, nome seria null, double 0.0 e int 0 */
            Quantidade = 10;
        }

        public Produto(string nome, double preco) : this() {
            Nome = nome;
            Preco = preco;
            /* Quantidade = 0; <- poderia ou não ter declarado, pois o C# já entenderia que valeria 0 */
        }

        public Produto(string nome, double preco, int quantidade) : this(nome, preco) {
            Quantidade = quantidade;
        }

        /*public Produto() {  /*Nesse caso aqui, se você mandasse printar na tela, nome seria null, double 0.0 e int 0
        } */


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
            return Nome
            + ", $ "
            + Preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + Quantidade
            + " unidades, Total: $ "
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
