using Entities.Concrete;
using Entities.Concrete.Senturkler;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract.SenturklerService
{
    public interface ISTOK_KartiService
    {
        List<STOK_Karti> GetAll();
        //List<STOK_Karti> GetAllByCategory(int id);
        //List<STOK_Karti> GetByUnitPrice(decimal min, decimal max);
    }
}
