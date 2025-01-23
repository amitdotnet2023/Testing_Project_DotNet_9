using Microsoft.EntityFrameworkCore;
using TestingProject.Models;

namespace TestingProject
{
    public class TestDBContext : DbContext
    {
        public TestDBContext(DbContextOptions<TestDBContext> options) : base(options)
        {

        }


        public DbSet<UserMaster> UserMaster { get; set; }

    }
}
