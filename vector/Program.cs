namespace Vector {
    class Program {
        static void Main(string[] args) {

            Studant[] rooms = new Studant[10];

            Console.WriteLine("Digite as informações solicitadas para a conclusão do pensionato!");
            int i = 0;
            while (i <= 10) {
                Console.WriteLine("Digite o nome:");
                string name = Console.ReadLine();

                if (string.IsNullOrEmpty(name))
                    break;

                Console.WriteLine("Digite o email:");
                string email = Console.ReadLine();

                Console.WriteLine("Digite o quarto:");
                string room = Console.ReadLine();

                int roomNumber = int.Parse(room);
                if (roomNumber >= 10) {
                    Console.WriteLine("Só possuímos quartos de 0 a 9. Por favor, digite um novo valor:");
                    roomNumber = int.Parse(Console.ReadLine());
                }

                if(rooms[roomNumber] != null) {
                    Console.WriteLine("Quarto já ocupado. Temos apenas os quartos disponíveis:");

                    List<int> freeRooms = Enumerable.Range(0, rooms.Length)
                                                .Where(f => rooms[f] == null)
                                                .ToList();

                    freeRooms.ForEach(f => Console.WriteLine(f));

                    Console.WriteLine("Por favor, digite um novo quarto:");
                    roomNumber = int.Parse(Console.ReadLine());
                }

                Studant studant = new Studant {Name = name, Email = email, Room = roomNumber.ToString()};

                rooms[roomNumber] = studant;
            }

            Console.WriteLine("Relatório:");
            foreach( var room in rooms) {
                if(room == null)
                    continue;

                Console.WriteLine("Name: " + room.Name + ", Email: " + room.Email + ", Room: " + room.Room);
            }
        }
    }
}