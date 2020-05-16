namespace Exerc07MemEst {
    class ConversorDeMoeda {

        public static double PagarEmReais(double cot, double com) {            
            return (com * cot) + (cot * (com * 0.06));
        }

    }
}
