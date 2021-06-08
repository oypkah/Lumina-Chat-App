using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LCA_Model.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Members",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    About = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    LastLoginDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastLogoutDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ProfilePicId = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedComputerName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    CreatedIp = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedComputerName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    ModifiedIp = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Members", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Friendships",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FriendShipStatus = table.Column<int>(type: "int", nullable: false),
                    UserOneId = table.Column<int>(type: "int", nullable: false),
                    UserTwoId = table.Column<int>(type: "int", nullable: false),
                    ActionUserId = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedComputerName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    CreatedIp = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedComputerName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    ModifiedIp = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Friendships", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Friendships_Members_ActionUserId",
                        column: x => x.ActionUserId,
                        principalTable: "Members",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Friendships_Members_UserOneId",
                        column: x => x.UserOneId,
                        principalTable: "Members",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Friendships_Members_UserTwoId",
                        column: x => x.UserTwoId,
                        principalTable: "Members",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "MembersProfilePictures",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Filename = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Filepath = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    MemberId = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedComputerName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    CreatedIp = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedComputerName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    ModifiedIp = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MembersProfilePictures", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MembersProfilePictures_Members_MemberId",
                        column: x => x.MemberId,
                        principalTable: "Members",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Messages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Body = table.Column<string>(type: "nvarchar(3000)", maxLength: 3000, nullable: false),
                    MessageStatus = table.Column<int>(type: "int", nullable: false),
                    MessageImageStatus = table.Column<int>(type: "int", nullable: false),
                    SenderId = table.Column<int>(type: "int", nullable: false),
                    ReceivId = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedComputerName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    CreatedIp = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedComputerName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    ModifiedIp = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Messages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Messages_Members_ReceivId",
                        column: x => x.ReceivId,
                        principalTable: "Members",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Messages_Members_SenderId",
                        column: x => x.SenderId,
                        principalTable: "Members",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Members",
                columns: new[] { "Id", "About", "CreatedComputerName", "CreatedDate", "CreatedIp", "Email", "FirstName", "LastLoginDate", "LastLogoutDate", "LastName", "ModifiedComputerName", "ModifiedDate", "ModifiedIp", "Password", "ProfilePicId", "Status", "UserName" },
                values: new object[] { 1, "hope", "Admin", new DateTime(2021, 6, 8, 4, 9, 15, 760, DateTimeKind.Local).AddTicks(5084), "127.0.0.1", "furkan_aslan2209@hotmail.com", "Furkan", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Aslan", "Admin", new DateTime(2021, 6, 8, 4, 9, 15, 761, DateTimeKind.Local).AddTicks(8323), "127.0.0.1", "1903", 0, 0, "HostGhost" });

            migrationBuilder.InsertData(
                table: "Members",
                columns: new[] { "Id", "About", "CreatedComputerName", "CreatedDate", "CreatedIp", "Email", "FirstName", "LastLoginDate", "LastLogoutDate", "LastName", "ModifiedComputerName", "ModifiedDate", "ModifiedIp", "Password", "ProfilePicId", "Status", "UserName" },
                values: new object[] { 2, "Turkiye", "Admin", new DateTime(2021, 6, 8, 4, 9, 15, 762, DateTimeKind.Local).AddTicks(2988), "127.0.0.1", "mehmetcankural@hotmail.com", "Mehmetcan", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kural", "Admin", new DateTime(2021, 6, 8, 4, 9, 15, 762, DateTimeKind.Local).AddTicks(3030), "127.0.0.1", "1907", 0, 0, "DarkSouls" });

            migrationBuilder.InsertData(
                table: "Members",
                columns: new[] { "Id", "About", "CreatedComputerName", "CreatedDate", "CreatedIp", "Email", "FirstName", "LastLoginDate", "LastLogoutDate", "LastName", "ModifiedComputerName", "ModifiedDate", "ModifiedIp", "Password", "ProfilePicId", "Status", "UserName" },
                values: new object[] { 3, "But I can't walk on the path of the right, because I'm wrong..", "Admin", new DateTime(2021, 6, 8, 4, 9, 15, 762, DateTimeKind.Local).AddTicks(3178), "127.0.0.1", "frkkrm16@hotmail.com", "Kerem", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Buğra", "Admin", new DateTime(2021, 6, 8, 4, 9, 15, 762, DateTimeKind.Local).AddTicks(3180), "127.0.0.1", "1907", 0, 0, "frkkrm16" });

            migrationBuilder.InsertData(
                table: "Friendships",
                columns: new[] { "Id", "ActionUserId", "CreatedComputerName", "CreatedDate", "CreatedIp", "FriendShipStatus", "ModifiedComputerName", "ModifiedDate", "ModifiedIp", "Status", "UserOneId", "UserTwoId" },
                values: new object[] { 1, 2, "Admin", new DateTime(2021, 6, 8, 4, 9, 15, 764, DateTimeKind.Local).AddTicks(6618), "127.0.0.1", 1, "Admin", new DateTime(2021, 6, 8, 4, 9, 15, 764, DateTimeKind.Local).AddTicks(6653), "127.0.0.1", 0, 1, 2 });

            migrationBuilder.InsertData(
                table: "Friendships",
                columns: new[] { "Id", "ActionUserId", "CreatedComputerName", "CreatedDate", "CreatedIp", "FriendShipStatus", "ModifiedComputerName", "ModifiedDate", "ModifiedIp", "Status", "UserOneId", "UserTwoId" },
                values: new object[] { 2, 3, "Admin", new DateTime(2021, 6, 8, 4, 9, 15, 764, DateTimeKind.Local).AddTicks(8774), "127.0.0.1", 1, "Admin", new DateTime(2021, 6, 8, 4, 9, 15, 764, DateTimeKind.Local).AddTicks(8782), "127.0.0.1", 0, 1, 3 });

            migrationBuilder.InsertData(
                table: "Messages",
                columns: new[] { "Id", "Body", "CreatedComputerName", "CreatedDate", "CreatedIp", "MessageImageStatus", "MessageStatus", "ModifiedComputerName", "ModifiedDate", "ModifiedIp", "ReceivId", "SenderId", "Status" },
                values: new object[] { 1, "Test", "Admin", new DateTime(2021, 6, 8, 4, 9, 15, 765, DateTimeKind.Local).AddTicks(2806), "127.0.0.1", 1, 1, "Admin", new DateTime(2021, 6, 8, 4, 9, 15, 765, DateTimeKind.Local).AddTicks(2817), "127.0.0.1", 3, 1, 0 });

            migrationBuilder.CreateIndex(
                name: "IX_Friendships_ActionUserId",
                table: "Friendships",
                column: "ActionUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Friendships_UserOneId",
                table: "Friendships",
                column: "UserOneId");

            migrationBuilder.CreateIndex(
                name: "IX_Friendships_UserTwoId",
                table: "Friendships",
                column: "UserTwoId");

            migrationBuilder.CreateIndex(
                name: "IX_MembersProfilePictures_MemberId",
                table: "MembersProfilePictures",
                column: "MemberId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Messages_ReceivId",
                table: "Messages",
                column: "ReceivId");

            migrationBuilder.CreateIndex(
                name: "IX_Messages_SenderId",
                table: "Messages",
                column: "SenderId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Friendships");

            migrationBuilder.DropTable(
                name: "MembersProfilePictures");

            migrationBuilder.DropTable(
                name: "Messages");

            migrationBuilder.DropTable(
                name: "Members");
        }
    }
}
