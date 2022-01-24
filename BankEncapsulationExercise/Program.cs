using System;

namespace BankEncapsulationExercise
{
     class Program
    {
        static void Main(string[] args)
        {
            BankAccount myAccount = new BankAccount(600.00);
            Console.WriteLine("New bank Account created");

            Console.WriteLine($"Your balance is: {myAccount.GetBalance()}");

        }
    }
}

