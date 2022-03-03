using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ContactTracing_API.Data.Migrations
{
    public partial class SecondTry : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_UserHealthStatus_UserId",
                table: "UserHealthStatus",
                column: "UserId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_UserHealthStatus_User_UserId",
                table: "UserHealthStatus",
                column: "UserId",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserHealthStatus_User_UserId",
                table: "UserHealthStatus");

            migrationBuilder.DropIndex(
                name: "IX_UserHealthStatus_UserId",
                table: "UserHealthStatus");
        }
    }
}
