using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Profilz.Models
{
    public class Dal : DbContext
    {
        private static Dal _db;
        #region Tables
        public DbSet<User> Users { get; set; }
        #endregion
        public static Dal Db
        {
            get
            {
                if (_db == null)
                    _db = new Dal(); /*singleton*/
                return _db;
                

                
            }
        }

        public Dal()
            :base("mainContext")
        {

        }

        public Dal(string nameOfConnectionString) : base(nameOfConnectionString)
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<Dal>());
        }

    }
}