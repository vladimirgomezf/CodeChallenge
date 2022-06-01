using Microsoft.EntityFrameworkCore.Migrations;

namespace BugsWebAPI.Migrations
{
    public partial class ProjectIdToInt : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bugs_Projects_ProjectIdId",
                table: "Bugs");

            migrationBuilder.DropForeignKey(
                name: "FK_Bugs_Users_UserIdId",
                table: "Bugs");

            migrationBuilder.DropIndex(
                name: "IX_Bugs_ProjectIdId",
                table: "Bugs");

            migrationBuilder.DropColumn(
                name: "ProjectIdId",
                table: "Bugs");

            migrationBuilder.RenameColumn(
                name: "UserIdId",
                table: "Bugs",
                newName: "UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Bugs_UserIdId",
                table: "Bugs",
                newName: "IX_Bugs_UserId");

            migrationBuilder.AddColumn<int>(
                name: "ProjectId",
                table: "Bugs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Bugs_Users_UserId",
                table: "Bugs",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bugs_Users_UserId",
                table: "Bugs");

            migrationBuilder.DropColumn(
                name: "ProjectId",
                table: "Bugs");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Bugs",
                newName: "UserIdId");

            migrationBuilder.RenameIndex(
                name: "IX_Bugs_UserId",
                table: "Bugs",
                newName: "IX_Bugs_UserIdId");

            migrationBuilder.AddColumn<int>(
                name: "ProjectIdId",
                table: "Bugs",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Bugs_ProjectIdId",
                table: "Bugs",
                column: "ProjectIdId");

            migrationBuilder.AddForeignKey(
                name: "FK_Bugs_Projects_ProjectIdId",
                table: "Bugs",
                column: "ProjectIdId",
                principalTable: "Projects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Bugs_Users_UserIdId",
                table: "Bugs",
                column: "UserIdId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
