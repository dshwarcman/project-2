using Microsoft.EntityFrameworkCore;
using Project_2.Models;

namespace Project_2.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options){}
        public DbSet<Value> Values {get; set;}
        public DbSet<Message> Messages {get; set;}
        public DbSet<User> Users { get; set; }

    }
}