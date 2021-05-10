using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Abstract.SenturklerDal;
using Entities.Concrete;
using Entities.Concrete.Senturkler;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework.EfSenturkler
{
    public class EfSTOK_KartiDal : EfEntityRepositoryBase<STOK_Karti , SenturklerContext> , ISTOK_KartiDal
    {
       

    }
}
