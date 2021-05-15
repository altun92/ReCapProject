using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class BrandManager : IBrandService
    {
        IBrandDal _brandDal;

        public BrandManager (IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }
        public void Delete(Brand brand)
        {
            _brandDal.Delete(brand);
        }

        public List<Brand> GetAll()
        {
            return _brandDal.GetAll();
        }

        public Brand GeyById(int brandId)
        {
            return _brandDal.Get(x => x.BrandId == brandId);
        }

        public void Insert(Brand brand)
        {
            _brandDal.Add(brand);
        }

        public void Uptade(Brand brand)
        {
            _brandDal.Uptade(brand);
        }
    }
}
