using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandEF.Domain.Model
{
    internal class Poet
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

        public List<Poem> Poems { get; set; } = new List<Poem>();



    }
}
