using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Yokaira_AP1_P1.Migrations
{
    /// <inheritdoc />
    public partial class ArreglandoAportes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_aporte",
                table: "aporte");

            migrationBuilder.DropColumn(
                name: "AportesId",
                table: "aporte");

            migrationBuilder.AlterColumn<int>(
                name: "AporteId",
                table: "aporte",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER")
                .Annotation("Sqlite:Autoincrement", true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_aporte",
                table: "aporte",
                column: "AporteId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_aporte",
                table: "aporte");

            migrationBuilder.AlterColumn<int>(
                name: "AporteId",
                table: "aporte",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER")
                .OldAnnotation("Sqlite:Autoincrement", true);

            migrationBuilder.AddColumn<int>(
                name: "AportesId",
                table: "aporte",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0)
                .Annotation("Sqlite:Autoincrement", true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_aporte",
                table: "aporte",
                column: "AportesId");
        }
    }
}
