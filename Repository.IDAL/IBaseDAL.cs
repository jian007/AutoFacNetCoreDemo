using System;
using System.Collections.Generic;
using System.Linq;

namespace Repository.IDAL
{
    public interface IBaseDAL<T> where T:class
    {
        IQueryable<T> GetList();

        int AddListAsync(List<T> ts);
    }
}
