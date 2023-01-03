using System.Xml.Linq;

namespace Lists {
    class Program {
        static void Main(string[] args) {

            List<Employee> employees = new List<Employee>();

            Console.WriteLine("Digite as informações solicitadas para a conclusão do cadastro!");
            int index = 0;

            while(true) {
                Console.WriteLine("\nDigite o nome: ");
                string name = Console.ReadLine();

                if (string.IsNullOrEmpty(name))
                    break;

                Console.WriteLine("Digite o salário:");
                decimal pay = Convert.ToDecimal(Console.ReadLine());

                Employee employee = new Employee { Id=index, Name=name };
                employee.addPay(pay);

                employees.Add(employee);

                Console.WriteLine($"Funcionário cadastrado com sucesso! \nId: {index}, Nome: {name}, Salário: {pay}");

                index++;
            }

            Console.WriteLine("Deseja reajustar o salário de algum funcionário? (y/n) ");
            string answer = Console.ReadLine();

            if (answer.ToUpper().Equals("Y")) {
                while(true) {
                    Console.WriteLine("\nQual o id do funcionário que receberá o ajuste? ");
                    String idString = Console.ReadLine();

                    if(string.IsNullOrEmpty(idString))
                        break;

                    int id = Convert.ToInt32(idString);

                    Console.WriteLine("Quantos % será o reajuste? ");
                    decimal readjustment = Convert.ToDecimal(Console.ReadLine());

                    try {
                        employees.Single(e => e.Id == id).additionPay(readjustment);

                    } catch {
                        Console.WriteLine("Nenhum funcionário localizado!");
                        break;
                    }
                }
            }

            Console.WriteLine("Relatório:");
            employees.ForEach(e => {
                Console.WriteLine($"\nId: {e.Id}, Nome: {e.Name}, Salário: {e.Pay}");
            });
        }
    }
}