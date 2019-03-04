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

        static void addA(int A)
        {
            Console.Clear();
            Console.WriteLine("Input A");
            A = int.Parse(Console.ReadLine());
        }

        static void addB(int B)
        {
            Console.Clear();
            Console.WriteLine("Input B");
            B = int.Parse(Console.ReadLine());
            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            int A = 0, B = 0;
            int menuIndex;

            do
            {
                Console.Clear();

                Console.WriteLine("1. Add A");
                Console.WriteLine("2. Add B");
                Console.WriteLine("3. Addition");
                Console.WriteLine("4. Subtraction");
                Console.WriteLine("5. Multiplication");
                Console.WriteLine("6. Division");
                Console.WriteLine("7. Exit!");
                menuIndex = int.Parse(Console.ReadLine());
                switch (menuIndex)
                {
                    case 1:
                        addA(A);
                        break;

                    case 2:
                        addB(B);
                        break;

                    case 3:
                        //addition(A, B);
                        break;

                    case 4:
                        //subtraction(A, B);
                        break;

                    case 5:
                        //multiplication(A, B);
                        break;

                    case 6:
                        //division(A, B);
                        break;
                }

            } while (menuIndex != 7);
            Console.ReadKey();
        }
    }
}