using System.Data.Entity;

namespace LatihanMVVM
{
    class LatihanContext : DbContext
    {
        public DbSet<ItemPenjualan> DaftarItemPenjualan { get; set; }
    }
}