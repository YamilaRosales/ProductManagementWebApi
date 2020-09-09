using ProductManagementWebApi.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProductManagementWebApi.Data
{
    public interface IProductManagementRepo
    {

        Task<IEnumerable<Product>> GetProducts();
        Product GetProduct(int id);

        //Task PutProduct(int id, Product product);
        Task<Product> Add(Product product);
    }
}
