using Balta.Domain.Entities;
using System.Data.Entity;

namespace Balta.Data.Contexts
{
    public class BaltaDataContext : DbContext
    {
        public BaltaDataContext()
            : base("BaltaConnectionString")
        { }

        public DbSet<User> Users { get; set; }
    }
}
