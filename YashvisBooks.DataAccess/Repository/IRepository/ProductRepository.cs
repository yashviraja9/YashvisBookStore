using YashvisBooks.DataAccess.Repository.IRepository;
using YashvisBooks.Models;
using YashvisBookStore.DataAccess.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YashvisBooks.DataAccess.Repository.IRepository
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        private readonly ApplicationDbContext _db;

        public ProductRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Add(CoverType coverType)
        {
            throw new NotImplementedException();
        }

        public void Update(Product product)
        {
            var objFromDb = _db.Products.FirstOrDefault(s => s.Id == product.Id);
            if (objFromDb != null)  // save changes if not null
            {
                if (product.ImageUrl != null)
                {
                    objFromDb.ImageUrl = product.ImageUrl;      // add the check for ImageUrl
                }
                objFromDb.Title = product.Title;
                objFromDb.Description = product.Description;
                objFromDb.ISBN = product.ISBN;
                objFromDb.Author = product.Author;
                objFromDb.ListPrice = product.ListPrice;
                objFromDb.CategoryId = product.CategoryId;
                objFromDb.CoverTypeId = product.CoverTypeId;    // all properties of Product object

            }
        }

        public void Remove(CoverType objFromDb)
        {
            throw new NotImplementedException();
        }

        public void Update(ProductRepository coverType)
        {
            throw new NotImplementedException();
        }

        public void Update(CoverType coverType)
        {
            throw new NotImplementedException();
        }
    }
}
