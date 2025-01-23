using Microsoft.EntityFrameworkCore;

namespace Vivaldikafe1.Models;

public class MyAppContext:DbContext
{
    public DbSet<Musteri> musteriler {get;set;}
    public DbSet<SogukKahve> sogukKahves {get;set;}
    public DbSet<SýcakKahve> sýcakKahves {get;set;}
    public DbSet<SandTat> sandTats {get;set;}
    public DbSet<User> users {get;set;}


protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
{

    string conStr = "server=MERT\\SQLEXPRESS;database=VivaldiCafeDB;Trusted_Connection=True; TrustServerCertificate=true";
        optionsBuilder.UseSqlServer(conStr);
}

    
}