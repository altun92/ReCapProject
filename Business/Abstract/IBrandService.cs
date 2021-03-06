using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IBrandService
    {
        List<Brand> GetAll();
        Brand GeyById(int brandId);
        void Insert(Brand brand);
        void Delete(Brand brand);
        void Uptade(Brand brand);
    }
}
