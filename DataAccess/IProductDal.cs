using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess
{
    public interface IProductDal
    {
        List<Product> GetAllByCategory(int categoryId);
        List<Product> GetAll();

        void Add(Product product);
        void Delete(Product product);
        void Update(Product product);
    }
}
