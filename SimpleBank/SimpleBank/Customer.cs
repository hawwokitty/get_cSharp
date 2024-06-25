namespace SimpleBank
{
    internal class Customer
    {
        public string Name { get; set; }
        private string _address { get; set; }
        private int _phoneNumber { get; set; }
        private string _email { get; set; }
        private List<BankAccount> _accounts { get; set; }

        public Customer(string name, string address, int phoneNumber, string email)
        {
            Name = name;
            _address = address;
            _phoneNumber = phoneNumber;
            _email = email;
            _accounts = new List<BankAccount>();
        }

        public void AddAccount(BankAccount account)
        {
            _accounts.Add(account);
        }
        public void RemoveAccount(BankAccount account)
        {
            _accounts.Remove(account);
        }

        public List<BankAccount> GetAccounts()
        {
            return _accounts;
        }
    }
}
