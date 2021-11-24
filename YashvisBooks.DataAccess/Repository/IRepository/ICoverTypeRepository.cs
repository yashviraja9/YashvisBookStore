using YashvisBooks.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YashvisBooks.DataAccess.Repository.IRepository
{
    public interface ICoverTypeRepository : IRepository<CoverType>
    {
        void Update(CoverTypeRepository product);
        void Update(Product product);
        void Remove(Product objFromDb);
        void Update(CoverType coverType);
        void Remove(CoverType objFromDb);
        void Add(Product product);
    }
}
