﻿using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess
{
    public interface IProductDal:IEntityRepository<Product>
    {
        
    }
}
