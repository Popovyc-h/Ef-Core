using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace homeworkFromTg.Migrations
{
    /// <inheritdoc />
    public partial class AddComment : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CharacterComment",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    UserId = table.Column<Guid>(type: "uuid", nullable: false),
                    Body = table.Column<string>(type: "text", nullable: false),
                    IsSpoiler = table.Column<bool>(type: "boolean", nullable: false),
                    LikesCount = table.Column<int>(type: "integer", nullable: false),
                    Path = table.Column<string>(type: "text", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CharacterId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CharacterComment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CharacterComment_Character_CharacterId",
                        column: x => x.CharacterId,
                        principalTable: "Character",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CharacterComment_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Episode",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Episode", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProfileUser",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProfileUser", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Selection",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Selection", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StaffComment",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    UserId = table.Column<Guid>(type: "uuid", nullable: false),
                    Body = table.Column<string>(type: "text", nullable: false),
                    IsSpoiler = table.Column<bool>(type: "boolean", nullable: false),
                    LikesCount = table.Column<int>(type: "integer", nullable: false),
                    Path = table.Column<string>(type: "text", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    StaffId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StaffComment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StaffComment_Staff_StaffId",
                        column: x => x.StaffId,
                        principalTable: "Staff",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StaffComment_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TitleComment",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    UserId = table.Column<Guid>(type: "uuid", nullable: false),
                    Body = table.Column<string>(type: "text", nullable: false),
                    IsSpoiler = table.Column<bool>(type: "boolean", nullable: false),
                    LikesCount = table.Column<int>(type: "integer", nullable: false),
                    Path = table.Column<string>(type: "text", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    TitleId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TitleComment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TitleComment_Title_TitleId",
                        column: x => x.TitleId,
                        principalTable: "Title",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TitleComment_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EpisodeComment",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    UserId = table.Column<Guid>(type: "uuid", nullable: false),
                    Body = table.Column<string>(type: "text", nullable: false),
                    IsSpoiler = table.Column<bool>(type: "boolean", nullable: false),
                    LikesCount = table.Column<int>(type: "integer", nullable: false),
                    Path = table.Column<string>(type: "text", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    EpisodeId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EpisodeComment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EpisodeComment_Episode_EpisodeId",
                        column: x => x.EpisodeId,
                        principalTable: "Episode",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EpisodeComment_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserComment",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    UserId = table.Column<Guid>(type: "uuid", nullable: false),
                    Body = table.Column<string>(type: "text", nullable: false),
                    IsSpoiler = table.Column<bool>(type: "boolean", nullable: false),
                    LikesCount = table.Column<int>(type: "integer", nullable: false),
                    Path = table.Column<string>(type: "text", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ProfileUserId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserComment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserComment_ProfileUser_ProfileUserId",
                        column: x => x.ProfileUserId,
                        principalTable: "ProfileUser",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserComment_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SelectionComment",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    UserId = table.Column<Guid>(type: "uuid", nullable: false),
                    Body = table.Column<string>(type: "text", nullable: false),
                    IsSpoiler = table.Column<bool>(type: "boolean", nullable: false),
                    LikesCount = table.Column<int>(type: "integer", nullable: false),
                    Path = table.Column<string>(type: "text", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    SelectionId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SelectionComment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SelectionComment_Selection_SelectionId",
                        column: x => x.SelectionId,
                        principalTable: "Selection",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SelectionComment_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CharacterComment_CharacterId",
                table: "CharacterComment",
                column: "CharacterId");

            migrationBuilder.CreateIndex(
                name: "IX_CharacterComment_UserId",
                table: "CharacterComment",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_EpisodeComment_EpisodeId",
                table: "EpisodeComment",
                column: "EpisodeId");

            migrationBuilder.CreateIndex(
                name: "IX_EpisodeComment_UserId",
                table: "EpisodeComment",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_SelectionComment_SelectionId",
                table: "SelectionComment",
                column: "SelectionId");

            migrationBuilder.CreateIndex(
                name: "IX_SelectionComment_UserId",
                table: "SelectionComment",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_StaffComment_StaffId",
                table: "StaffComment",
                column: "StaffId");

            migrationBuilder.CreateIndex(
                name: "IX_StaffComment_UserId",
                table: "StaffComment",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_TitleComment_TitleId",
                table: "TitleComment",
                column: "TitleId");

            migrationBuilder.CreateIndex(
                name: "IX_TitleComment_UserId",
                table: "TitleComment",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserComment_ProfileUserId",
                table: "UserComment",
                column: "ProfileUserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserComment_UserId",
                table: "UserComment",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CharacterComment");

            migrationBuilder.DropTable(
                name: "EpisodeComment");

            migrationBuilder.DropTable(
                name: "SelectionComment");

            migrationBuilder.DropTable(
                name: "StaffComment");

            migrationBuilder.DropTable(
                name: "TitleComment");

            migrationBuilder.DropTable(
                name: "UserComment");

            migrationBuilder.DropTable(
                name: "Episode");

            migrationBuilder.DropTable(
                name: "Selection");

            migrationBuilder.DropTable(
                name: "ProfileUser");
        }
    }
}
