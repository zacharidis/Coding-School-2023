using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
///Summary
///TransactionHandler will be the instance we call that does all the basic processes
///here will do produc calculations , discount 
///remove or add discoun , check payment method 
///update and possuibly export a json
///Later in the implementation it will have a role of housekeeping ledger 
///

namespace Libs {
    [Serializable]
    public class TransactionHandler 
    {
        public Transaction _transaction { get; set; } = new Transaction();
        public List<Transaction> _transactions = new List<Transaction>();
        public TransactionLine _transactionLine { get; set; } = new TransactionLine();

        private decimal _discountPercent = 0.15m;
        private decimal _discountThreshold = 10m;


        public void AddTransactionLines(TransactionLine line) 
        {
            _transaction.TransactionLines.Add(line) ;
        }

       public void CalculateTransaction() 
        {
            decimal total= 0 ;
            foreach(var line in _transaction.TransactionLines) 
            {
                line.TotalPrice = line.Price * line.Quantity;
                total += line.TotalPrice;
            }
            _transaction.TotalPrice = total;
            ApplyDiscount();
        }

      
        public void ApplyDiscount() 
        {
            if (_transaction.TotalPrice >= 50) 
            {
                _transaction.TotalPrice = _transaction.TotalPrice -(_transaction.TotalPrice *0.15m);
            }
        }
        
        public void ChangeLineQuantity(Guid id, int newQuantity)
        {
            var line= _transaction.TransactionLines.Find(x => x.ID == id);
            if (line != null)
            {
                line.Quantity = newQuantity;
                CalculateTransaction();
            }
        }
        public void RemoveTransactionLine (Guid id)
        {
            var line = _transaction.TransactionLines.Find(x => x.ID == id);
            if (line!= null)
            {
                _transaction.TransactionLines.Remove(line);
                CalculateTransaction();
            }
        }    
        public void SaveTransactionToJson()
        {
            string json = JsonConvert.SerializeObject(_transaction);
            string path = $"reciept{_transaction.ID}.json";
            File.WriteAllText(path, json);
        }
        public string FinalizeTrasaction()
        {
            if (_transaction == null || _transaction.TransactionLines.Count == 0)
            {
                return "nothing to checkout";
            }
            if (_transaction.PaymentMethod == PaymentMethod.CreditCard && _transaction.TotalPrice >= 50)
            {
                return "can only pay with cash";
            }
            SaveTransactionToJson();
            return $"The total amount is {_transaction.TotalPrice}";
        }
        public string FinalizeTransaction() {
            if (_transaction.TransactionLines.Count == 0)
                return "No items added!";
            if (_transaction.TotalPrice > 50 && _transaction.PaymentMethod == PaymentMethod.CreditCard)
                return "Cannot pay with credit card if price is more than 50 Euros";

            return string.Empty;
        }

        public void Addnew() {
            _transactions.Add(_transaction);
        }


    }    
}