using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace homeworkFromTg.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Character",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: true),
                    NativeName = table.Column<string>(type: "text", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true),
                    ImagePath = table.Column<string>(type: "text", nullable: true),
                    Gender = table.Column<string>(type: "text", nullable: true),
                    BloodType = table.Column<string>(type: "text", nullable: true),
                    FavoritesCount = table.Column<int>(type: "integer", nullable: false),
                    Age = table.Column<int>(type: "integer", nullable: false),
                    Birthday = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    HeigthCm = table.Column<decimal>(type: "numeric", nullable: false),
                    WeightKg = table.Column<decimal>(type: "numeric", nullable: false),
                    seoMetadata_Title = table.Column<string>(type: "text", nullable: true),
                    seoMetadata_Description = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Character", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Staff",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: true),
                    NativeName = table.Column<string>(type: "text", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true),
                    ImagePath = table.Column<string>(type: "text", nullable: true),
                    Gender = table.Column<string>(type: "text", nullable: true),
                    BloodType = table.Column<string>(type: "text", nullable: true),
                    FavoritesCount = table.Column<int>(type: "integer", nullable: false),
                    Birthday = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Deathday = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    hometown = table.Column<string>(type: "text", nullable: true),
                    seoMetadata_Title = table.Column<string>(type: "text", nullable: true),
                    seoMetadata_Description = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Staff", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "Id", "Age", "Birthday", "BloodType", "Description", "FavoritesCount", "Gender", "HeigthCm", "ImagePath", "Name", "NativeName", "WeightKg" },
                values: new object[,]
                {
                    { new Guid("10000000-0000-0000-0000-000000000001"), 24, new DateTime(1999, 5, 12, 0, 0, 0, 0, DateTimeKind.Utc), "O", "A skilled swordsman with a mysterious past.", 1542, "Male", 178.5m, "/images/alex_storm.png", "Alex Storm", "アレックス・ストーム", 72.0m },
                    { new Guid("11111111-0000-0000-0000-000000000001"), 25, new DateTime(2000, 1, 15, 0, 0, 0, 0, DateTimeKind.Utc), "A", "Brave warrior", 120, "Male", 180m, "/img/leo.png", "Leo", "レオ", 75m },
                    { new Guid("20000000-0000-0000-0000-000000000002"), 19, new DateTime(2004, 11, 30, 0, 0, 0, 0, DateTimeKind.Utc), "A", "A talented healer who loves nature.", 2301, "Female", 165.0m, "/images/luna_spark.png", "Luna Spark", "ルナ・スパーク", 54.2m },
                    { new Guid("22222222-0000-0000-0000-000000000002"), 19, new DateTime(2006, 6, 20, 0, 0, 0, 0, DateTimeKind.Utc), "B", "Swift archer", 89, "Female", 165m, "/img/mia.png", "Mia", "ミア", 52m },
                    { new Guid("33333333-0000-0000-0000-000000000003"), 32, new DateTime(1993, 11, 5, 0, 0, 0, 0, DateTimeKind.Utc), "O", "Dark mage", 310, "Male", 188m, "/img/kai.png", "Kai", "カイ", 84m },
                    { new Guid("44444444-0000-0000-0000-000000000004"), 21, new DateTime(2004, 3, 12, 0, 0, 0, 0, DateTimeKind.Utc), "AB", "Healer", 450, "Female", 160m, "/img/sora.png", "Sora", "ソラ", 48m }
                });

            migrationBuilder.InsertData(
                table: "Staff",
                columns: new[] { "Id", "Birthday", "BloodType", "Deathday", "Description", "FavoritesCount", "Gender", "ImagePath", "Name", "NativeName", "hometown" },
                values: new object[,]
                {
                    { new Guid("30000000-0000-0000-0000-000000000003"), new DateTime(1975, 3, 15, 0, 0, 0, 0, DateTimeKind.Utc), "B", new DateTime(2024, 8, 20, 0, 0, 0, 0, DateTimeKind.Utc), "Award-winning animation director.", 450, "Male", "/images/kenjiro_tanaka.png", "Kenjiro Tanaka", "田中 健二郎", "Tokyo, Japan" },
                    { new Guid("40000000-0000-0000-0000-000000000004"), new DateTime(1988, 7, 22, 0, 0, 0, 0, DateTimeKind.Utc), "AB", new DateTime(2023, 12, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Best-selling light novel author.", 890, "Female", "/images/yumi_sato.png", "Yumi Sato", "佐藤 由美", "Kyoto, Japan" },
                    { new Guid("55555555-0000-0000-0000-000000000001"), new DateTime(1980, 5, 10, 0, 0, 0, 0, DateTimeKind.Utc), "A", new DateTime(2022, 8, 15, 0, 0, 0, 0, DateTimeKind.Utc), "Lead animator", 75, "Male", "/img/tanaka.png", "Hiroshi Tanaka", "田中博", "Osaka" },
                    { new Guid("66666666-0000-0000-0000-000000000002"), new DateTime(1992, 9, 25, 0, 0, 0, 0, DateTimeKind.Utc), "B", new DateTime(2025, 1, 10, 0, 0, 0, 0, DateTimeKind.Utc), "Character designer", 130, "Female", "/img/sato.png", "Yuki Sato", "佐藤雪", "Tokyo" },
                    { new Guid("77777777-0000-0000-0000-000000000003"), new DateTime(1970, 12, 1, 0, 0, 0, 0, DateTimeKind.Utc), "O", new DateTime(2024, 4, 20, 0, 0, 0, 0, DateTimeKind.Utc), "Director", 500, "Male", "/img/watanabe.png", "Ken Watanabe", "渡辺健", "Kyoto" },
                    { new Guid("88888888-0000-0000-0000-000000000004"), new DateTime(1985, 7, 18, 0, 0, 0, 0, DateTimeKind.Utc), "AB", new DateTime(2023, 11, 30, 0, 0, 0, 0, DateTimeKind.Utc), "Sound director", 90, "Female", "/img/yamamoto.png", "Aiko Yamamoto", "山本愛子", "Nagoya" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Character");

            migrationBuilder.DropTable(
                name: "Staff");
        }
    }
}
