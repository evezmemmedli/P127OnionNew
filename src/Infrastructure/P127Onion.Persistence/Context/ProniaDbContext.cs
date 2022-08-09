using Microsoft.EntityFrameworkCore;
using P127Onion.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P127Onion.Persistence.Context
{
    public class ProniaDbContext:DbContext
    {
        public ProniaDbContext(DbContextOptions<ProniaDbContext>opt):base(opt)
        {

        }
        public DbSet<Category> Categories { get; set; }
    }
}
