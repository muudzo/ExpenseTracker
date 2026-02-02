using System;

// This is the main class of the application.
// Every C# console program starts execution inside a class.
class Program
{
    // Main is the entry point of the program.
    // When you run `dotnet run`, this method is called first.
    static void Main()
    {
        RunMenu(); // Start the menu loop
    }

    // This method contains the main program loop and menu system.
    static void RunMenu()
    {
        // Infinite loop so the app keeps running until the user chooses Exit.
        while (true)
        {
            // Clears the console screen for a clean UI every loop.
            Console.Clear();

            // Display application title
            Console.WriteLine("==== Expense Tracker ====");

            // Display menu options
            Console.WriteLine("1. Add expense");
            Console.WriteLine("2. View expenses");
            Console.WriteLine("3. Monthly total");
            Console.WriteLine("4. Save to file");
            Console.WriteLine("5. Load from file");
            Console.WriteLine("0. Exit");

            // Prompt the user to choose an option
            Console.Write("Select option: ");

            // Read user input from the keyboard
            var input = Console.ReadLine();

            // Decide what to do based on the user's choice
            switch (input)
            {
                case "1":
                    Console.WriteLine("Add expense - coming soon");
                    Pause(); // Wait so the user can read the message
                    break;

                case "2":
                    Console.WriteLine("View expenses - coming soon");
                    Pause();
                    break;

                case "3":
                    Console.WriteLine("Monthly total - coming soon");
                    Pause();
                    break;

                case "4":
                    Console.WriteLine("Save to file - coming soon");
                    Pause();
                    break;

                case "5":
                    Console.WriteLine("Load from file - coming soon");
                    Pause();
                    break;

                case "0":
                    // Exit the RunMenu method which ends the program
                    return;

                default:
                    // Handles invalid inputs
                    Console.WriteLine("Invalid choice.");
                    Pause();
                    break;
            }
        }
    }

    // Helper method that pauses execution until the user presses Enter.
    static void Pause()
    {
        Console.WriteLine("Press Enter to continue...");
        Console.ReadLine();
    }
}
