using System.Data.Entity;

namespace test_csharp
{
    public class UserContext : DbContext
    {
        public UserContext()
            : base("test2")
        { }

        public DbSet<User> Users { get; set; }
    }

}
