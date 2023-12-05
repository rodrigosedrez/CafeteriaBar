using Microsoft.EntityFrameworkCore;

namespace CafeteriaFacul_net7.Data
{
    public class ProdutoDataContext : DbContext
    {
        public DbSet<Produto> Produtoss { get; set; } = null!;

        public ProdutoDataContext(DbContextOptions<ProdutoDataContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            Produto produtos = new Produto
            {
                Id=1,
                ImageSource = " ",
                Name = "Café Preto",
                Description = "Café tradicional passado e suave.",
            }

            ;

            modelBuilder.Entity<Produto>().HasData(produtos);
        }
    }
}
