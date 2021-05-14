using Business.Concrete;
using DataAccess.Concrete;
using DataAccess.Concrete.EntityFramework;
using System;

namespace ConsoleUI
{
    class Program
    {

        //SOLID 
        //Open Closed Principle: Yeni bir özellik eklendi ve mevcut yapıdan hiçbir değiştirilmedi.
        //Örneğin EntityFramework eklendi ve Busines katmanında sadece bağlanılacak DataAccess sınıfı değiştirildi.

        static void Main(string[] args)
        {

            ProductManager productManager = new ProductManager(new EfProductDal());

            foreach (var item in productManager.GetAll())
            {
                Console.WriteLine(item.ProductName );
            }

        }
    }
}
