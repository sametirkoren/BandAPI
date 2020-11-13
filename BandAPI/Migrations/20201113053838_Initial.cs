using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BandAPI.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bands",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Founded = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MainGenre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bands", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Albums",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true),
                    BandId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Albums", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Albums_Bands_BandId",
                        column: x => x.BandId,
                        principalTable: "Bands",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Bands",
                columns: new[] { "Id", "Founded", "MainGenre", "Name" },
                values: new object[] { new Guid("9433d064-bb01-46bf-a2af-b57fe93f5da1"), new DateTime(1980, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Heavy Metal", "Metallica" });

            migrationBuilder.InsertData(
                table: "Bands",
                columns: new[] { "Id", "Founded", "MainGenre", "Name" },
                values: new object[] { new Guid("56b8cbac-c3a4-4717-9dba-3724e8d0543b"), new DateTime(1985, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rock", "Guns N Roses" });

            migrationBuilder.InsertData(
                table: "Bands",
                columns: new[] { "Id", "Founded", "MainGenre", "Name" },
                values: new object[] { new Guid("9e7bece4-765d-48b6-a56c-6fb237b07a1f"), new DateTime(1997, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rap", "TalKing Gunz" });

            migrationBuilder.InsertData(
                table: "Albums",
                columns: new[] { "Id", "BandId", "Description", "Title" },
                values: new object[] { new Guid("b1256790-99f3-461c-8601-c9326e1b026f"), new Guid("9433d064-bb01-46bf-a2af-b57fe93f5da1"), "One of the best heavy metal albums ever", "Master Of Puppets" });

            migrationBuilder.InsertData(
                table: "Albums",
                columns: new[] { "Id", "BandId", "Description", "Title" },
                values: new object[] { new Guid("1b515fc1-2b9b-4256-959f-76ea6fa07e94"), new Guid("56b8cbac-c3a4-4717-9dba-3724e8d0543b"), "Amazing Rock album with raw sound", "Appetite for Destruction" });

            migrationBuilder.InsertData(
                table: "Albums",
                columns: new[] { "Id", "BandId", "Description", "Title" },
                values: new object[] { new Guid("68bba4bc-d02c-4cde-a513-993073495b04"), new Guid("9e7bece4-765d-48b6-a56c-6fb237b07a1f"), "Amazing Rap album with raw sound", "Nows Da Time" });

            migrationBuilder.CreateIndex(
                name: "IX_Albums_BandId",
                table: "Albums",
                column: "BandId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Albums");

            migrationBuilder.DropTable(
                name: "Bands");
        }
    }
}
