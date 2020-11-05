using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplicationVente.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategorieId", "Description", "NomCateg" },
                values: new object[] { 1, "Les légumes sont des aliments végétaux correspondant aux parties comestibles d’une plante potagère.", "Legume" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategorieId", "Description", "NomCateg" },
                values: new object[] { 2, "un fruit est un aliment végétal, à la saveur sucrée, généralement Consommer cru", "Fruit" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategorieId", "Description", "NomCateg" },
                values: new object[] { 3, "Les féculents sont des aliments d'origine végétale, constitués dans une forte proportion d'amidon", "Feculent" });

            migrationBuilder.InsertData(
                table: "Produits",
                columns: new[] { "ProduitId", "CategorieId", "ImageUrl", "NomProduit", "PrixVentHT", "PrixVenteTTC", "Tva" },
                values: new object[,]
                {
                    { 1, 1, "https://upload.wikimedia.org/wikipedia/commons/8/89/Tomato_je.jpg", "Tomate", 1.5, 1.1499999999999999, 0.5 },
                    { 2, 1, "https://img-3.journaldesfemmes.fr/Mo420MV8Zpmp5eNwcSbyQUnUyzE=/910x607/smart/28d9e85a82b44ae2bf9cae050b62f938/ccmcms-jdf/10658977.jpg", "Aubergine", 2.1000000000000001, 2.2000000000000002, 0.050000000000000003 },
                    { 3, 1, "https://img-3.journaldesfemmes.fr/4PYoBAo1J5rsDbuMiSTNRGolvhc=/910x607/smart/3b81125b1cbd46f7af87766bb8430152/ccmcms-jdf/10659145.jpg", "Carotte", 1.1000000000000001, 1.1499999999999999, 0.050000000000000003 },
                    { 4, 2, "https://media.gerbeaud.net/2017/01/640/pomme-detouree.jpg", "Pomme", 2.0, 2.0499999999999998, 0.050000000000000003 },
                    { 5, 2, "https://produits.bienmanger.com/38345-0w0h0_Oranges_Navelate_Bio.jpg", "Orange", 2.0, 2.0499999999999998, 0.050000000000000003 },
                    { 6, 3, "https://www.lesfousdeterroirs.fr/storage/images/wishlists/img/pain-maison-Mxd1y.jpeg", "Pain maison", 1.0, 1.05, 0.050000000000000003 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Produits",
                keyColumn: "ProduitId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Produits",
                keyColumn: "ProduitId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Produits",
                keyColumn: "ProduitId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Produits",
                keyColumn: "ProduitId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Produits",
                keyColumn: "ProduitId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Produits",
                keyColumn: "ProduitId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategorieId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategorieId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategorieId",
                keyValue: 3);
        }
    }
}
