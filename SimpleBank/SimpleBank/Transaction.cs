using System.Runtime.InteropServices.JavaScript;

namespace SimpleBank
{
    internal class Transaction
    {
        private Guid _transactionId { get; set; }
        private decimal _amount { get; set; }
        private DateTime _date { get; set; }
        private string _transactionType { get; set; }

        public Transaction(decimal amount, DateTime date, string transactionType)
        {
            _transactionId = new Guid();
            _amount = amount;
            _date = date;
            _transactionType = transactionType;
        }

        public string GetTransactionDetails()
        {
            return
                $"Transaction ID: {_transactionId} \nAmount: {_amount} \nDate: {_date} \nTransaction Type: {_transactionType}";
        }
    }
}
