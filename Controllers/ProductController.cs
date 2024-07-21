using Microsoft.AspNetCore.Mvc;
using ProductApi.Models;

namespace ProductApi.Controllers
{
    [ApiController]//* Controller sınıfını tanımladık
    [Route("api/[controller]")]//* Kontrolerı tanımladık
    public class ProductController : ControllerBase
    {

        private static List<Product>?  _products;//* Product listesi tanımladık

        public ProductController()
        {
            _products = new List<Product> //* Product listesi olusturuldu
            {
                //* Product listesi dolduruldu
                new() { ProductId = 1, ProductName = "IPhone 13", ProductPrice = 50000, ProductStatus = false },
                new() { ProductId = 2, ProductName = "IPhone 14", ProductPrice = 60000, ProductStatus = true },
                new() { ProductId = 3, ProductName = "IPhone 15", ProductPrice = 70000, ProductStatus = true },
                new() { ProductId = 4, ProductName = "IPhone 16", ProductPrice = 80000, ProductStatus = true }
            };
        }

        //TODO: Burada Actionlar tanımlanır
        //* Get https://localhost:7198/api/product => GET İsteği
        [HttpGet]
        public List<Product> GetProducts() //productları liste halinde döndük
        {
            return _products ?? new List<Product>(); // eğet product nullsa listeyi döndür işlemi yazdık
        }

        //* Get https://localhost:7198/api/product/1 => GET İsteği {id} 'yi parametre olarak alır  
        [HttpGet("{id}")] //! Eşleştirilicek method burası 
        public Product? GetProductId(int id) //Product'ın id'sini döndürür ve null değer olabilir 
        {
            return _products.FirstOrDefault(x => x.ProductId == id); // product listesinden id ile eşleşen productı döndürür
        }

    }
}
