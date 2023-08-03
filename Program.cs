using Mosh.ControlFlow;

Exercises exercises = new Exercises();

void InvalidEntry()
{
    Console.Clear();
    Console.WriteLine("Invalid entry. Try again.");
    Console.WriteLine();
    ShowMenu();
}
void ShowMenu()
{
    int userSelection = -1;
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("****************************\n*     CHOOSE A FUNCTION    *\n* 1. Divisible by Three\n* 2. Ongoing Sum\n* 3. Compute Factorial\n* 4. Guess the Number\n* 5. Find the Maximum\n* 0. Exit the Application\n****************************");
    Console.ForegroundColor = ConsoleColor.White;
    string serialUserSelection = Console.ReadLine();
    try
    {
        userSelection = Int32.Parse(serialUserSelection);
    }
    catch (Exception ex)
    {
        InvalidEntry();
    }

    switch (userSelection)
    {
        case 0:
            Environment.Exit(0); break;

        case 1:
            exercises.Exercise1(); break;

        case 2:
            exercises.Exercise2(); break;

        case 3:
            exercises.Exercise3(); break;

        case 4:
            exercises.Exercise4(); break;

        case 5:
            exercises.Exercise5(); break;

        default:
            InvalidEntry();
            break;
    }
}

ShowMenu();
