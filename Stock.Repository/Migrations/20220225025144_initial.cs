using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Stock.Repository.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    UpdatedDate = table.Column<DateTime>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    ProductCode = table.Column<string>(nullable: true),
                    MetaDescription = table.Column<string>(nullable: true),
                    AdminComment = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductId);
                });

            migrationBuilder.CreateTable(
                name: "Variants",
                columns: table => new
                {
                    VariantId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    VariantCode = table.Column<string>(nullable: true),
                    ProductId = table.Column<int>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    UpdatedDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Variants", x => x.VariantId);
                    table.ForeignKey(
                        name: "FK_Variants_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "StockInfo",
                columns: table => new
                {
                    StockId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Quantity = table.Column<int>(nullable: false, defaultValue: 0),
                    CreatedDate = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2022, 2, 25, 5, 51, 44, 51, DateTimeKind.Local).AddTicks(5663)),
                    UpdatedDate = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)),
                    VariantId = table.Column<int>(nullable: false),
                    ProductId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StockInfo", x => x.StockId);
                    table.ForeignKey(
                        name: "FK_StockInfo_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StockInfo_Variants_VariantId",
                        column: x => x.VariantId,
                        principalTable: "Variants",
                        principalColumn: "VariantId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "AdminComment", "CreatedDate", "MetaDescription", "Name", "ProductCode", "UpdatedDate" },
                values: new object[] { 1, "Stok var", new DateTime(2022, 2, 25, 2, 51, 44, 54, DateTimeKind.Utc).AddTicks(9910), "Iphone 12 CellPhone", "Iphone 12", "IPHONE12", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "AdminComment", "CreatedDate", "MetaDescription", "Name", "ProductCode", "UpdatedDate" },
                values: new object[] { 2, "Stok var", new DateTime(2022, 2, 25, 2, 51, 44, 55, DateTimeKind.Utc).AddTicks(8873), "Iphone 13 CellPhone", "Iphone 13", "IPHONE13", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Variants",
                columns: new[] { "VariantId", "CreatedDate", "Name", "ProductId", "UpdatedDate", "VariantCode" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 2, 25, 2, 51, 44, 56, DateTimeKind.Utc).AddTicks(8139), "Rose - 128", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "1000000851090" },
                    { 2, new DateTime(2022, 2, 25, 2, 51, 44, 56, DateTimeKind.Utc).AddTicks(8533), "Rose - 64", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "1000000851091" },
                    { 3, new DateTime(2022, 2, 25, 2, 51, 44, 56, DateTimeKind.Utc).AddTicks(8548), "Gold - 64", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "1000000851092" },
                    { 4, new DateTime(2022, 2, 25, 2, 51, 44, 56, DateTimeKind.Utc).AddTicks(8552), "Gold - 128", 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "1000000851093" }
                });

            migrationBuilder.InsertData(
                table: "StockInfo",
                columns: new[] { "StockId", "CreatedDate", "ProductId", "Quantity", "VariantId" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 2, 25, 2, 51, 44, 56, DateTimeKind.Utc).AddTicks(3446), 1, 30, 1 },
                    { 2, new DateTime(2022, 2, 25, 2, 51, 44, 56, DateTimeKind.Utc).AddTicks(3854), 1, 40, 2 },
                    { 3, new DateTime(2022, 2, 25, 2, 51, 44, 56, DateTimeKind.Utc).AddTicks(3874), 1, 60, 3 },
                    { 4, new DateTime(2022, 2, 25, 2, 51, 44, 56, DateTimeKind.Utc).AddTicks(3876), 2, 70, 4 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_ProductCode",
                table: "Products",
                column: "ProductCode",
                unique: true,
                filter: "[ProductCode] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Products_ProductId",
                table: "Products",
                column: "ProductId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_StockInfo_ProductId",
                table: "StockInfo",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_StockInfo_VariantId",
                table: "StockInfo",
                column: "VariantId");

            migrationBuilder.CreateIndex(
                name: "IX_Variants_ProductId",
                table: "Variants",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Variants_VariantId",
                table: "Variants",
                column: "VariantId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StockInfo");

            migrationBuilder.DropTable(
                name: "Variants");

            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
