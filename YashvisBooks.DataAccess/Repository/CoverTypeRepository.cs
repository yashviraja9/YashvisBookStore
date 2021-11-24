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
    public class CoverTypeRepository : Repository<CoverType>, ICoverTypeRepository
    {
        private readonly ApplicationDbContext _db;

        public CoverTypeRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Add(Product product)
        {
            throw new NotImplementedException();
        }

        public void Remove(Product objFromDb)
        {
            throw new NotImplementedException();
        }

        public void Upadte(CoverType coverType)
        {
            //use .NET LINQ to retrieve the first or default Cover Type object,
            // then pass the id as a generic entity which matches the cover type ID
            var objFromDb = _db.CoverTypes.FirstOrDefault(s => s.Id == coverType.Id);
            if (objFromDb != null)
            {
                objFromDb.Name = coverType.Name;
                //_db.SaveChanges();
            }
        }

        public void Update(CoverTypeRepository coverType)
        {
            throw new NotImplementedException();
        }
        public void Update(CoverType coverType)
        {
            throw new NotImplementedException();
        }

        public void Update(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
