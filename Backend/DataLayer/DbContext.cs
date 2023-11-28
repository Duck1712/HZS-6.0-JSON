using Microsoft.EntityFrameworkCore;
using HZS.Models;

public class Context:DbContext
{
    public DbSet<User> users { get; set; }
    public DbSet<Post> posts { get; set; }
    
    public string DbPath { get; }

    public Context()
    {
        var folder = Environment.SpecialFolder.LocalApplicationData;
        var path = Environment.GetFolderPath(folder);
        DbPath = Path.Join(path, "sportBlog.db");
    }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlServer($"Data Source={DbPath}");

}
