﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GZFuel.Model.Entities
{
    public class Item
    {
         //    : ID, Code, Description, ItemType(enum), Price, Cos
         public int ID { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public string ItemType { get; set; }
        public decimal Price { get; set; }
        public decimal Cost { get; set; }

        // constructor for Item
        public Item( string code, string description, string itemType, decimal price, decimal cost)
        {
            // ID = id; not here , the ID is auto generated by the database
            Code = code;
            Description = description;
            ItemType = itemType;
            Price = price;
            Cost = cost;
        }


        // relationships

        public List<TransactionLine> TransactionLines { get; set; }
        

        



    }
}
