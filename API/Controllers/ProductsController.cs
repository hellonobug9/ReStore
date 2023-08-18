using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Data;
using API.Entities;
using API.Extensions;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    public class ProductsController
    {
        private readonly StoreContext _context;

        public ProductsController(StoreContext context)
        {
            _context = context;
        }
        
        // Create a asynchronous request to retrieve products
            public async Task<IEnumerable<Product>> GetProducts(string orderBy)
            {
                var query = _context.Products.Sort(orderBy).AsQueryable();
                return await query.ToListAsync();
               // create a switch statement to retrieve products from the store using the order statement string
            }
        
    }
}