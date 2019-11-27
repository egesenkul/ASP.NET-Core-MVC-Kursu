using Senkul.Core.DataAccess.EntityFramework;
using Senkul.Database.DataAccess.Abstract;
using Senkul.Database.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Senkul.Database.DataAccess.Concrate.EntityFramework
{
    public class EfCategoryDal : EfEntityRepositoryBase<Category, NorthwindContext>, ICategoryDal
    {

    }
}
