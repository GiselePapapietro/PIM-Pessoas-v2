using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.Entity;

namespace PIM_Pessoas_v2.Models
{
    public class contexto: DbContext
    {
        public DbSet<Pessoa> Pessoa { get; set; }
    }
}
