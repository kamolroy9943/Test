using DatingApp.Api.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace DatingApp.Api.Data
{
    public class TestContext : DbContext
    {
        public TestContext(DbContextOptions<TestContext> options) : base(options)
        {
        }

        public DbSet<Person> Persons { get; set; }
    }
}