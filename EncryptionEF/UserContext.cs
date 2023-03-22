using EntityFrameworkCore.EncryptColumn.Extension;
using EntityFrameworkCore.EncryptColumn.Interfaces;
using EntityFrameworkCore.EncryptColumn.Util;
using Microsoft.EntityFrameworkCore;

namespace EncryptionEF
{
    public class UserContext : DbContext
    {
        private IEncryptionProvider _provider;
        public UserContext(DbContextOptions<UserContext> options):base(options)
        {
            _provider = new GenerateEncryptionProvider("JaNdRgUkXp2s5v8y");
        }
        public DbSet<User> Users { get;set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseEncryption(_provider);
        }
    }
}
