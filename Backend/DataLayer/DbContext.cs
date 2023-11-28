using Microsoft.EntityFrameworkCore;
using HZS.Models;

public class Context:DbContext
{
    public DbSet<User> users { get; set; }
    public DbSet<Post> posts { get; set; }

    //Promeniti "Server=DESKTOP-K8R1ERQ" na "Server = {DeviceName} da bi radilo!
    protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlServer("Server=DESKTOP-K8R1ERQ\\SQLEXPRESS;Database=model;Trusted_Connection=True; TrustServerCertificate=True;");
}
