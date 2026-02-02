using System;

// This is the main class of the application.
// Every C# console program starts execution inside a class.
// Represents a single expense entry


class Expense
{
    public decimal Amount { get; set; }       // How much money was spent
    public string Category { get; set; }      // Category like Food, Transport
    public string Description { get; set; }   // Short note
    public DateTime Date { get; set; }        // Date of the expense
}

class Program
{
    
    // List to store all expenses in memory
static List<Expense> expenses = new List<Expense>();

    
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
                    case "1":
    Console.Write("Enter amount: ");
    decimal amount;
    while (!decimal.TryParse(Console.ReadLine(), out amount))
    {
        Console.Write("Invalid number. Enter amount again: ");
    }

    Console.Write("Enter category: ");
    string category = Console.ReadLine();

    Console.Write("Enter description: ");
    string description = Console.ReadLine();

    DateTime date = DateTime.Now; // Record the current date/time

    // Create an Expense object and add to the list
    Expense newExpense = new Expense
    {
        Amount = amount,
        Category = category,
        Description = description,
        Date = date
    };

    expenses.Add(newExpense);

    Console.WriteLine("Expense added successfully!");
    Pause();
    break;



                case "2":
                   case "2":
    if (expenses.Count == 0)
    {
        Console.WriteLine("No expenses recorded yet.");
    }
    else
    {
        Console.WriteLine("==== All Expenses ====");
        foreach (var exp in expenses)
        {
            Console.WriteLine($"{exp.Date.ToShortDateString()} | {exp.Category} | {exp.Description} | ${exp.Amount}");
        }
    }
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
