using System.Security.Cryptography.X509Certificates;
using System.Threading.Channels;

namespace IterationStatements
{
    public class Program
    {
        //LukeWarm Section: Create methods below
        //Write a method that will print to the console all numbers 1000 through - 1000

        public static void PrintNumbers()
        {
            for (int i = 1000; i >= -1000; i--)
            {
                Console.WriteLine(i);
            }
        }


        //Write a method that will print to the console numbers 3 through 999 by 3 each time

        public static void PrintNumbersByThree()
        {
           for (int i = 3; i <= 999; i += 3)
            {
                Console.WriteLine(i);
           }
        }


        //Write a method to accept two integers as parameterss and check whether they are equal or not

        public static void CheckEquality(int num1, int num2)
        {
            if (num1 == num2)
            {
                Console.WriteLine("The numbers are equal!");
            }
            else
            {
                Console.WriteLine("The numbers are not equal");
            }
        }





        //Write a method to check whether a given number is even or odd

        public static void EvenOrOdd()
        {
            int input = int.Parse(Console.ReadLine());
            if (input % 2 == 0)
            {
                Console.WriteLine("The number is even");

            }
            else
            {
                Console.WriteLine("The number is odd");
            }

        }



        //Write a method to check whether a given number is positive or negative

        public static void PositiveOrNegative()
        {
            int input = int.Parse(Console.ReadLine());

            if (input > 0)
            {
                Console.WriteLine("The number is positive");

            }
            else
            {
                Console.WriteLine("The number is negative");
            }

        }


        //Write a method to read the age of a candidate and determine whether they can vote.
        //Hint: Use Parse or the safer TryParse() for an extra challenge
        //Parse()
        //TryParse()

        public static void ChechVotingEligible() 
        {
            Console.WriteLine("Enter your age.");
            string ageInput = Console.ReadLine();

            int age;
            if(int.TryParse(ageInput, out age)) 
            { 
                if (age >= 18) 
                {
                    Console.WriteLine("You are eligible to vote");
                }
                else 
                {
                    Console.WriteLine(" Your not eligible to vote");
                }
            }
        }

        //Heatin Up Section:


        //Write a method to check if an integer(from the user) is in the range -10 to 10

        public static void CheckRange(int number)
        {
            if (number >= -10 && number <= 10)
            {
                Console.WriteLine("The number is in range of -10 to 10");
            }
            else
            {
                Console.WriteLine("The number is not in the range of -10 to 10");
            }

        }
        //Write a method to display the multiplication table(from 1 to 12) of a given integer

        public static void DisplayMultiplicationTable(int number)
        {
            for (int i = 1; i <= 12; i++)
            {
                int result = number * i;
                Console.WriteLine(number + " x " + i + " = " + result);
            }
        }


        //Call the methods to test them in the Main method below
        static void Main(string[] args)
            {
            PrintNumbers();

            PrintNumbersByThree();

            CheckEquality(2, 2);

            EvenOrOdd();

            PositiveOrNegative();

            CheckRange(2);

            ChechVotingEligible();

            DisplayMultiplicationTable(8);




        }

        
    }
}
