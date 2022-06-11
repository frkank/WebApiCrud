using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApiCrud.Entity;

namespace WebApiCrud.Bussiness.Abstract
{
    public interface IProductService
    {
        Product GetById(int productId);
        List<Product> GetAll();
  
        void Create(Product entity);
        void Delete(Product entity);
        void Update(Product entity);
        void Create(Product entity, int[] categoryIds);
        void Update(Product entity, int[] categoryIds);
    }
}
