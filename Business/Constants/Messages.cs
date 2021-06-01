using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    //sürekli new() yapmak istemyorum.Bu yüzden static yaptık.
    public static class Messages
    {

        public static string ProductAdded = "Ürün eklendi";
        public static string ProductNameInvalid = "Ürün ismi geçersiz";
        public static string MaintenanceTime = "Sistem bakımda";
        public static string ProductsListed = "Ürünler listelendi";
        public static string ProductCountOfCategoryError = "Bir kategoriye ait en fazla 10 ürün olabilir.";
        public static string ProductNameAlreadyExists = "Ürün ismi mevcut.";    
        public static string CategoryLimitExceed = "Kategori limiti aşıldığı için yeni ürün eklenemiyor.";
    }
}
