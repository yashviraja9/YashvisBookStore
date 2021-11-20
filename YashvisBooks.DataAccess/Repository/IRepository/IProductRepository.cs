﻿using YashvisBooks.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YashvisBooks.DataAccess.Repository.IRepository
{
    public interface IProductRepository : IRepository<Product>
    {
        void Update(ProductRepository coverType);
        void Update(CoverType coverType);
        void Remove(CoverType objFromDb);
        void Add(object product);
        void Remove(Product objFromDb);
    }
}