using Microsoft.EntityFrameworkCore;
using Persistance.Entities;

namespace Persistance.Context
{
    public class DatabaseContext : DbContext
    {
        DbSet<Profile> Profiles { get; set; }
    }
}