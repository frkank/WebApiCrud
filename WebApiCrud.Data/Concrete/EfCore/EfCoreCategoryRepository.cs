using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApiCrud.Data.Abstract;
using WebApiCrud.Entity;

namespace WebApiCrud.Data.Concrete.EfCore
{
    public class EfCoreCategoryRepository : EfCoreGenericRepository<Category, WebApiCrudContext>, ICategoryRepository
    {

    }
}
