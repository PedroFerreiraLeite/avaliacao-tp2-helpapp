﻿// <auto-generated />
using HelpApp.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace HelpApp.Infra.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20250427213133_Initial")]
    partial class Initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.20")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("HelpApp.Domain.Entities.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Material Escolar"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Eletronicos"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Acessórios"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Higiene Pessoal"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Alimento Não Perecíveis"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Brinquedos"
                        },
                        new
                        {
                            Id = 7,
                            Name = "Roupas"
                        },
                        new
                        {
                            Id = 8,
                            Name = "Móveis"
                        },
                        new
                        {
                            Id = 9,
                            Name = "Livros"
                        },
                        new
                        {
                            Id = 10,
                            Name = "Esporte e Lazer"
                        });
                });

            modelBuilder.Entity("HelpApp.Domain.Entities.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<decimal>("Price")
                        .HasPrecision(10, 2)
                        .HasColumnType("decimal(10,2)");

                    b.Property<int>("Stock")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            Description = "Agenda de couto sintético com 500 páginas",
                            Image = "agenda.jpg",
                            Name = "Agenda Executiva",
                            Price = 49.50m,
                            Stock = 60
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 2,
                            Description = "Caixa de som portátil à prova d'água",
                            Image = "caixa-som.jpg",
                            Name = "Caixa de Som Bluetooth",
                            Price = 189.50m,
                            Stock = 40
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 3,
                            Description = "Pulseira fitness com monitoramento de batimentos e passos",
                            Image = "pulseira-inteligente.jpg",
                            Name = "Pulseira Inteligente",
                            Price = 99.90m,
                            Stock = 120
                        });
                });

            modelBuilder.Entity("HelpApp.Domain.Entities.Product", b =>
                {
                    b.HasOne("HelpApp.Domain.Entities.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("HelpApp.Domain.Entities.Category", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
