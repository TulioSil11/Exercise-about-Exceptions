using Proposed_Exercise_Exceptions.Entities;
using Proposed_Exercise_Exceptions.Entities.Exeptions;
using System;
using System.Globalization;

namespace Proposed_Exercise_Exceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter account data");
                Console.Write("Number: ");
                int number = int.Parse(Console.ReadLine());
                Console.Write("Holder: ");
                string holder = Console.ReadLine();
                Console.Write("Initial balance: ");
                double initialBalance = double.Parse(Console.ReadLine());
                Console.Write("Withdraw limit: ");
                double withdrawLimit = double.Parse(Console.ReadLine());

                Account a = new Account(number, holder, initialBalance, withdrawLimit);

                Console.WriteLine("");

                Console.Write("Enter amount for withdraw: ");
                double amoutForWithdraw = double.Parse(Console.ReadLine());

                a.withDraw(amoutForWithdraw);


                Console.Write($"New balance: {a.balance.ToString("F2", CultureInfo.InvariantCulture)}");
            }
            catch (DomainExeptions e)
            {
                Console.WriteLine("Withdraw error: " + e.Message);
            }

            catch (NullReferenceException e)
            {
                Console.WriteLine("Null number not allowed " + e.Message);
            }

            catch (FormatException e)
            { 
                Console.WriteLine("Error in format: " + e.Message);
            }

            catch(Exception e)
            {
                Console.WriteLine("Unexpected error: " + e.Message);
            }
        }
    }
}
