using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Account
{
    public int AccountNumber { get; set; }
    public double Balance { get; private set; }
    public double InterestRate { get; set; }
    public string AccountHolderName { get; set; }
    private List<string> transactions;

    public Account(int accountNumber, double initialBalance, double interestRate, string accountHolderName)
    {
        AccountNumber = accountNumber;
        Balance = initialBalance;
        InterestRate = interestRate;
        AccountHolderName = accountHolderName;
        transactions = new List<string>();
    }

    public void Deposit(double amount)
    {
        if (amount > 0)
        {
            Balance += amount;
            transactions.Add($"Deposited: {amount}");
        }
    }

    public bool Withdraw(double amount)
    {
        if (amount > 0 && amount <= Balance)
        {
            Balance -= amount;
            transactions.Add($"Withdrew: {amount}");
            return true;
        }
        return false;
    }

    public List<string> GetTransactions()
    {
        return transactions;
    }

    public override string ToString()
    {
        return $"Account Holder: {AccountHolderName}, Account Number: {AccountNumber}, Balance: {Balance:C}";
    }
}
