using Microsoft.EntityFrameworkCore;
using Stable.Models;

namespace Stable.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Booking>().HasOne(c => c.Land).WithMany(c => c.Bookings)
                .HasForeignKey(b => b.LandId)
                .OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<Booking>().HasOne(c => c.Horse).WithMany(c => c.Bookings)
           .HasForeignKey(b => b.HorseId)
           .OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<Booking>().HasOne(c => c.Trainer).WithMany(c => c.Bookings)
           .HasForeignKey(b => b.TrainerId)
           .OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<Photo>().HasOne(c => c.Land).WithMany(c => c.Photos)
           .HasForeignKey(b => b.LandId)
           .OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<Photo>().HasOne(c => c.Owner).WithMany(c => c.Photos)
        .HasForeignKey(b => b.OwnerId)
        .OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<Photo>().HasOne(c => c.Trainer).WithMany(c => c.Photos)
        .HasForeignKey(b => b.TrainerId)
        .OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<Photo>().HasOne(c => c.Horse).WithMany(c => c.Photos)
        .HasForeignKey(b => b.HorseId)
        .OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<Photo>().HasOne(c => c.CarePachage).WithMany(c => c.Photos)
        .HasForeignKey(b => b.CarePachageId)
        .OnDelete(DeleteBehavior.NoAction);
        }
        public DbSet<CarePachage> CarePachages { get; set; }
        public DbSet<Horse> Horses { get; set; }
        public DbSet<Booking> Bookings { get; set; }
       public DbSet<Owner> Owners { get; set; }
        public DbSet<Land> Lands { get; set; }
        public DbSet<Trainer> Trainers { get; set; }
    }
}
