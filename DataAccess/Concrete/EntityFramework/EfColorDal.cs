﻿using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfColorDal : EfEntityRepositoryBase<Color, ReCapContext>, IColorDal
    {
        //public void Add(Color entity)
        //{
        //    // IDısposable implementation of C#
        //    using (ReCapContext context = new ReCapContext())
        //    {
        //        var addedEntity = context.Entry(entity);
        //        addedEntity.State = EntityState.Added;
        //        context.SaveChanges();
        //    }
        //}

        //public void Delete(Color entity)
        //{
        //    using (ReCapContext context = new ReCapContext())
        //    {
        //        var deletedEntity = context.Entry(entity);
        //        deletedEntity.State = EntityState.Deleted;
        //        context.SaveChanges();
        //    }
        //}

        //public Color Get(Expression<Func<Color, bool>> filter)
        //{
        //    using (ReCapContext context = new ReCapContext())
        //    {
        //        return context.Set<Color>().SingleOrDefault(filter);
        //    }
        //}

        //public List<Color> GetAll(Expression<Func<Color, bool>> filter = null)
        //{
        //    using (ReCapContext context = new ReCapContext())
        //    {
        //        return filter == null ? context.Set<Color>().ToList() : context.Set<Color>().Where(filter).ToList();
        //    }
        //}

        //public List<Color> GetById(int Id)
        //{
        //    throw new NotImplementedException();
        //}

        //public void Update(Color entity)
        //{
        //    using (ReCapContext context = new ReCapContext())
        //    {
        //        var updatedEntity = context.Entry(entity);
        //        updatedEntity.State = EntityState.Modified;
        //        context.SaveChanges();
        //    }
        //}
    }
}
