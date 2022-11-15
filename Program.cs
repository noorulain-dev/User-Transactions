using System;

namespace Passtask3
{
    // Main class called Program where our Program begins
    class Program
    {
        // Storing information in an array such as Transaction number, Transaction Date, Transaction Amount, Points etc.
        // Each array is known as myTransactions
        public static void Show(Transaction[] transactions){
            foreach(Transaction t in transactions){
                Console.WriteLine("Transaction No:" + t.TransNo);
                Console.WriteLine("Transaction Date " + t.Date);
                Console.WriteLine("Transaction Amounts: " + t.Amounts);
                Console.WriteLine("Points " + t.Points);
                Console.WriteLine("Transaction mode: " +t.Mode);
                Console.WriteLine (t.PrintInfo());
            }
        }
        
        //The program executes from here and then calls the main class Program
        static void Main(string[] args)
        {
            Transaction[] myTransactions = new Transaction[2];

            // Passing the following values to the Constructor Transaction in the same order
            // Saving values to both the arrays respectively
            myTransactions[0] = new Transaction(1001, "1/1/2021", 150, Transaction.TransactionMode.online);
            myTransactions[1] = new Transaction(1002, "2/2/2021", 280, Transaction.TransactionMode.offline); 
            
            // Calling the UpdatePoints method for each array
            myTransactions[0].UpdatePoints();
            myTransactions[1].UpdatePoints();
            
            // Calling the Show method to print the arrays
            Show(myTransactions);

        }
    

        
    }
}