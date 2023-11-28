using Microsoft.EntityFrameworkCore;
using HZS.Models;

public class Context:DbContext
{
    public DbSet<User> users { get; set; }

}
