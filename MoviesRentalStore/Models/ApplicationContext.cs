using System.Data.Entity;

namespace MoviesRentalStore.Models
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext() : base("constr")
        {


        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<MemberShipType> MemberShipTypes { get; set; }


    }
}
