using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Web_API.Migrations
{
    public partial class AddEMP_TO_DO_LIST : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EMP_TO_DO_LIST",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EMP_ID = table.Column<int>(nullable: false),
                    NOTE = table.Column<string>(maxLength: 50, nullable: true),
                    START_DATE = table.Column<DateTime>(type: "datetime", nullable: true),
                    END_DATE = table.Column<DateTime>(type: "date", nullable: true),
                    STATUS = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EMP_TO_DO_LIST", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EMP_TO_DO_LIST");
        }
    }
}
