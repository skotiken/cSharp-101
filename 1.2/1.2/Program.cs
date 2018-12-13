using System;

namespace Application
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Please enter number");
            String entered = Console.ReadLine();

            int number1 = Convert.ToInt16(entered);

            Console.WriteLine("Please enter second number");
            String entered2 = Console.ReadLine();

            int number2 = Convert.ToInt16(entered2);


            Console.WriteLine("What do you want to do?");

            String vards = Console.ReadLine();
            
            int sum = number1 + number2;
            int sub = number1 - number2;
            if (vards == "add")
            {
                Console.WriteLine(sum);
            }
            else if (vards == "subtract")
            {
                Console.WriteLine(sub);
            }
            else
            {
                Console.WriteLine("404");
                }

                Console.ReadLine();


            }
        }
    }


