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
        void Update(CoverTypeRepository coverType);
        void Update(CoverType coverType);
        void Remove(CoverType objFromDb);
    }
}
