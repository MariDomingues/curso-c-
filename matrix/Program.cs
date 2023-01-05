using System.Drawing;
using System.Runtime.CompilerServices;

namespace Matrix {

    class Program {
        static void Main(string[] args) {
            exercise1();
            exercise2();
        }

        private static void exercise1() {
            Console.WriteLine("Informe o tamanho da matriz desejada: ");
            int size = Convert.ToInt16(Console.ReadLine());

            int[,] matrix = new int[size, size];

            Console.WriteLine("Agora, informe os números da matriz:");
            for(int i = 0; i < size; i++) {
                for(int j = 0; j < size; j++) {

                    Console.WriteLine($"\nMatriz[{i}, {j}]: ");
                    int number = Convert.ToInt16(Console.ReadLine());

                    matrix[i, j] = number;
                }
            }

            string main = "";
            string negative = "";

            Console.WriteLine($"\nMatriz: ");
            for(int i = 0; i < size; i++) {
                for(int j = 0; j < size; j++) {

                    int value = matrix[i, j];

                    Console.Write($"{value} ");

                    if(i == j) {
                        main += value.ToString();

                        if(!isFinal(i, j, size))
                            main += ", ";
                    }

                    if(value < 0) {
                        negative += value.ToString();

                        if(!isFinal(i, j, size))
                            negative += ", ";
                    }
                }

                Console.WriteLine("");
            }

            Console.WriteLine($"\nOs números da diagonal principal da matriz são: {main}");
            Console.WriteLine($"Os números negativos da matriz são: {negative}");
        }

        static Boolean isFinal(int i, int j, int size) {
            return i == size - 1 && j == size - 1;
        }

        private static void exercise2() {
            Console.WriteLine("Informe o tamanho da coluna desejada: ");
            int column = Convert.ToInt16(Console.ReadLine());
            
            Console.WriteLine("Informe o tamanho da linha desejada: ");
            int line = Convert.ToInt16(Console.ReadLine());

            int[,] matrix = new int[column, line];

            Console.WriteLine("Agora, informe os números da matriz:");
            for(int i = 0; i < column; i++) {
                for(int j = 0; j < line; j++) {

                    Console.WriteLine($"\nMatriz[{i}, {j}]: ");
                    matrix[i, j] = Convert.ToInt16(Console.ReadLine());
                }
            }

            Console.WriteLine($"\nMatriz: ");
            for(int i = 0; i < column; i++) {
                for(int j = 0; j < line; j++) {
                    Console.Write($"{matrix[i, j]} ");
                }
                Console.WriteLine("");
            }

            Console.WriteLine("Agora, informe o número que quer encontrar na matriz:");
            int number = Convert.ToInt16(Console.ReadLine());

            for(int i = 0; i < column; i++) {
                for(int j = 0; j < line; j++) {

                    int value = matrix[i, j];

                    if(value == number) {

                        Console.WriteLine($"Position: [{i}, {j}]");

                        if (j > 0)
                            Console.WriteLine($"Left: {matrix[i, j - 1]}");

                        if(j < line)
                            Console.WriteLine($"Right: {matrix[i, j + 1]}");

                        if (i > 0)
                            Console.WriteLine($"Up: {matrix[i - 1, j]}");

                        if(i < column)
                            Console.WriteLine($"Down: {matrix[i + 1, j]}");
                    }
                }

            }
        }
    }
}