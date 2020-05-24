namespace TiposRefer_TiposValor {
    struct Point {

        public double X;
        public double Y;

        public Point(double x, double y) {
            X = x;
            Y = y;
        }
        public override string ToString() {
            return "( " + X + ", " + Y + " )";
        }

    }
}
