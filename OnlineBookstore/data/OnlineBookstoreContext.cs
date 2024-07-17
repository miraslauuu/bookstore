using Microsoft.EnityFrameworkCore;

namespace OnlineBookstore.Data
{
        
        public class OnlineBookstoreContext : DbContext //class OnlineBookstoreContext inherits from DbContext
        {
            public OnlineBookstoreContext(DbContextOptions<OnlineBookstoreContext> options) : base(options) //constructor for the OnlineBookstoreContext that takes options as a parameter and calls the base class
            {

            }

            //DbSet is used to perfom CRUD (Create, Read, Update, Delete)
            public DbSet<User> Users{get; set;}
            public DbSet<Book> Books {get; set;}
            public DbSet<Order> Orders {get; set;}
            public DbSet<OrderDetail> OrderDetails {get; set;}
            public DbSet<Review> Reviews {get; set;}

            protected override void OnModelCreating(ModelBuilder modelBuilder){
                base.OnModelCreating(modelBuilder);
            }

        }

    
}