using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandEF.Domain.Model
{
    public class Poem
    {
        public int Id { get; set; }
        public string PoemBody { get; set; }
        public string PoemName { get; set;  }
        
        // EF ref
        public Poet Poet { get; set; }

        public int PoetID { get; set; }

        // EF ref

    }
}
