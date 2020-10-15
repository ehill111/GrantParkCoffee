using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GrantParkCoffeeShop2.Data.Migrations
{
    public partial class addedDbContext : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    CustomerId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    StreetAddress = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    State = table.Column<string>(nullable: true),
                    ZipCode = table.Column<int>(nullable: false),
                    Email = table.Column<string>(nullable: true),
                    RewardPointsBalance = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.CustomerId);
                });

            migrationBuilder.CreateTable(
                name: "Order",
                columns: table => new
                {
                    OrderId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerId = table.Column<int>(nullable: false),
                    OrderDate = table.Column<DateTime>(nullable: false),
                    OrderInstructions = table.Column<string>(nullable: true),
                    OrderAmountTotal = table.Column<double>(nullable: false),
                    OrderPending = table.Column<bool>(nullable: false),
                    OrderFulfilled = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order", x => x.OrderId);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    ProductId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductType = table.Column<string>(nullable: true),
                    ProductName = table.Column<string>(nullable: true),
                    ProductPrice = table.Column<double>(nullable: false),
                    ProductFeatured = table.Column<string>(nullable: true),
                    ProductOnDiscountSale = table.Column<bool>(nullable: false),
                    RewardEligible = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.ProductId);
                });

            migrationBuilder.CreateTable(
                name: "ProductSalesHistory",
                columns: table => new
                {
                    ProductSalesHistoryId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderId = table.Column<int>(nullable: false),
                    ProductId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductSalesHistory", x => x.ProductSalesHistoryId);
                });

            migrationBuilder.CreateTable(
                name: "RoomReservation",
                columns: table => new
                {
                    RoomReservationId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReservationStartDate = table.Column<DateTime>(nullable: false),
                    ReservationStopDate = table.Column<DateTime>(nullable: false),
                    ReservationTimeStart = table.Column<DateTime>(nullable: false),
                    ReservationTimeStop = table.Column<DateTime>(nullable: false),
                    ReservationCustomerName = table.Column<string>(nullable: true),
                    CustomerId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoomReservation", x => x.RoomReservationId);
                });

            migrationBuilder.CreateTable(
                name: "ShoppingCart",
                columns: table => new
                {
                    ShoppingCartId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderId = table.Column<int>(nullable: false),
                    ProductId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShoppingCart", x => x.ShoppingCartId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customer");

            migrationBuilder.DropTable(
                name: "Order");

            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "ProductSalesHistory");

            migrationBuilder.DropTable(
                name: "RoomReservation");

            migrationBuilder.DropTable(
                name: "ShoppingCart");
        }
    }
}
