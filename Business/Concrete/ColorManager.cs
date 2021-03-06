using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ColorManager : IColorService
    {
        IColorDal _colorDal;

        public ColorManager (IColorDal colorDal)
        {
            _colorDal = colorDal;
        }
        public void Delete(Color color)
        {
            _colorDal.Delete(color);
        }

        public List<Color> GetAll()
        {
            return _colorDal.GetAll();
        }

        public Color GetById(int colorId)
        {
            return _colorDal.Get(x => x.ColorId == colorId);
        }

        public void Insert(Color color)
        {
            _colorDal.Add(color);
        }

        public void Uptade(Color color)
        {
            _colorDal.Uptade(color);
        }
    }
}
