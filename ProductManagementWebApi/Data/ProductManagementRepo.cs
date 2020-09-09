using ProductManagementWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductManagementWebApi.Data
{
    public class ProductManagementRepo : IProductManagementRepo
    {
        private ProductManagementContext _context;

        public ProductManagementRepo(ProductManagementContext context)
        {
            _context = context;
        }
        public Product GetProduct(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Product>> GetProducts()
        {
            //TODO: ToListAsync()
            return await Task.Run(() => _context.Products.ToList()).ConfigureAwait(false);
        }

        public async Task<Product> Add(Product product) 
        {

            var productNew = _context.Products.Add(product);
            
            await _context.SaveChangesAsync();
            return Task.Run(productNew);
        }
    }
}
