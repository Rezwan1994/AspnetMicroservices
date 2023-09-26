using Catalog.API.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Catalog.API.Repositories
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> GettProducts();
        Task<IEnumerable<Product>> GettProductByName(string name);
        Task<IEnumerable<Product>> GetProductByCategory(string category);
        Task<Product> GetProduct(string id);
   
        Task CreateProduct(Product product);
        Task<bool> UpdateProduct(Product product);
        Task<bool> DeleteProduct(string id);

    }
}
