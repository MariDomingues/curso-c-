namespace Vector {
    internal class Studant {

        public string Name { get; set; }
        public string Email { get; set; }
        public string Room { get; set; }

        public override string ToString() {
            return "Name: " + this.Name + ", Email: " + this.Email + ", Room: " + this.Room;
        }
    }
}
