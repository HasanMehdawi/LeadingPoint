using leadingPointDataClass.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leadingPointDataAccess.generic
{
    public class generic<T>:Igeneric<T> where T:class
    {
        LeadingPointContext context;
        public generic(LeadingPointContext _context)
        {
            context = _context;
        }
        public void Insert(T obj)
        {
            context.Set<T>().Add(obj);
            context.SaveChanges();
        }
        public void update(T obj)
        {
            context.Set<T>().Attach(obj);
            context.Entry(obj).State = EntityState.Modified;
            context.SaveChanges();
        }
        public void delete(int id)
        {
            T obj = context.Set<T>().Find(id);
            context.Set<T>().Remove(obj);
            context.SaveChanges();
        }
        public T Load(int id)
        {
            return context.Set<T>().Find(id);
        }
        public List<T> LoadAll()
        {
            return context.Set<T>().ToList();
        }
    }
}
