using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApiCrud.Entity;

namespace WebApiCrud.Data.Abstract
{
    public interface IProductRepository : IRepository<Product>
        //Product'a özgün olanlar burada yapılabilir.
    {
        void Create(Product entity, int[] categoryIds);
        void Update(Product entity, int[] categoryIds);
        Product GetByIdWithCategories(int id);
    }
}
