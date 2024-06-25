namespace SimpleBank
{
    internal class BankAccount
    {
        private static int accountNumberSeed = 10000;
        protected int AccountNumber { get; set; }
        protected decimal Balance { get; set; }
        protected string Owner { get; set; }
        protected string AccountType { get; set; }

        public BankAccount(decimal balance, string owner, string accountType)
        {
            AccountNumber = accountNumberSeed;
            accountNumberSeed++;
            Balance = balance;
            Owner = owner;
            AccountType = accountType;
        }

        public void Deposit(decimal amount)
        {
            Balance += amount;
        }

        public void Withdraw(decimal amount)
        {
            if (Balance > amount)
            {
                Balance -= amount;
                "You successfully withdrew money".PrintToConsole();
            }
            else
            {
                $"You only have {Balance} amount of money".PrintToConsole();
            }
        }

        public decimal GetBalance()
        {
            return Balance;
        }

        public virtual string GetAccountDetails =>
                $"Account Number: {AccountNumber} \nOwner: {Owner} \nBalance: {Balance} \nAccount Type: {AccountType} \n";

    }
}
