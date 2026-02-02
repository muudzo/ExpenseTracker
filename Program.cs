using System;
using System.Collections.Generic; // Needed for List<T>

// Represents a single expense entry
class Expense
{
    public decimal Amount { get; set; }       // How much money was spent
    public string? Category { get; set; }      // Category like Food, Transport
    public string? Description { get; set; }   // Short note
    public DateTime Date { get; set; }        // Date of the expense
}

class Program
{
    // List to store all expenses in memory
    static List<Expense> expenses = new List<Expense>();

    // Main is the entry point of the program.
    static void Main()
    {
        RunMenu(); // Start the menu loop
    }

    // This method contains the main program loop and menu system.
    static void RunMenu()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("==== Expense Tracker ====");
            Console.WriteLine("1. Add expense");
            Console.WriteLine("2. View expenses");
            Console.WriteLine("3. Monthly total");
            Console.WriteLine("4. Save to file");
            Console.WriteLine("5. Load from file");
            Console.WriteLine("0. Exit");
            Console.Write("Select option: ");

            var input = Console.ReadLine();

            switch (input)
            {
                // ADD EXPENSE
                case "1":
                    Console.Write("Enter amount: ");
                    decimal amount;
                    while (!decimal.TryParse(Console.ReadLine(), out amount))
                    {
                        Console.Write("Invalid number. Enter amount again: ");
                    }

                    Console.Write("Enter category: ");
                    string? category = Console.ReadLine();

                    Console.Write("Enter description: ");
                    string? description = Console.ReadLine();

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

                // VIEW EXPENSES
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

                // MONTHLY TOTAL (placeholder for now)
                case "3":
                    Console.WriteLine("Monthly total - coming soon");
                    Pause();
                    break;

                // SAVE TO FILE (placeholder for now)
                case "4":
                    Console.WriteLine("Save to file - coming soon");
                    Pause();
                    break;

                // LOAD FROM FILE (placeholder for now)
                case "5":
                    Console.WriteLine("Load from file - coming soon");
                    Pause();
                    break;

                // EXIT
                case "0":
                    return;

                // INVALID INPUT
                default:
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