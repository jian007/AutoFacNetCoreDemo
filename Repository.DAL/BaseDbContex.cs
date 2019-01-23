using DataModels;
using LinqToDB.Configuration;
using LinqToDB.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository.DAL
{
    public class BaseDbContex:DbContext
    {
        public BaseDbContex() : base()
        {
            
        }

        //public BaseDbContex(DbContextOptions<BaseDbContex> dbContextOptions) : base(dbContextOptions)
        //{

        //}
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //base.OnConfiguring(optionsBuilder.UseMySql(@"server=127.0.0.1;userid=root;password=root;port=3306;database=autofacdemo;allowPublicKeyRetrieval=true;Character Set=utf8;"));
            base.OnConfiguring(optionsBuilder.UseMySql(@"sdata source=DESKTOP-JIAN\MSSQLSERVER_2;initial catalog=Autofacdemo;user id=sa;password=123"));

        }
    }

}




