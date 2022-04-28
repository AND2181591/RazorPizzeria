using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RazorPizzeria.Migrations
{
    public partial class addedPizzaOrderCorrection : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_MyProperty",
                table: "MyProperty");

            migrationBuilder.RenameTable(
                name: "MyProperty",
                newName: "PizzaOrders");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PizzaOrders",
                table: "PizzaOrders",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_PizzaOrders",
                table: "PizzaOrders");

            migrationBuilder.RenameTable(
                name: "PizzaOrders",
                newName: "MyProperty");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MyProperty",
                table: "MyProperty",
                column: "Id");
        }
    }
}
