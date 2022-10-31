using Microsoft.EntityFrameworkCore;

namespace DecoderDesignPatternSample.TestDbContextRepository
{
    public class TestDbContext : DbContext
    {

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
        public override int SaveChanges()
        {
            //LOGLAMA İŞLEMİ 
            return base.SaveChanges();
        }

    }
}
