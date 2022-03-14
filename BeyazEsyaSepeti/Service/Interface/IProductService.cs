using BeyazEsyaSepeti.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BeyazEsyaSepeti.Service.Interface
{
    public interface IProductService
    {
        List<Product> GetAllProducts();

        void Insert(Product product);

        Product GetProductById(string productId);

        List<Product> GetProductsById(List<string> selectedIds);

        List<Product> GetProductsByCategory(string categoryName);
    }
}
