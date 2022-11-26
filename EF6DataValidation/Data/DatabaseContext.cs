using EF6DataValidation.Models;
using Microsoft.EntityFrameworkCore;

namespace EF6DataValidation.Data
{
    public class DatabaseContext: DbContext
    {
        public DatabaseContext(DbContextOptions options) : base(options)
        {
        }

        DbSet<Phone> Phones { get; set; }

        public async Task Insert(Phone phone)
        {
            await Phones.AddAsync(phone);
            await SaveChangesAsync();
        }
        public async Task<Phone?> Get(Guid id)
        {
            return await Phones.FindAsync(id);
        }
        public async Task Update(Phone phone)
        {
            Phones.Update(phone);
            await SaveChangesAsync();
        }
    }
}
