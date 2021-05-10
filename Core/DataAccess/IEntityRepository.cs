using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using Core.Entities;

namespace Core.DataAccess
{

    /*T  sınırlandırma : Generic Constraint
     * - Class yazılabilsin
     * - Sadece Entties katmanındaki sınıflar yazılabilsin istiyoruz.Onlarında ortak noktası IEntity
     * - IEntity newlemez.Böylelikle Sadece Entities sınıfları yazılabilir hale geldi yapımız.
     
    
     
     */
    public interface IEntityRepository<T> where T:class,IEntity,new()
    {

        //Filtreleyerek listele
        //Linq ile gelen Expression  ifadesi
        //_productDal.GetAll(p=>p.ıd);  sağlar
        List<T> GetAll(Expression<Func<T,bool>> filter=null);
        T Get(Expression<Func<T,bool>> filter);

        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    


    }
}
