using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Reflection;
using System.Data.Entity.ModelConfiguration;
using TopPro.Domain.Model;

namespace TopPro.Data
{
    public class DataContext : DbContext, IDbContext
    {
        public new IDbSet<TEntity> Set<TEntity>() where TEntity : class
        {
            return base.Set<TEntity>();
        }

      
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public virtual DbSet<MA001> MA001s { get; set; }
        public virtual DbSet<MA002> MA002s { get; set; }
        public virtual DbSet<MA003> MA003s { get; set; }
        public virtual DbSet<MA004> MA004s { get; set; }
        public virtual DbSet<MA005> MA005s { get; set; }
        public virtual DbSet<MA006> MA006s { get; set; }
        public virtual DbSet<MA007> MA007s { get; set; }
    }
}
