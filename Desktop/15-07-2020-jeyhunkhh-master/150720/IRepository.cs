using System;
using System.Collections.Generic;
using System.Text;

namespace _150720
{
    interface IRepository<T>
    {
        void Insert(T item);
        List<T> GetAll();
        T GetById(int id);
        void Update(T item);
        void Delete(int id);
    }
}
