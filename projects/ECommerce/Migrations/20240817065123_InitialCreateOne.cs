using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ECommerce.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreateOne : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CartItemModel_CartModel_CartId",
                table: "CartItemModel");

            migrationBuilder.DropForeignKey(
                name: "FK_CartItemModel_ProductModel_ProductId",
                table: "CartItemModel");

            migrationBuilder.DropForeignKey(
                name: "FK_CartModel_AspNetUsers_UserId",
                table: "CartModel");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderItemModel_OrderModel_OrderId",
                table: "OrderItemModel");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderItemModel_ProductModel_ProductId",
                table: "OrderItemModel");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderModel_AspNetUsers_UserId1",
                table: "OrderModel");

            migrationBuilder.DropForeignKey(
                name: "FK_PaymentModel_OrderModel_OrderId",
                table: "PaymentModel");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductModel_CategoryModel_CategoryId",
                table: "ProductModel");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductModel",
                table: "ProductModel");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PaymentModel",
                table: "PaymentModel");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OrderModel",
                table: "OrderModel");

            migrationBuilder.DropIndex(
                name: "IX_OrderModel_UserId1",
                table: "OrderModel");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OrderItemModel",
                table: "OrderItemModel");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CategoryModel",
                table: "CategoryModel");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CartModel",
                table: "CartModel");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CartItemModel",
                table: "CartItemModel");

            migrationBuilder.RenameTable(
                name: "ProductModel",
                newName: "Products");

            migrationBuilder.RenameTable(
                name: "PaymentModel",
                newName: "Payments");

            migrationBuilder.RenameTable(
                name: "OrderModel",
                newName: "Orders");

            migrationBuilder.RenameTable(
                name: "OrderItemModel",
                newName: "OrderItems");

            migrationBuilder.RenameTable(
                name: "CategoryModel",
                newName: "Categories");

            migrationBuilder.RenameTable(
                name: "CartModel",
                newName: "Carts");

            migrationBuilder.RenameTable(
                name: "CartItemModel",
                newName: "CartItems");

            migrationBuilder.RenameIndex(
                name: "IX_ProductModel_CategoryId",
                table: "Products",
                newName: "IX_Products_CategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_PaymentModel_OrderId",
                table: "Payments",
                newName: "IX_Payments_OrderId");

            migrationBuilder.RenameColumn(
                name: "UserId1",
                table: "Orders",
                newName: "OrderDetails");

            migrationBuilder.RenameIndex(
                name: "IX_OrderItemModel_ProductId",
                table: "OrderItems",
                newName: "IX_OrderItems_ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_OrderItemModel_OrderId",
                table: "OrderItems",
                newName: "IX_OrderItems_OrderId");

            migrationBuilder.RenameIndex(
                name: "IX_CartModel_UserId",
                table: "Carts",
                newName: "IX_Carts_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_CartItemModel_ProductId",
                table: "CartItems",
                newName: "IX_CartItems_ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_CartItemModel_CartId",
                table: "CartItems",
                newName: "IX_CartItems_CartId");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Orders",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Products",
                table: "Products",
                column: "ProductId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Payments",
                table: "Payments",
                column: "PaymentId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Orders",
                table: "Orders",
                column: "OrderId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OrderItems",
                table: "OrderItems",
                column: "OrderItemId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Categories",
                table: "Categories",
                column: "CategoryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Carts",
                table: "Carts",
                column: "CartId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CartItems",
                table: "CartItems",
                column: "CartItemId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_UserId",
                table: "Orders",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_CartItems_Carts_CartId",
                table: "CartItems",
                column: "CartId",
                principalTable: "Carts",
                principalColumn: "CartId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CartItems_Products_ProductId",
                table: "CartItems",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "ProductId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Carts_AspNetUsers_UserId",
                table: "Carts",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderItems_Orders_OrderId",
                table: "OrderItems",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "OrderId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderItems_Products_ProductId",
                table: "OrderItems",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "ProductId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_AspNetUsers_UserId",
                table: "Orders",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Payments_Orders_OrderId",
                table: "Payments",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "OrderId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Categories_CategoryId",
                table: "Products",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CartItems_Carts_CartId",
                table: "CartItems");

            migrationBuilder.DropForeignKey(
                name: "FK_CartItems_Products_ProductId",
                table: "CartItems");

            migrationBuilder.DropForeignKey(
                name: "FK_Carts_AspNetUsers_UserId",
                table: "Carts");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderItems_Orders_OrderId",
                table: "OrderItems");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderItems_Products_ProductId",
                table: "OrderItems");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_AspNetUsers_UserId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Payments_Orders_OrderId",
                table: "Payments");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Categories_CategoryId",
                table: "Products");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Products",
                table: "Products");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Payments",
                table: "Payments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Orders",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Orders_UserId",
                table: "Orders");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OrderItems",
                table: "OrderItems");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Categories",
                table: "Categories");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Carts",
                table: "Carts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CartItems",
                table: "CartItems");

            migrationBuilder.RenameTable(
                name: "Products",
                newName: "ProductModel");

            migrationBuilder.RenameTable(
                name: "Payments",
                newName: "PaymentModel");

            migrationBuilder.RenameTable(
                name: "Orders",
                newName: "OrderModel");

            migrationBuilder.RenameTable(
                name: "OrderItems",
                newName: "OrderItemModel");

            migrationBuilder.RenameTable(
                name: "Categories",
                newName: "CategoryModel");

            migrationBuilder.RenameTable(
                name: "Carts",
                newName: "CartModel");

            migrationBuilder.RenameTable(
                name: "CartItems",
                newName: "CartItemModel");

            migrationBuilder.RenameIndex(
                name: "IX_Products_CategoryId",
                table: "ProductModel",
                newName: "IX_ProductModel_CategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_Payments_OrderId",
                table: "PaymentModel",
                newName: "IX_PaymentModel_OrderId");

            migrationBuilder.RenameColumn(
                name: "OrderDetails",
                table: "OrderModel",
                newName: "UserId1");

            migrationBuilder.RenameIndex(
                name: "IX_OrderItems_ProductId",
                table: "OrderItemModel",
                newName: "IX_OrderItemModel_ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_OrderItems_OrderId",
                table: "OrderItemModel",
                newName: "IX_OrderItemModel_OrderId");

            migrationBuilder.RenameIndex(
                name: "IX_Carts_UserId",
                table: "CartModel",
                newName: "IX_CartModel_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_CartItems_ProductId",
                table: "CartItemModel",
                newName: "IX_CartItemModel_ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_CartItems_CartId",
                table: "CartItemModel",
                newName: "IX_CartItemModel_CartId");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "OrderModel",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductModel",
                table: "ProductModel",
                column: "ProductId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PaymentModel",
                table: "PaymentModel",
                column: "PaymentId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OrderModel",
                table: "OrderModel",
                column: "OrderId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OrderItemModel",
                table: "OrderItemModel",
                column: "OrderItemId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CategoryModel",
                table: "CategoryModel",
                column: "CategoryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CartModel",
                table: "CartModel",
                column: "CartId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CartItemModel",
                table: "CartItemModel",
                column: "CartItemId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderModel_UserId1",
                table: "OrderModel",
                column: "UserId1");

            migrationBuilder.AddForeignKey(
                name: "FK_CartItemModel_CartModel_CartId",
                table: "CartItemModel",
                column: "CartId",
                principalTable: "CartModel",
                principalColumn: "CartId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CartItemModel_ProductModel_ProductId",
                table: "CartItemModel",
                column: "ProductId",
                principalTable: "ProductModel",
                principalColumn: "ProductId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CartModel_AspNetUsers_UserId",
                table: "CartModel",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderItemModel_OrderModel_OrderId",
                table: "OrderItemModel",
                column: "OrderId",
                principalTable: "OrderModel",
                principalColumn: "OrderId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderItemModel_ProductModel_ProductId",
                table: "OrderItemModel",
                column: "ProductId",
                principalTable: "ProductModel",
                principalColumn: "ProductId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderModel_AspNetUsers_UserId1",
                table: "OrderModel",
                column: "UserId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PaymentModel_OrderModel_OrderId",
                table: "PaymentModel",
                column: "OrderId",
                principalTable: "OrderModel",
                principalColumn: "OrderId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductModel_CategoryModel_CategoryId",
                table: "ProductModel",
                column: "CategoryId",
                principalTable: "CategoryModel",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
