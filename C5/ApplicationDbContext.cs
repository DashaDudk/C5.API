using FitnessSystem.Models; 
using Microsoft.EntityFrameworkCore;

public partial class ApplicationDbContext : DbContext
{
    public ApplicationDbContext()
    {
    }

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Trainer> Trainers { get; set; }
    public virtual DbSet<Client> Clients { get; set; }
    public virtual DbSet<Workout> Workouts { get; set; }
    public virtual DbSet<Membership> Memberships { get; set; }
    public virtual DbSet<Gym> Gyms { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSqlLocalDb;Database=FitnessSystem;Trusted_Connection=True;TrustServerCertificate=True;");
        }
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder); 

        modelBuilder.Entity<Trainer>()
            .HasMany(t => t.Clients)
            .WithOne(c => c.Trainer)
            .HasForeignKey(c => c.TrainerID)
            .OnDelete(DeleteBehavior.NoAction); 

        modelBuilder.Entity<Trainer>()
       .HasOne(t => t.Gym) 
       .WithMany(g => g.Trainers) 
       .HasForeignKey(t => t.GymID) 
       .OnDelete(DeleteBehavior.NoAction); 

        modelBuilder.Entity<Client>()
            .HasMany(c => c.Workouts)
            .WithOne(w => w.Client)
            .HasForeignKey(w => w.ClientID)
            .OnDelete(DeleteBehavior.NoAction);

        modelBuilder.Entity<Client>()
            .HasMany(c => c.Memberships)
            .WithOne(m => m.Client)
            .HasForeignKey(m => m.ClientID)
            .OnDelete(DeleteBehavior.NoAction); 
    }
}