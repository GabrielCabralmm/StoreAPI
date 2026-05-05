using Microsoft.EntityFrameworkCore;
using StoreAPI_CP2.Entities;

namespace AspNET.API.Data
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {

        }

        public DbSet<ClienteEntity> Cliente { get; set; }
        public DbSet<ProdutoEntity> Produto { get; set; }
    }
}
