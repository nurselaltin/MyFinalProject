﻿using Business.Abstract;
using DataAccess.Abstarct;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal;


        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }
        public List<Category> GetAll()
        {
            return _categoryDal.GetAll();
        }

        public Category GetById(int categoryId)
        {

            return _categoryDal.Get(x => x.CategoryId == categoryId);
        }

        public List<Category> GetByUnitPrice(decimal min, decimal max)
        {
            throw new NotImplementedException();
        }
    }
}