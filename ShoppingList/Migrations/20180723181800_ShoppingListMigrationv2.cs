using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ShoppingList.Migrations
{
    public partial class ShoppingListMigrationv2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_List_Groups_UserGroupId",
                table: "List");

            migrationBuilder.DropPrimaryKey(
                name: "PK_List",
                table: "List");

            migrationBuilder.RenameTable(
                name: "List",
                newName: "Lists");

            migrationBuilder.RenameIndex(
                name: "IX_List_UserGroupId",
                table: "Lists",
                newName: "IX_Lists_UserGroupId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Lists",
                table: "Lists",
                column: "ListId");

            migrationBuilder.CreateTable(
                name: "ProductCategories",
                columns: table => new
                {
                    ProductCategoryId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ProductCategoryName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductCategories", x => x.ProductCategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ProductName = table.Column<string>(nullable: true),
                    Unit = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductId);
                });

            migrationBuilder.CreateTable(
                name: "ListItems",
                columns: table => new
                {
                    Qty = table.Column<int>(nullable: false),
                    ListId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ListId1 = table.Column<long>(nullable: true),
                    ProductId = table.Column<int>(nullable: false),
                    ProductId1 = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ListItems", x => x.ListId);
                    table.ForeignKey(
                        name: "FK_ListItems_Lists_ListId1",
                        column: x => x.ListId1,
                        principalTable: "Lists",
                        principalColumn: "ListId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ListItems_Products_ProductId1",
                        column: x => x.ProductId1,
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ListItems_ListId1",
                table: "ListItems",
                column: "ListId1");

            migrationBuilder.CreateIndex(
                name: "IX_ListItems_ProductId1",
                table: "ListItems",
                column: "ProductId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Lists_Groups_UserGroupId",
                table: "Lists",
                column: "UserGroupId",
                principalTable: "Groups",
                principalColumn: "GroupId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Lists_Groups_UserGroupId",
                table: "Lists");

            migrationBuilder.DropTable(
                name: "ListItems");

            migrationBuilder.DropTable(
                name: "ProductCategories");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Lists",
                table: "Lists");

            migrationBuilder.RenameTable(
                name: "Lists",
                newName: "List");

            migrationBuilder.RenameIndex(
                name: "IX_Lists_UserGroupId",
                table: "List",
                newName: "IX_List_UserGroupId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_List",
                table: "List",
                column: "ListId");

            migrationBuilder.AddForeignKey(
                name: "FK_List_Groups_UserGroupId",
                table: "List",
                column: "UserGroupId",
                principalTable: "Groups",
                principalColumn: "GroupId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
