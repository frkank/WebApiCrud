using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApiCrud.Data.Abstract;
using WebApiCrud.Entity;

namespace WebApiCrud.Data.Concrete.EfCore
{
    public class EfCoreProductRepository : EfCoreGenericRepository<Product, WebApiCrudContext>, IProductRepository
    {
        public void Create(Product entity, int[] categoryIds)
        {
            using (var context = new WebApiCrudContext())
            {
                context.Products.Add(entity);
                context.SaveChanges();
                entity.ProductCategories = categoryIds
                    .Select(catId => new ProductCategory
                    {
                        ProductId = entity.ProductId,
                        CategoryId = catId
                    }).ToList();
                context.SaveChanges();
            }
        }

        public Product GetByIdWithCategories(int id)
        {
            using (var context = new WebApiCrudContext())
            {
                return context
                    .Products
                    .Where(i => i.ProductId == id)
                    .Include(i => i.ProductCategories)
                    .ThenInclude(i => i.Category)
                    .FirstOrDefault();
            }
        }

        public void Update(Product entity, int[] categoryIds)
        {
            using (var context = new WebApiCrudContext())
            {
                var product = context
                    .Products
                    .Include(i => i.ProductCategories)
                    .FirstOrDefault(i => i.ProductId == entity.ProductId);
                product.ProductName = entity.ProductName;
                product.ProductPrice = entity.ProductPrice;
                product.ProductDescription = entity.ProductDescription;
                product.CreateDate=entity.CreateDate;
                product.ProductCategories = categoryIds
                    .Select(catId => new ProductCategory()
                    {
                        ProductId = entity.ProductId,
                        CategoryId = catId
                    }).ToList();
                context.SaveChanges();
            }
        }
    }
}
