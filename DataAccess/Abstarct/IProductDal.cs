using System;
using System.Collections.Generic;
using System.Text;
using Core.DataAccess;
using Entities.Concrete;

namespace DataAccess.Abstarct
{
    public interface IProductDal:IEntityRepository<Product>
    {

        //Sadece product ait işleri buraya yazacağız

    }
}
