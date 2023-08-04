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
            Random random = new Random();
            int randomNumber = random.Next(1, 11);
            // Console.WriteLine($"Shhhhh! The random number is {randomNumber}");
            int count = 4;
            Console.Write("I have chosen a random number from 1 to 10. You have four guesses: ");
            int userGuess = Int32.Parse(Console.ReadLine());
            while (userGuess != randomNumber && count > 1) 
            {
                count--;
                Console.WriteLine($"Guess again! You have {count} {(count > 1 ? "guesses" : "guess")} remaining.");
                Console.Write($"Your {(count > 1 ? "next" : "final")} guess: ");
                userGuess = Int32.Parse(Console.ReadLine());
            }
            if (userGuess == randomNumber)
            {
                Console.WriteLine("Congratulations! You guessed my random number.");
            }
            else
            {
                Console.WriteLine("0 guesses remaining. Try again sometime!");
            }
        }

        public void Exercise5()
        {
            List<int> numbersEntered = new List<int>();
            Console.Write("Enter a series of integers separated by a comma: ");
            string userInput = Console.ReadLine();
            foreach (var sub in userInput.Split(","))
            {
                int num;
                if (int.TryParse(sub, out num))
                    numbersEntered.Add(num);
            }
            Console.WriteLine($"The greatest integer in the series you supplied is {numbersEntered.Max()}.");
        }
    }
}
