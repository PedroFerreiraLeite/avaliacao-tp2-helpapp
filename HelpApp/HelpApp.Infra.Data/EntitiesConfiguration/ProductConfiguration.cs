using HelpApp.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HelpApp.Infra.Data.EntitiesConfiguration
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(t => t.Id);
            builder.Property(p => p.Name).HasMaxLength(100).IsRequired();
            builder.Property(p => p.Description).HasMaxLength(200).IsRequired();

            builder.Property(p => p.Price).HasPrecision(10, 2);
            builder.Property(p => p.Image).HasMaxLength(250).IsRequired();
            builder.Property(p => p.Stock).IsRequired();

            builder.HasOne(e => e.Category).WithMany(e => e.Products)
                .HasForeignKey(e => e.CategoryId);

            builder.HasData(
                new Product
                {
                    Id = 1,
                    Name = "Agenda Executiva",
                    Description = "Agenda de couto sintético com 500 páginas",
                    Price = 49.50m,
                    Stock = 60,
                    Image = "agenda.jpg",
                    CategoryId = 1
                },
                new Product
                {
                    Id = 2,
                    Name = "Caixa de Som Bluetooth",
                    Description = "Caixa de som portátil à prova d'água",
                    Price = 189.50m,
                    Stock = 40,
                    Image = "caixa-som.jpg",
                    CategoryId = 2
                },

                new Product
                {
                    Id = 3,
                    Name = "Pulseira Inteligente",
                    Description = "Pulseira fitness com monitoramento de batimentos e passos",
                    Price = 99.90m,
                    Stock = 120,
                    Image = "pulseira-inteligente.jpg",
                    CategoryId = 3
                }

                );
        }
    }
}
