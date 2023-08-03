namespace Mosh.ControlFlow
{
    public class Exercises
    {
        public void Exercise1()
        {
            int DivisibleByThree()
            {
                int count = 0;
                for (int i = 0; i < 101; i++)
                {
                    if (i % 3 == 0)
                    {
                        count++;
                    }
                }
                return count;
            }
            Console.WriteLine("How many numbers between 1 and 100 are divisible by 3 with no remainder?");
            Console.WriteLine($"Answer: {DivisibleByThree()}");
        }

        public void Exercise2()
        {
            int sum = 0;
            Console.Write("Enter a number or 'ok' to exit: ");
            string userInput = Console.ReadLine();
            while (userInput != "ok") 
            {
                int number = Int32.Parse(userInput);
                sum += number;
                Console.WriteLine($"The sum of all numbers you have entered is {sum}");
                Console.Write("Enter a number or 'ok' to exit: ");
                userInput = Console.ReadLine();
            }
        }

        public void Exercise3()
        {
            Console.Write("Enter an integer to compute its factorial: ");
            int userInput = Int32.Parse(Console.ReadLine());
            int placeholder = userInput;
            int factorial = 1;
            while (userInput != 1) 
            {
                factorial = factorial * userInput;
                userInput--;
            }
            Console.WriteLine($"{placeholder}! = {factorial}.");
        }

        public void Exercise4()
        {
            Console.WriteLine("N/A");
        }

        public void Exercise5()
        {
            Console.WriteLine("N/A");
        }
    }
}
