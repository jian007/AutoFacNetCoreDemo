
using Microsoft.EntityFrameworkCore;
using ModelsEntity;
using Repository.IDAL;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Repository.DAL
{
    public class BaseDAL<T> : IBaseDAL<T> where T:class
    {

        BaseDbContex BaseDbContex = new BaseDbContex();

        public DbSet<T> iset { get; set; }
        public BaseDAL()
        {
            iset = BaseDbContex.Set<T>();
        }
        IQueryable<T> IBaseDAL<T>.GetList()
        {
            return iset;
        }

        public int AddListAsync(List<T> ts)
        {
            //iset.AddRangeAsync(ts);
            return  0;
        }
    }
}
