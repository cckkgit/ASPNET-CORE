using CustomerManager.Models;
using CustomerManager.Repositories;
using CustomerManager.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerManager.Services
{
    public interface IProductService
    {
        void AddProduct(ProductViewModel product);
        
        double CalTotalPrice(Product product);

        List<ProductViewModel> GetAllProducts();
        ProductViewModel GetProduct(Guid id);
        ProductViewModel EditProduct(Guid id);
    }
}
