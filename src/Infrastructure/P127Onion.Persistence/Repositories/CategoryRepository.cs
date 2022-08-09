using P127Onion.Application.Interfaces.Repositories;
using P127Onion.Domain.Entities;
using P127Onion.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P127Onion.Persistence.Repositories
{
    public class CategoryRepository:GenericRepository<Category>
    {
        public CategoryRepository(ProniaDbContext contex ) :base(contex)
        {

        }
    }
}
