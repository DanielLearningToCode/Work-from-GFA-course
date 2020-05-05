using Microsoft.EntityFrameworkCore.Migrations;

namespace EntityFrameworkBasics.Migrations
{
    public partial class refresh : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_todos_assignees_AssigneeId",
                table: "todos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_todos",
                table: "todos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_assignees",
                table: "assignees");

            migrationBuilder.RenameTable(
                name: "todos",
                newName: "Todos");

            migrationBuilder.RenameTable(
                name: "assignees",
                newName: "Assignees");

            migrationBuilder.RenameIndex(
                name: "IX_todos_AssigneeId",
                table: "Todos",
                newName: "IX_Todos_AssigneeId");

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Todos",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "AssigneeId",
                table: "Todos",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Assignees",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Todos",
                table: "Todos",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Assignees",
                table: "Assignees",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Todos_Assignees_AssigneeId",
                table: "Todos",
                column: "AssigneeId",
                principalTable: "Assignees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Todos_Assignees_AssigneeId",
                table: "Todos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Todos",
                table: "Todos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Assignees",
                table: "Assignees");

            migrationBuilder.RenameTable(
                name: "Todos",
                newName: "todos");

            migrationBuilder.RenameTable(
                name: "Assignees",
                newName: "assignees");

            migrationBuilder.RenameIndex(
                name: "IX_Todos_AssigneeId",
                table: "todos",
                newName: "IX_todos_AssigneeId");

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "todos",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<int>(
                name: "AssigneeId",
                table: "todos",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "assignees",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AddPrimaryKey(
                name: "PK_todos",
                table: "todos",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_assignees",
                table: "assignees",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_todos_assignees_AssigneeId",
                table: "todos",
                column: "AssigneeId",
                principalTable: "assignees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
