using Entities.Concrete.Senturkler;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class SenturklerContext : DbContext
    {


        public DbSet<STOK_Karti> STOK_Karti { get; set; }


        //Hangi db ile ilişkilendireceğimiz metottur.
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;Database=FIRMA21;Trusted_Connection=true");
        }



    }
}
