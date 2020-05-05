using Microsoft.EntityFrameworkCore.Migrations;

namespace EntityFrameworkBasics.Migrations
{
    public partial class add_assignee_with_key : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AssigneeId",
                table: "todos",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "assignees",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_assignees", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_todos_AssigneeId",
                table: "todos",
                column: "AssigneeId");

            migrationBuilder.AddForeignKey(
                name: "FK_todos_assignees_AssigneeId",
                table: "todos",
                column: "AssigneeId",
                principalTable: "assignees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_todos_assignees_AssigneeId",
                table: "todos");

            migrationBuilder.DropTable(
                name: "assignees");

            migrationBuilder.DropIndex(
                name: "IX_todos_AssigneeId",
                table: "todos");

            migrationBuilder.DropColumn(
                name: "AssigneeId",
                table: "todos");
        }
    }
}
