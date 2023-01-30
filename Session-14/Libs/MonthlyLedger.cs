using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Transactions;
using System.Numerics;
using Session_11;

namespace Libs {

    //TODO:Discuss and implement ledger 
    public  class MonthlyLedger {

        public int Year { get; set; }
        public int Month { get; set; }
        public decimal Income { get; set; }    

        public decimal Expenses { get; set; }

        public decimal Total { get; set; }

        private static MonthlyLedger _instance;

        private  MonthlyLedger() {
            Year = DateTime.Now.Year;
            Month = DateTime.Now.Month;
            Income = 0;
            Expenses = 3000;
            Total = +Income - Expenses;

        }


        private MonthlyLedger(List<Employee> employees)
        {
            Income = 0;
            Expenses += 3000;
            CalculateEmployeeCost(employees);
            Year = DateTime.Now.Year;
            Month= DateTime.Now.Month;
            Total +=Income - Expenses;
        }


        public static MonthlyLedger GetInstance()
        {
            if (_instance == null)
            {
                _instance = new MonthlyLedger();
            }

            return _instance;
        }



        public void UpdateIncome(Transaction trans)
        {
            Income += trans.TotalPrice;
        }

        public void CalculateEmployeeCost(List<Employee> employees)        
        {
            foreach (Employee employee in employees) {
                Expenses +=  employee.Salary;    
            }
        }
        public void UpdateExpensesFromTransaction(Transaction trans)
        {
            decimal totalProductCost = 0;
            foreach (var tr in trans.TransactionLines) {
                Expenses += tr.Quantity * tr.Product.Cost;
            }
        } 
        public void UpdateLedgerAfterTransaction(Transaction trans) {
            UpdateExpensesFromTransaction(trans);
            UpdateIncome(trans);
            Total = Total + Income - Expenses;
        }


       
        
    }
}
