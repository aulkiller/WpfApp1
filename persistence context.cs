using MySql.Data.EntityFramework;
using System.Data.Entity;

namespace LatihanMVVM
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    class LatihanContext : DbContext
    {
        public DbSet<ItemPenjualan> DaftarItemPenjualan { get; set; }
    }
}