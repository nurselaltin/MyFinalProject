using Business.Abstract;
using Business.Abstract.SenturklerService;
using DataAccess.Abstract;
using DataAccess.Abstract.SenturklerDal;
using Entities.Concrete;
using Entities.Concrete.Senturkler;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete.Senturkler
{
    public class STOK_KartiManager : ISTOK_KartiService
    {

        //IProductDal -> EfProductDal a ulaşacak.EfProductDal ise verilere ulaşacak.
        ISTOK_KartiDal  _sTOK_KartiDal;

        //IProductDal referansı ver 
        public STOK_KartiManager(ISTOK_KartiDal sTOK_KartiDal)
        {
            _sTOK_KartiDal = sTOK_KartiDal;
        }
        public List<STOK_Karti> GetAll()
        {
            //İş kodları
            //Yetkisi var mı

            return _sTOK_KartiDal.GetAll();

        }

        //public List<Product> GetAllByCategory(int id)
        //{
        //    return _productDal.GetAll(p=>p.CategoryId == id);
        //}

        //public List<Product> GetByUnitPrice(decimal min, decimal max)
        //{
        //    return _productDal.GetAll(p=>p.UnitPrice >= min && p.UnitPrice <= max);
        //}

      

        //List<STOK_Karti> ISTOK_KartiService.GetAllByCategory(int id)
        //{
        //    throw new NotImplementedException();
        //}

        //List<STOK_Karti> ISTOK_KartiService.GetByUnitPrice(decimal min, decimal max)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
