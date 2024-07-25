using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



public class AtmApplication
{
    private Bank bank;
    private Account currentAccount;

    public AtmApplication()
    {
        bank = new Bank();
    }

    public void Run()
    {
        bool exit = false;

        while (!exit)
        {
            Console.WriteLine("ATM Main Menu:");
            Console.WriteLine("1. Create Account");
            Console.WriteLine("2. Select Account");
            Console.WriteLine("3. Exit");
            Console.Write("Select an option: ");

            switch (Console.ReadLine())
            {
                case "1":
                    CreateAccount();
                    break;
                case "2":
                    SelectAccount();
                    break;
                case "3":
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Invalid option, try again.");
                    break;
            }
        }
    }

    private void CreateAccount()
    {
        Console.Write("Enter Account Number: ");
        int accountNumber = int.Parse(Console.ReadLine());

        Console.Write("Enter Initial Balance: ");
        double initialBalance = double.Parse(Console.ReadLine());

        Console.Write("Enter Interest Rate: ");
        double interestRate = double.Parse(Console.ReadLine());

        Console.Write("Enter Account Holder's Name: ");
        string name = Console.ReadLine();

        Account newAccount = new Account(accountNumber, initialBalance, interestRate, name);
        bank.AddAccount(newAccount);

        Console.WriteLine("Account created successfully!");
    }

    private void SelectAccount()
    {
        Console.Write("Enter Account Number: ");
        int accountNumber = int.Parse(Console.ReadLine());

        currentAccount = bank.RetrieveAccount(accountNumber);

        if (currentAccount != null)
        {
            bool exitAccount = false;

            while (!exitAccount)
            {
                Console.WriteLine("Account Menu:");
                Console.WriteLine("1. Check Balance");
                Console.WriteLine("2. Deposit");
                Console.WriteLine("3. Withdraw");
                Console.WriteLine("4. Display Transactions");
                Console.WriteLine("5. Exit Account");
                Console.Write("Select an option: ");

                switch (Console.ReadLine())
                {
                    case "1":
                        Console.WriteLine(currentAccount.ToString());
                        break;
                    case "2":
                        Deposit();
                        break;
                    case "3":
                        Withdraw();
                        break;
                    case "4":
                        DisplayTransactions();
                        break;
                    case "5":
                        exitAccount = true;
                        break;
                    default:
                        Console.WriteLine("Invalid option, try again.");
                        break;
                }
            }
        }
        else
        {
            Console.WriteLine("Account not found.");
        }
    }

    private void Deposit()
    {
        Console.Write("Enter amount to deposit: ");
        double amount = double.Parse(Console.ReadLine());

        currentAccount.Deposit(amount);
        Console.WriteLine("Deposit successful.");
    }

    private void Withdraw()
    {
        Console.Write("Enter amount to withdraw: ");
        double amount = double.Parse(Console.ReadLine());

        if (currentAccount.Withdraw(amount))
        {
            Console.WriteLine("Withdrawal successful.");
        }
        else
        {
            Console.WriteLine("Insufficient funds.");
        }
    }

    private void DisplayTransactions()
    {
        Console.WriteLine("Transaction History:");
        foreach (var transaction in currentAccount.GetTransactions())
        {
            Console.WriteLine(transaction);
        }
    }
}

