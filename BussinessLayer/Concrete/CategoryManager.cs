using BussinessLayer.Abstarct;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFrameWork;
using EntityLayer.ConcrEte;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {
        EfCategoryRepository efCategoryRepository;
        public CategoryManager(ICategoryDal categoryDal)
        {
            efCategoryRepository = new EfCategoryRepository();
        }

        public void CategoryAdd(Category category)
        {
            efCategoryRepository.Insert(category);
        }

        public void CategoryDelete(Category category)
        {
            efCategoryRepository.Delete(category);

        }

        public void CategoryUpdate(Category category)
        {
            efCategoryRepository.Update(category);
        }

        public List<Category> GetAll()
        {
            return efCategoryRepository.GetAll();
        }

        public Category GetById(int id)
        {
            return efCategoryRepository.GetById(id);
        }
    }
}
