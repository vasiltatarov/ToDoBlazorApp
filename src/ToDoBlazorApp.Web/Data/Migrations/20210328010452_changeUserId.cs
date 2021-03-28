using Microsoft.EntityFrameworkCore.Migrations;

namespace ToDoBlazorApp.Web.Data.Migrations
{
    public partial class changeUserId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Todos_AspNetUsers_UserId1",
                table: "Todos");

            migrationBuilder.DropIndex(
                name: "IX_Todos_UserId1",
                table: "Todos");

            migrationBuilder.DropColumn(
                name: "UserId1",
                table: "Todos");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Todos",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_Todos_UserId",
                table: "Todos",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Todos_AspNetUsers_UserId",
                table: "Todos",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Todos_AspNetUsers_UserId",
                table: "Todos");

            migrationBuilder.DropIndex(
                name: "IX_Todos_UserId",
                table: "Todos");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "Todos",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserId1",
                table: "Todos",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Todos_UserId1",
                table: "Todos",
                column: "UserId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Todos_AspNetUsers_UserId1",
                table: "Todos",
                column: "UserId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
