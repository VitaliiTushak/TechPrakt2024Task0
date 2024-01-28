using System.Text;

namespace ConsoleApp
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
        
            var firstValue = GetNumber("Введіть перше ціле число: ");
            var secondValue = GetNumber("Введіть друге ціле число: ");

            var sum = AddOperation(firstValue, secondValue);

            Console.WriteLine($"Сума двох чисел: {sum}\n");
        }

        private static int GetNumber(string query)
        {
            int value;
            bool isValid;
            do
            {
                Console.Write(query);
                isValid = int.TryParse(Console.ReadLine(), out value);
                if (!isValid)
                {
                    Console.WriteLine("Введено некоректне значення. Будь ласка, спробуйте ще раз\n");
                }

            } while (!isValid);
            return value;
        }
    
        private static int AddOperation(int a, int b)
        {
            return a + b;
        }
    } 
}