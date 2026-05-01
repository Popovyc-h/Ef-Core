using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace homeworkFromTg.Migrations
{
    /// <inheritdoc />
    public partial class AddEntityResource : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Character",
                keyColumn: "Id",
                keyValue: new Guid("11111111-0000-0000-0000-000000000001"));

            migrationBuilder.DeleteData(
                table: "Character",
                keyColumn: "Id",
                keyValue: new Guid("22222222-0000-0000-0000-000000000002"));

            migrationBuilder.DeleteData(
                table: "Character",
                keyColumn: "Id",
                keyValue: new Guid("33333333-0000-0000-0000-000000000003"));

            migrationBuilder.DeleteData(
                table: "Character",
                keyColumn: "Id",
                keyValue: new Guid("44444444-0000-0000-0000-000000000004"));

            migrationBuilder.DeleteData(
                table: "Staff",
                keyColumn: "Id",
                keyValue: new Guid("55555555-0000-0000-0000-000000000001"));

            migrationBuilder.DeleteData(
                table: "Staff",
                keyColumn: "Id",
                keyValue: new Guid("66666666-0000-0000-0000-000000000002"));

            migrationBuilder.DeleteData(
                table: "Staff",
                keyColumn: "Id",
                keyValue: new Guid("77777777-0000-0000-0000-000000000003"));

            migrationBuilder.DeleteData(
                table: "Staff",
                keyColumn: "Id",
                keyValue: new Guid("88888888-0000-0000-0000-000000000004"));

            migrationBuilder.RenameColumn(
                name: "seoMetadata_Title",
                table: "Staff",
                newName: "SeoMetadata_Title");

            migrationBuilder.RenameColumn(
                name: "seoMetadata_Description",
                table: "Staff",
                newName: "SeoMetadata_Description");

            migrationBuilder.RenameColumn(
                name: "hometown",
                table: "Staff",
                newName: "Hometown");

            migrationBuilder.RenameColumn(
                name: "seoMetadata_Title",
                table: "Character",
                newName: "SeoMetadata_Title");

            migrationBuilder.RenameColumn(
                name: "seoMetadata_Description",
                table: "Character",
                newName: "SeoMetadata_Description");

            migrationBuilder.CreateTable(
                name: "CharacterResources",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Type = table.Column<int>(type: "integer", nullable: false),
                    Url = table.Column<string>(type: "text", nullable: false),
                    CharacterId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CharacterResources", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CharacterResources_Character_CharacterId",
                        column: x => x.CharacterId,
                        principalTable: "Character",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StaffResource",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Type = table.Column<int>(type: "integer", nullable: false),
                    Url = table.Column<string>(type: "text", nullable: false),
                    StaffId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StaffResource", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StaffResource_Staff_StaffId",
                        column: x => x.StaffId,
                        principalTable: "Staff",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Title",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Title", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TitleResource",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Type = table.Column<int>(type: "integer", nullable: false),
                    Url = table.Column<string>(type: "text", nullable: false),
                    TitleId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TitleResource", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TitleResource_Title_TitleId",
                        column: x => x.TitleId,
                        principalTable: "Title",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CharacterResources_CharacterId",
                table: "CharacterResources",
                column: "CharacterId");

            migrationBuilder.CreateIndex(
                name: "IX_StaffResource_StaffId",
                table: "StaffResource",
                column: "StaffId");

            migrationBuilder.CreateIndex(
                name: "IX_TitleResource_TitleId",
                table: "TitleResource",
                column: "TitleId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CharacterResources");

            migrationBuilder.DropTable(
                name: "StaffResource");

            migrationBuilder.DropTable(
                name: "TitleResource");

            migrationBuilder.DropTable(
                name: "Title");

            migrationBuilder.RenameColumn(
                name: "SeoMetadata_Title",
                table: "Staff",
                newName: "seoMetadata_Title");

            migrationBuilder.RenameColumn(
                name: "SeoMetadata_Description",
                table: "Staff",
                newName: "seoMetadata_Description");

            migrationBuilder.RenameColumn(
                name: "Hometown",
                table: "Staff",
                newName: "hometown");

            migrationBuilder.RenameColumn(
                name: "SeoMetadata_Title",
                table: "Character",
                newName: "seoMetadata_Title");

            migrationBuilder.RenameColumn(
                name: "SeoMetadata_Description",
                table: "Character",
                newName: "seoMetadata_Description");

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "Id", "Age", "Birthday", "BloodType", "Description", "FavoritesCount", "Gender", "HeigthCm", "ImagePath", "Name", "NativeName", "WeightKg" },
                values: new object[,]
                {
                    { new Guid("11111111-0000-0000-0000-000000000001"), 25, new DateTime(2000, 1, 15, 0, 0, 0, 0, DateTimeKind.Utc), "A", "Brave warrior", 120, "Male", 180m, "/img/leo.png", "Leo", "レオ", 75m },
                    { new Guid("22222222-0000-0000-0000-000000000002"), 19, new DateTime(2006, 6, 20, 0, 0, 0, 0, DateTimeKind.Utc), "B", "Swift archer", 89, "Female", 165m, "/img/mia.png", "Mia", "ミア", 52m },
                    { new Guid("33333333-0000-0000-0000-000000000003"), 32, new DateTime(1993, 11, 5, 0, 0, 0, 0, DateTimeKind.Utc), "O", "Dark mage", 310, "Male", 188m, "/img/kai.png", "Kai", "カイ", 84m },
                    { new Guid("44444444-0000-0000-0000-000000000004"), 21, new DateTime(2004, 3, 12, 0, 0, 0, 0, DateTimeKind.Utc), "AB", "Healer", 450, "Female", 160m, "/img/sora.png", "Sora", "ソラ", 48m }
                });

            migrationBuilder.InsertData(
                table: "Staff",
                columns: new[] { "Id", "Birthday", "BloodType", "Deathday", "Description", "FavoritesCount", "Gender", "ImagePath", "Name", "NativeName", "hometown" },
                values: new object[,]
                {
                    { new Guid("55555555-0000-0000-0000-000000000001"), new DateTime(1980, 5, 10, 0, 0, 0, 0, DateTimeKind.Utc), "A", new DateTime(2022, 8, 15, 0, 0, 0, 0, DateTimeKind.Utc), "Lead animator", 75, "Male", "/img/tanaka.png", "Hiroshi Tanaka", "田中博", "Osaka" },
                    { new Guid("66666666-0000-0000-0000-000000000002"), new DateTime(1992, 9, 25, 0, 0, 0, 0, DateTimeKind.Utc), "B", new DateTime(2025, 1, 10, 0, 0, 0, 0, DateTimeKind.Utc), "Character designer", 130, "Female", "/img/sato.png", "Yuki Sato", "佐藤雪", "Tokyo" },
                    { new Guid("77777777-0000-0000-0000-000000000003"), new DateTime(1970, 12, 1, 0, 0, 0, 0, DateTimeKind.Utc), "O", new DateTime(2024, 4, 20, 0, 0, 0, 0, DateTimeKind.Utc), "Director", 500, "Male", "/img/watanabe.png", "Ken Watanabe", "渡辺健", "Kyoto" },
                    { new Guid("88888888-0000-0000-0000-000000000004"), new DateTime(1985, 7, 18, 0, 0, 0, 0, DateTimeKind.Utc), "AB", new DateTime(2023, 11, 30, 0, 0, 0, 0, DateTimeKind.Utc), "Sound director", 90, "Female", "/img/yamamoto.png", "Aiko Yamamoto", "山本愛子", "Nagoya" }
                });
        }
    }
}
