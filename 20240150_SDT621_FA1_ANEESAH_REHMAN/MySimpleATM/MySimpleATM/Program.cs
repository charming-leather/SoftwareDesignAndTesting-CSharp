using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("CTU SIMPLE ATM SYSTEM\n");

        // Prompting user name
        Console.Write("HI, WHAT IS YOUR NAME? ");
        string name = Console.ReadLine();

        Console.WriteLine($"\nWELCOME {name.ToUpper()}!");

        // Promting account balance
        Console.Write("Enter account balance: ");
        double balance = Convert.ToDouble(Console.ReadLine());

        // Promting how much want to draw
        Console.Write("Enter withdrawal amount: ");
        double withdrawal = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine();

        // Checking if account has money or insufficient funds
        if (withdrawal <= balance)
        {
            balance = balance - withdrawal;

            Console.WriteLine("Withdrawal successful!");

            // Display updated balance after money drawed
            Console.WriteLine("Updated Balance: " + balance.ToString("N2"));

            // Display transaction time and date 
            DateTime transactionTime = DateTime.Now;
            Console.WriteLine("Transaction Time: " + transactionTime.ToString("dd MMM yyyy HH:mm:ss"));
        } // close if
        else
        {
            Console.WriteLine("Insufficient funds! Withdrawal declined.");
        } // close else

        Console.WriteLine("\nThank you for using CTU ATM System.");
    } // close Main
}// close program