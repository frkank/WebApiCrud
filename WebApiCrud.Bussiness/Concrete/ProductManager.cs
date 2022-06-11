using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApiCrud.Bussiness.Abstract;
using WebApiCrud.Data.Abstract;
using WebApiCrud.Entity;

namespace WebApiCrud.Bussiness.Concrete
{
    public class ProductManager : IProductService
    {
        private IProductRepository _productRepository;
        public ProductManager(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        public void Create(Product entity)
        {
            throw new NotImplementedException();
        }

        public void Create(Product entity, int[] categoryIds)
        {
            _productRepository.Create(entity, categoryIds);
        }

        public void Delete(Product entity)
        {
            _productRepository.Delete(entity);
        }

        public List<Product> GetAll()
        {
            return _productRepository.GetAll().ToList();
        }

        public Product GetById(int productId)
        {
            return _productRepository.GetById(productId);
        }

        public void Update(Product entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Product entity, int[] categoryIds)
        {
            _productRepository.Update(entity, categoryIds);
        }
    }
}
