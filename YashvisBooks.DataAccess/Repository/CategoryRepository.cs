using YashvisBooks.DataAccess.Repository.IRepository;
using YashvisBooks.Models;
using YashvisBookStore.DataAccess.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YashvisBooks.DataAccess.Repository
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        private readonly ApplicationDbContext _db;

        public CategoryRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Add(CoverType coverType)
        {
            throw new NotImplementedException();
        }

        public void Upadte(Category category)
        {
            //use .NET LINQ to retrieve the first or default category object,
            // then pass the id as a generic entity which matches the category ID
            var objFromDb = _db.Categories.FirstOrDefault(s => s.Id == category.Id);
            if(objFromDb != null)
            {
                objFromDb.Name = category.Name;
                //_db.SaveChanges();
            }
        }

        public void Update(CategoryRepository category)
        {
            throw new NotImplementedException();
        }
        public void Update(Category category)
        {
            throw new NotImplementedException();
        }

        public void Update(CoverType coverType)
        {
            throw new NotImplementedException();
        }
    }
}
