using Domain.Entities;
using Repository.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repositories.Interfaces
{
    public class ProductRepository : Repository<Product> , IProductRepository
    {
        public ProductRepository(AppDbContext context) : base (context )
        { 
        }
    }
}
