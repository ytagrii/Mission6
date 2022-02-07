using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Mission6.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "categories",
                columns: table => new
                {
                    CategoryId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CategoryName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_categories", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "quadrant",
                columns: table => new
                {
                    QuadrantId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    QuadrantName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_quadrant", x => x.QuadrantId);
                });

            migrationBuilder.CreateTable(
                name: "task",
                columns: table => new
                {
                    TaskId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    DueDate = table.Column<DateTime>(nullable: false),
                    CategoryId = table.Column<int>(nullable: false),
                    QuadrantId = table.Column<int>(nullable: false),
                    Completed = table.Column<bool>(nullable: false),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_task", x => x.TaskId);
                    table.ForeignKey(
                        name: "FK_task_categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_task_quadrant_QuadrantId",
                        column: x => x.QuadrantId,
                        principalTable: "quadrant",
                        principalColumn: "QuadrantId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "categories",
                columns: new[] { "CategoryId", "CategoryName" },
                values: new object[] { 1, "Home" });

            migrationBuilder.InsertData(
                table: "categories",
                columns: new[] { "CategoryId", "CategoryName" },
                values: new object[] { 2, "School" });

            migrationBuilder.InsertData(
                table: "categories",
                columns: new[] { "CategoryId", "CategoryName" },
                values: new object[] { 3, "Work" });

            migrationBuilder.InsertData(
                table: "categories",
                columns: new[] { "CategoryId", "CategoryName" },
                values: new object[] { 4, "Church" });

            migrationBuilder.InsertData(
                table: "quadrant",
                columns: new[] { "QuadrantId", "QuadrantName" },
                values: new object[] { 1, "Important/Urgent" });

            migrationBuilder.InsertData(
                table: "quadrant",
                columns: new[] { "QuadrantId", "QuadrantName" },
                values: new object[] { 2, "Important/Not Urgent" });

            migrationBuilder.InsertData(
                table: "quadrant",
                columns: new[] { "QuadrantId", "QuadrantName" },
                values: new object[] { 3, "Not Important/Urgent" });

            migrationBuilder.InsertData(
                table: "quadrant",
                columns: new[] { "QuadrantId", "QuadrantName" },
                values: new object[] { 4, "Not Important/Not Urgent" });

            migrationBuilder.CreateIndex(
                name: "IX_task_CategoryId",
                table: "task",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_task_QuadrantId",
                table: "task",
                column: "QuadrantId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "task");

            migrationBuilder.DropTable(
                name: "categories");

            migrationBuilder.DropTable(
                name: "quadrant");
        }
    }
}
