using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PIM_Pessoas_v2.Models;

namespace PIM_Pessoas_v2.Data
{
    public class PIM_Pessoas_v2Context : DbContext
    {
        public PIM_Pessoas_v2Context (DbContextOptions<PIM_Pessoas_v2Context> options)
            : base(options)
        {
        }

        public DbSet<PIM_Pessoas_v2.Models.Pessoa> Pessoa { get; set; }
    }
}
