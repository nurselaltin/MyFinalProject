using System;
using System.Collections.Generic;
using System.Text;
using Entities.Concrete;

namespace DataAccess.Abstarct
{
    public interface IProductDal:IEntityRepository<Product>
    {
    }
}
