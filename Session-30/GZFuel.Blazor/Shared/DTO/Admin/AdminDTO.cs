﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GZFuel.Blazor.Shared.DTO.Admin
{
    public class AdminDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Surname { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
