using System.Data.Entity;
using WebApplication1.Models;

namespace WebApplication1.DataAccessLayer
{
    public class SalesERPDAL : DbContext
    {
        public SalesERPDAL() : base("SalesERPDAL")
        {
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //“TblEmployee” represents the table name. It automatically get created in runtime.
            modelBuilder.Entity<Employee>().ToTable("TblEmployee");
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Employee> Employees { get; set; }
    }
}