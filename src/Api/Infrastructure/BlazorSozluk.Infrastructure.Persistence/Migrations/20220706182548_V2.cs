using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorSozluk.Infrastructure.Persistence.Migrations
{
    public partial class V2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_entry_user_UserId",
                schema: "dbo",
                table: "entry");

            migrationBuilder.RenameColumn(
                name: "UserId",
                schema: "dbo",
                table: "entry",
                newName: "CreatedById");

            migrationBuilder.RenameIndex(
                name: "IX_entry_UserId",
                schema: "dbo",
                table: "entry",
                newName: "IX_entry_CreatedById");

            migrationBuilder.AddForeignKey(
                name: "FK_entry_user_CreatedById",
                schema: "dbo",
                table: "entry",
                column: "CreatedById",
                principalSchema: "dbo",
                principalTable: "user",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_entry_user_CreatedById",
                schema: "dbo",
                table: "entry");

            migrationBuilder.RenameColumn(
                name: "CreatedById",
                schema: "dbo",
                table: "entry",
                newName: "UserId");

            migrationBuilder.RenameIndex(
                name: "IX_entry_CreatedById",
                schema: "dbo",
                table: "entry",
                newName: "IX_entry_UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_entry_user_UserId",
                schema: "dbo",
                table: "entry",
                column: "UserId",
                principalSchema: "dbo",
                principalTable: "user",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
