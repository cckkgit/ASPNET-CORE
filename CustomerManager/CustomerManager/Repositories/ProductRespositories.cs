using CustomerManager.Data;
using CustomerManager.Models;
using CustomerManager.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerManager.Repositories
{
    public class ProductRespositories : IProductRepositories
    {
        //public static List<Product> Products = new List<Product>();

        private readonly ApplicationDbContext _context;

        public ProductRespositories(ApplicationDbContext context)
        {
            _context = context;
        }
        
        public void AddProduct(Product product)
        {
            //Products.Add(product);
            _context.Product.Add(product);
            _context.SaveChanges();
        }

        public List<Product> GetAllProducts()
        {
            //Products.Add(new Product { Name = "Laptop", Price = 15000, Quantity = 1 });
            //Products.Add(new Product { Name = "Ipad", Price = 30000, Quantity = 2 });
            //return Products;
            return _context.Product.ToList();
        }

        public Product GetProduct(Guid id)
        {
            //return Products.FirstOrDefault(x=>x.Id == id);
            var listProduct = _context.Product.FirstOrDefault(x => x.Id == id);
            return listProduct;
        }

    }
}
