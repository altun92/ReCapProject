﻿using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFrameworks
{
    public class EfCarDal : ICarDal
    {
        private object modifiedEntity;
        private object uptatedEntity;

        public void Add(Car entity)
        {
            using (ReCapDataContext context = new ReCapDataContext())
            {
                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(Car entity)
        {
            using (ReCapDataContext context = new ReCapDataContext())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            using (ReCapDataContext context=new ReCapDataContext())
            { 
                return filter == null ? context.Set<Car>().ToList() : 
                context.Set<Car>().Where(filter).ToList(); 
            }
        }

        public void Uptade(Car entity)
        {
            using (ReCapDataContext context = new ReCapDataContext())
            {
                var updatedEntity = context.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}