using DataAccess.Abstarct;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete
{
    public class InMemoryProductDal : IProductDal
    {

        List<Product> _products;

        public InMemoryProductDal()
        {
            //Oracle,Sql Server ,MongoDb,Postgres
            _products = new List<Product> {

                new Product{ProductId=1 , CategoryId=1,ProductName="Bardak",UnitPrice=15,UnitsInStock=15},
                new Product{ProductId=2 , CategoryId=3,ProductName="Çatal",UnitPrice=500,UnitsInStock=30},
                new Product{ProductId=3 , CategoryId=2,ProductName="Telefon",UnitPrice=1500,UnitsInStock=55},
            };
        }

        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {
            _products.Remove(_products.SingleOrDefault(p => p.ProductId == product.ProductId));
        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public List<Product> GetAllByCategory(int categoryıd)
        {
            return _products.Where(x => x.CategoryId == categoryıd).ToList();
        }

        public void Update(Product product)
        {
            Product pUpdate = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            pUpdate.ProductName = product.ProductName;
            pUpdate.CategoryId = product.CategoryId;
            pUpdate.UnitPrice = product.UnitPrice;
            pUpdate.UnitsInStock = product.UnitsInStock;


        }
    }
}
