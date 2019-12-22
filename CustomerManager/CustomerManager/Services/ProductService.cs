using CustomerManager.Models;
using CustomerManager.Repositories;
using CustomerManager.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerManager.Services
{
    public class ProductService : IProductService
    {
        IProductRepositories _repo;
        public ProductService(IProductRepositories repo)
        {
            _repo = repo;
        }
        public void AddProduct(ProductViewModel product)
        {
            Product productModel = new Product
            {
                Id = product.Id,
                Name = product.Name,
                Quantity = product.Quantity,
                Price = product.Price


            };

            _repo.AddProduct(productModel);
        }

        public double CalTotalPrice(Product product)
        {
            
            return product.Quantity * product.Price;
        }

        
        public List<ProductViewModel> GetAllProducts()
        {

            var products = _repo.GetAllProducts();
            List<ProductViewModel> productViewModels = new List<ProductViewModel>();
            foreach (var product in products)
            {
                productViewModels.Add(new ProductViewModel
                {
                    Id = product.Id,
                    Name = product.Name,
                    Quantity = product.Quantity,
                    Price = product.Price,
                    TotalPrice = CalTotalPrice(product)
                }
                    ); 
            }
            return productViewModels;
        }

        public ProductViewModel GetProduct(Guid id)
        {
            var productModel = _repo.GetProduct(id);
            var viewModel = new ProductViewModel
            {
                Id = productModel.Id,
                Name = productModel.Name,
                Quantity = productModel.Quantity,
                Price = productModel.Price,
                TotalPrice = CalTotalPrice(productModel)
            };
            return viewModel;
        }
    }
}
