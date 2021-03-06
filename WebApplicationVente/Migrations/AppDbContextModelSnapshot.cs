﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApplicationVente.Models;

namespace WebApplicationVente.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebApplicationVente.Models.Categorie", b =>
                {
                    b.Property<int>("CategorieId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NomCateg")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategorieId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategorieId = 1,
                            Description = "Les légumes sont des aliments végétaux correspondant aux parties comestibles d’une plante potagère.",
                            NomCateg = "Legume"
                        },
                        new
                        {
                            CategorieId = 2,
                            Description = "un fruit est un aliment végétal, à la saveur sucrée, généralement Consommer cru",
                            NomCateg = "Fruit"
                        },
                        new
                        {
                            CategorieId = 3,
                            Description = "Les féculents sont des aliments d'origine végétale, constitués dans une forte proportion d'amidon",
                            NomCateg = "Feculent"
                        });
                });

            modelBuilder.Entity("WebApplicationVente.Models.Order", b =>
                {
                    b.Property<int>("OrdereId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AdresseLine1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AdresseLine2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("OrderPlaced")
                        .HasColumnType("datetime2");

                    b.Property<double>("OrderTotal")
                        .HasColumnType("float");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("State")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ZipCode")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("OrdereId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("WebApplicationVente.Models.OrderDetail", b =>
                {
                    b.Property<int>("OrderDetailId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<int>("ProduitId")
                        .HasColumnType("int");

                    b.HasKey("OrderDetailId");

                    b.HasIndex("OrderId");

                    b.HasIndex("ProduitId");

                    b.ToTable("OrderDetails");
                });

            modelBuilder.Entity("WebApplicationVente.Models.Produit", b =>
                {
                    b.Property<int>("ProduitId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategorieId")
                        .HasColumnType("int");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NomProduit")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("PrixVentHT")
                        .HasColumnType("float");

                    b.Property<double>("PrixVenteTTC")
                        .HasColumnType("float");

                    b.Property<double>("Tva")
                        .HasColumnType("float");

                    b.HasKey("ProduitId");

                    b.HasIndex("CategorieId");

                    b.ToTable("Produits");

                    b.HasData(
                        new
                        {
                            ProduitId = 1,
                            CategorieId = 1,
                            ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/8/89/Tomato_je.jpg",
                            NomProduit = "Tomate",
                            PrixVentHT = 1.5,
                            PrixVenteTTC = 1.1499999999999999,
                            Tva = 0.5
                        },
                        new
                        {
                            ProduitId = 2,
                            CategorieId = 1,
                            ImageUrl = "https://img-3.journaldesfemmes.fr/Mo420MV8Zpmp5eNwcSbyQUnUyzE=/910x607/smart/28d9e85a82b44ae2bf9cae050b62f938/ccmcms-jdf/10658977.jpg",
                            NomProduit = "Aubergine",
                            PrixVentHT = 2.1000000000000001,
                            PrixVenteTTC = 2.2000000000000002,
                            Tva = 0.050000000000000003
                        },
                        new
                        {
                            ProduitId = 3,
                            CategorieId = 1,
                            ImageUrl = "https://img-3.journaldesfemmes.fr/4PYoBAo1J5rsDbuMiSTNRGolvhc=/910x607/smart/3b81125b1cbd46f7af87766bb8430152/ccmcms-jdf/10659145.jpg",
                            NomProduit = "Carotte",
                            PrixVentHT = 1.1000000000000001,
                            PrixVenteTTC = 1.1499999999999999,
                            Tva = 0.050000000000000003
                        },
                        new
                        {
                            ProduitId = 4,
                            CategorieId = 2,
                            ImageUrl = "https://media.gerbeaud.net/2017/01/640/pomme-detouree.jpg",
                            NomProduit = "Pomme",
                            PrixVentHT = 2.0,
                            PrixVenteTTC = 2.0499999999999998,
                            Tva = 0.050000000000000003
                        },
                        new
                        {
                            ProduitId = 5,
                            CategorieId = 2,
                            ImageUrl = "https://produits.bienmanger.com/38345-0w0h0_Oranges_Navelate_Bio.jpg",
                            NomProduit = "Orange",
                            PrixVentHT = 2.0,
                            PrixVenteTTC = 2.0499999999999998,
                            Tva = 0.050000000000000003
                        },
                        new
                        {
                            ProduitId = 6,
                            CategorieId = 3,
                            ImageUrl = "https://www.lesfousdeterroirs.fr/storage/images/wishlists/img/pain-maison-Mxd1y.jpeg",
                            NomProduit = "Pain maison",
                            PrixVentHT = 1.0,
                            PrixVenteTTC = 1.05,
                            Tva = 0.050000000000000003
                        });
                });

            modelBuilder.Entity("WebApplicationVente.Models.ShoppingCartItem", b =>
                {
                    b.Property<int>("ShoppingCartItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<int?>("ProuitProduitId")
                        .HasColumnType("int");

                    b.Property<string>("ShoppingCartSessionId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ShoppingCartItemId");

                    b.HasIndex("ProuitProduitId");

                    b.ToTable("ShoppingCartItems");
                });

            modelBuilder.Entity("WebApplicationVente.Models.OrderDetail", b =>
                {
                    b.HasOne("WebApplicationVente.Models.Order", "Order")
                        .WithMany("OrderDetails")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebApplicationVente.Models.Produit", "Produit")
                        .WithMany()
                        .HasForeignKey("ProduitId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("WebApplicationVente.Models.Produit", b =>
                {
                    b.HasOne("WebApplicationVente.Models.Categorie", "Categorie")
                        .WithMany("Produits")
                        .HasForeignKey("CategorieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("WebApplicationVente.Models.ShoppingCartItem", b =>
                {
                    b.HasOne("WebApplicationVente.Models.Produit", "Prouit")
                        .WithMany()
                        .HasForeignKey("ProuitProduitId");
                });
#pragma warning restore 612, 618
        }
    }
}
