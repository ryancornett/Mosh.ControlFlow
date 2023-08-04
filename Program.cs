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
    string asciiArt = @"
		 ____                    __                 ___       ____    ___                         
		/\  _`\                 /\ \__             /\_ \     /\  _`\ /\_ \                        
		\ \ \/\_\    ___     ___\ \ ,_\  _ __   ___\//\ \    \ \ \L\_\//\ \     ___   __  __  __  
		 \ \ \/_/_  / __`\ /' _ `\ \ \/ /\`'__\/ __`\\ \ \    \ \  _\/ \ \ \   / __`\/\ \/\ \/\ \ 
		  \ \ \L\ \/\ \L\ \/\ \/\ \ \ \_\ \ \//\ \L\ \\_\ \_   \ \ \/   \_\ \_/\ \L\ \ \ \_/ \_/ \
		   \ \____/\ \____/\ \_\ \_\ \__\\ \_\\ \____//\____\   \ \_\   /\____\ \____/\ \___x___/'
		    \/___/  \/___/  \/_/\/_/\/__/ \/_/ \/___/ \/____/    \/_/   \/____/\/___/  \/__//__/";

    Console.WriteLine(asciiArt);
    string menu = "****************************\n*     CHOOSE A FUNCTION    *\n* 1. Divisible by Three    *\n* 2. Ongoing Sum           *\n* 3. Compute Factorial     *\n* 4. Guess the Number      *\n* 5. Find the Maximum      *\n* 0. Exit the Application  *\n****************************";
    int userSelection = -1;
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine(menu);
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
