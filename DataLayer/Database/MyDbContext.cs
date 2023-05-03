using Microsoft.EntityFrameworkCore;
using Welcome.Model;
using Welcome.Others;

namespace Datalayer.Database;

public class MyDbContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
        string folder = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        string datafile = "ps1.db";
        var databasePath = Path.Combine(folder, datafile);
        optionsBuilder.UseSqlite($"Data Source={databasePath}");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>().Property(x => x.Id).ValueGeneratedOnAdd();

        var user = new User
        {
            Id = 1,
            Email = "tu@tu.bg",
            FacultyNumber = "k1j2kl1j",
            Names = "Test Admin",
            Password = "123",
            Role = UserRolesEnum.Admin
        };

        modelBuilder.Entity<User>().HasData(user);

        base.OnModelCreating(modelBuilder);
    }

    public DbSet<User> Users { get; set; }
}