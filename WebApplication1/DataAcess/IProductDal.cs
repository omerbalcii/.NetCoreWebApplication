using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Entities;

namespace WebApplication1.DataAcess
{
    public interface IProductDal:IEntityRepository<Product>
    {

    }

} 
