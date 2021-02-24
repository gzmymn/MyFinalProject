using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal; //bağımlılığımızı minimize ediyoruz, bağımlılığımı contructor injection ile yapıyorum

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public IDataResult<List<Category>> GetAll()
        {
            //İş kodları
            return new SuccessDataResult<List<Category>> (_categoryDal.GetAll());
        }

        //Select * from Categories where categoyId = 3
        //bu kod bunu çalıştırır
        public IDataResult<Category> GetById(int categoryId)
        {
            return new SuccessDataResult<Category> (_categoryDal.Get(c=>c.CategoryId == categoryId));
        }
    }
}
