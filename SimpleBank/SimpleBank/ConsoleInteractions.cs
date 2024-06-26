namespace SimpleBank
{
    internal class ConsoleInteractions
    {
        public Customer currentCustomer { get; set; }
        public void Run()
        {
            "Welcome to the bank!".PrintToConsole();
            "Before we can start, you need to become a customer!".PrintToConsole();
            BecomeCustomer();
            while (true)
            {
                "What would you like to do?".PrintToConsole();
                "1. Create account".PrintToConsole();
                "2. Access account".PrintToConsole();
                "3. Exit ".PrintToConsole();
                int userInput = "Please select a number from the menu above.".RequestInt(3);
                switch (userInput)
                {
                    case 1: CreateAccount(); break;
                    case 2: AccessAccount(); break;
                    case 3: Environment.Exit(1); break;
                }
            }
        }

        private void AccessAccount()
        {
            "Here are your accounts:".PrintToConsole();
            var list = currentCustomer.GetAccounts();
            for (var i = 0; i < list.Count; i++)
            {
                $"{i+1}. ".PrintToConsole();
                list[i].GetAccountDetails.PrintToConsole();
            }

            int accountIndex = "Which account would you like to access?".RequestInt(list.Count) - 1;
            "What would you like to do in this account?".PrintToConsole();
            "1. Deposit".PrintToConsole();
            "2. Withdraw".PrintToConsole();
            "3. Go back".PrintToConsole();
            int userInput = "Please select a number from the menu above.".RequestInt(3);
            switch (userInput)
            {
                case 1: Deposit(list[accountIndex]); break;
                case 2: Withdraw(list[accountIndex]); break;
                case 3: Environment.Exit(1); break;
            }
        }

        private void Withdraw(BankAccount bankAccount)
        {
            int amount = "How much would you like to withdraw?".RequestInt(Int32.MaxValue);
            bankAccount.Withdraw(amount);
            
        }

        private void Deposit(BankAccount bankAccount)
        {
            int amount = "How much would you like to deposit?".RequestInt(Int32.MaxValue);
            bankAccount.Deposit(amount);
            "You successfully deposited money".PrintToConsole();
        }

        private void BecomeCustomer()
        {
            string name = "Please enter your name:".RequestString();
            string address = "Please enter your address:".RequestString();
            int phone = "Please enter your phone number (8 numbers, no special characters):".RequestInt(99999999);
            string email = "Please enter your email:".RequestString();
            Customer newCustomer = new Customer(name, address, phone, email);

            currentCustomer = newCustomer;
            "You just created an account :D".PrintToConsole();

        }


        private void CreateAccount()
        {
            "What kind of account would you like to create?".PrintToConsole();
            "1. Checking account".PrintToConsole();
            "2. Savings account".PrintToConsole();
            "3. Go back".PrintToConsole();
            int userInput = "Please select a number from the menu above.".RequestInt(3);
            switch (userInput)
            {
                case 1: CreateCheckingAccount(); break;
                case 2: CreateSavingsAccount(); break;
                case 3: Environment.Exit(1); break;
            }
        }

        private void CreateSavingsAccount()
        {
            SavingsAccount newBankAccount = new SavingsAccount(0, currentCustomer.Name, "Savings");
            currentCustomer.AddAccount(newBankAccount);
            $"You just created a new bank account: {newBankAccount.GetAccountDetails}".PrintToConsole();
        }

        private void CreateCheckingAccount()
        {
            BankAccount newBankAccount = new BankAccount(0, currentCustomer.Name, "Checking");
            currentCustomer.AddAccount(newBankAccount);
            $"You just created a new bank account: {newBankAccount.GetAccountDetails}".PrintToConsole();

        }
    }
}
