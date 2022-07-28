using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GeekShopping.ProductAPI.Migrations
{
    public partial class SeedProductDataTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "tb_product",
                columns: new[] { "id", "nm_category", "ds_product", "nm_img_url", "nm_product", "vl_price" },
                values: new object[] { 1L, "Category", "Description", "https://www.climba.com.br/blog/wp-content/uploads/2018/12/259186-retirar-o-produto-na-loja-fisica-o-novo-diferencial-do-ecommerce.png", "Name", 12.3m });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "tb_product",
                keyColumn: "id",
                keyValue: 1L);
        }
    }
}
