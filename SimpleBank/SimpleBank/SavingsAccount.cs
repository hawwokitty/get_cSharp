namespace SimpleBank
{
    internal class SavingsAccount : BankAccount
    {
        private decimal _interestRate => (decimal)4.5;

        public decimal CalculateInterest()
        {
            return Balance * (100/_interestRate);
        }

        public override string GetAccountDetails => $"{base.GetAccountDetails}Interest Rate: {_interestRate}% \n";

        public SavingsAccount(decimal balance, string owner, string accountType) : base(balance, owner, accountType)
        {
        }
    }
}
