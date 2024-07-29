using GraphQLAPI.Infra.Models;
using Microsoft.EntityFrameworkCore;

namespace GraphQLAPI.Infra
{
    public class DataDBContext : DbContext
    {
        public DataDBContext(DbContextOptions<DataDBContext> options) : base(options)
        {
        }

        public DbSet<SupplierModel> Suppliers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //อันนี้ ถ้าไม่อยากให้มันสร้า่ง เดว Comment ออก
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<SupplierModel>().HasData(
                new SupplierModel
                {
                    Id = 1,
                    FirstName = "John",
                    LastName = "Doe",
                    Address = "123 Main St",
                    Email = "John@exam,ple.com",
                    Phone = "123-456-7890"
                },
                new SupplierModel
                {
                    Id = 2,
                    FirstName = "Jane",
                    LastName = "Doe",
                    Address = "123 Main St",
                    Email = "Jane@exam,ple.com",
                    Phone = "123-456-7890"
                });
        }
    }
}