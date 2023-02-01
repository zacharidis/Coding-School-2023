using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandEF.Orm.Context
{
    public  class PoetryDbContext : DbContext
    {
        DbSet<Poet> poets { }

    }
}
