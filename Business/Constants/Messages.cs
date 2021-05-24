﻿using Entities.Concrete;
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
        internal static List<Product> MaintenanceTime;
        internal static bool ProductsListed;
    }
}
