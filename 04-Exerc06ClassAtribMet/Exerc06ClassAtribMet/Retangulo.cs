using System;

namespace Exerc06ClassAtribMet {
    class Retangulo {

        public double Largura;
        public double Altura;

        public double Area() {
            return Largura * Altura;
        }

        public double Perimetro() {
            return (2 * Largura) + (2 * Altura);
        }

        public double Diagonal() {
            return Math.Sqrt(Math.Pow(Largura, 2.0) + Math.Pow(Altura, 2.0));
        }

    }
}
