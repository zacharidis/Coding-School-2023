﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnderstandEF.Domain.Model;

namespace UnderstandEF.Orm.Context
{
    public  class PoetryDbContext : DbContext
    {
        DbSet<Poet> Poets { get; set; }
        DbSet<Poem> Poems { get; set; }



    }
}
