﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_06.Stuff
{

    public enum GenderEnum {Male = 0 , Female = 1 , Other = 2} 
    internal class Person
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public int Age { get; set; }

        public bool Undergraduate { get; set; }

        public GenderEnum Gender { get; set; } 



        // CONSTRUCTORS
        // default constructor 
        public Person()
        {

        }

        public Person(Guid id)
        {
            this.Id = id;
        }


    }
   
}
