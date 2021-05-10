﻿using Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess.EntityFramework
{
    public class EfEntityRepositoryBase<TEntity , TContext> :IEntityRepository<TEntity>

        where TEntity: class,IEntity,new()
        where TContext : DbContext , new()

    {
        public void Add(TEntity entity)
        {
            using (TContext context = new TContext())
            {

                //referansa ulaşmak lazım
                //Veri kaynağı ile ilişkilendirdik.Referansı yakala
                var addedEntiy = context.Entry(entity);
                //Durumuna karar ver.Bu eklenecek bir nesne
                addedEntiy.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var deletedEntiy = context.Entry(entity);
                deletedEntiy.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            using (TContext context = new TContext())
            {
                return context.Set<TEntity>().SingleOrDefault(filter);

            }

        }

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {


            using (TContext context = new TContext())
            {
                return filter == null ? context.Set<TEntity>().ToList() : context.Set<TEntity>().Where(filter).ToList();

            }

        }

        public void Update(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var updatedEntiy = context.Entry(entity);
                updatedEntiy.State = EntityState.Modified;
                context.SaveChanges();
            }
        }

    }
}
