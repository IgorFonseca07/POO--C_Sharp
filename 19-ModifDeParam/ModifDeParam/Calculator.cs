using System;
using System.Security.Cryptography.X509Certificates;

namespace ModifDeParam {
    class Calculator {

        public int Soma(int n1, int n2) {
            return n1 + n2;
        }

        public int Soma(int n1, int n2, int n3) {
            return n1 + n2 + n3;
        }

        public int Soma(int n1, int n2, int n3, int n4) {
            return n1 + n2 + n3 + n4;
        }

        //Fazer o procedimento acima é super inviável, teria que colocar infinitos métodos


        //Modificador de Parâmetro Params:
        public static int Sum(params int[] numbers) {
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++) {
                sum += numbers[i];
            }
            return sum;
        }


        //Modificador de Parâmetro Ref:
        public static void Triple(ref int x) {
            x = x * 3;
        }
        

        //Modificador de Parâmetro Out:
        public static void Triplo(int x, out int y) {
            y = x * 3;
        }

        

    }
}
