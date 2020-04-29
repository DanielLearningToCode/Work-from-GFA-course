using Microsoft.EntityFrameworkCore.Migrations;

namespace EntityFrameworkBasics.Migrations
{
    public partial class add_assignee_2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_todos_assignees_AssigneeId",
                table: "todos");

            migrationBuilder.AlterColumn<int>(
                name: "AssigneeId",
                table: "todos",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_todos_assignees_AssigneeId",
                table: "todos",
                column: "AssigneeId",
                principalTable: "assignees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_todos_assignees_AssigneeId",
                table: "todos");

            migrationBuilder.AlterColumn<int>(
                name: "AssigneeId",
                table: "todos",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_todos_assignees_AssigneeId",
                table: "todos",
                column: "AssigneeId",
                principalTable: "assignees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
