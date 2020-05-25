namespace Exerc09 {
    class Rooms {

        public string Name { get; set; }
        public string Email { get; set; }


        public override string ToString() {
            return Name
                + ", "
                + Email;               
        }

    }
}
