using Microsoft.EntityFrameworkCore;
using PetFinder.Models;

namespace PetFinder.Data
{
    public class BancoContext : DbContext
    {
        public BancoContext(DbContextOptions<BancoContext> options) : base(options)
        {

        }

        public DbSet<PetModel> Pets { get; set; }
        public DbSet<UserModel> Users { get; set; }
    }
}
