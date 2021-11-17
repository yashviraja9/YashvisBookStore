using YashvisBooks.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YashvisBooks.DataAccess.Repository.IRepository
{
    public interface ICategoryRepository : IRepository<Category>
    {
        void Update(CategoryRepository category);
        void Update(Category category);
        void Remove(Category objFromDb);
        void Update(CoverType coverType);
        void Add(CoverType coverType);
    }
}
