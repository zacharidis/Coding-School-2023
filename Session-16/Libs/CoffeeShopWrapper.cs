using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
///<summary>
///CoffeeShopWrapper is gonna be the Kind of promise we made so
///So the programm doesnt save 5 files individually but one single.
///Since we cant chage the whole architecture wrappes is gonna be used on main
/// </summary>

namespace Libs {
    [Serializable]
    [JsonObject(MemberSerialization.OptOut)]
    public  class CoffeeShopWrapper {
        public CoffeeShopHandler CoffeeData { get; set; }
        public TransactionHandler Transaction { get; set; }
        public MonthlyLedger Ledger { get; set; }

        public CoffeeShopWrapper() { }
        public CoffeeShopWrapper(CoffeeShopHandler coffeeData, TransactionHandler transaction , MonthlyLedger ledger){
            this.CoffeeData = new CoffeeShopHandler();
            this.Ledger = new MonthlyLedger();
            this.Transaction = new TransactionHandler();
            this.CoffeeData = coffeeData;
            this.Transaction = transaction;
            this.Ledger = ledger;
        }
        


    }
}
