using CustomerManager.Models;
using CustomerManager.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerManager.Repositories
{
    public interface IProductRepositories
    {
        void AddProduct(Product product);
        List<Product> GetAllProducts();
        Product GetProduct(Guid id);
    }
}
