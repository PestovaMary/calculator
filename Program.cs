using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace calculator
{
    class Program
    {
        const int menuSize = 5;
        

        static void Main(string[] args)
        {
            int A, B;
            int menuIndex;

            do
            {
                Console.Clear();
                Console.WriteLine("Input A and B");
                A = int.Parse(Console.ReadLine());
                B = int.Parse(Console.ReadLine());
                Console.WriteLine("1. Addition");
                Console.WriteLine("2. Subtraction");
                Console.WriteLine("3. Multiplication");
                Console.WriteLine("4. Division");
                Console.WriteLine("5. Exit!");
                menuIndex = int.Parse(Console.ReadLine());
                switch (menuIndex)
                {
                    case 1:
                        //addition(A, B);
                        break;

                    case 2:
                        //subtraction(A, B);
                        break;

                    case 3:
                        //multiplication(A, B);
                        break;

                    case 4:
                        //division(A, B);
                        break;
                }

            } while (menuIndex != 5);
            Console.ReadKey();
        }
    }
}
