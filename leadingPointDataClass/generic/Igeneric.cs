using System;
using System.Collections.Generic;
using System.Text;

namespace leadingPointDataAccess.generic
{
    public interface Igeneric<T> where T:class
    {
        void Insert(T obj);
        void update(T obj);
        void delete(int id);
        T Load(int id);
        List<T> LoadAll();
    }
}
