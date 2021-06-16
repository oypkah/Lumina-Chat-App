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
                    Role = table.Column<int>(type: "int", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    About = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    MemberStatus = table.Column<int>(type: "int", nullable: false),
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
                    ChatRoomId = table.Column<int>(type: "int", nullable: false),
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
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ChatRooms",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FriendshipId = table.Column<int>(type: "int", nullable: false),
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
                    table.PrimaryKey("PK_ChatRooms", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ChatRooms_Friendships_FriendshipId",
                        column: x => x.FriendshipId,
                        principalTable: "Friendships",
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
                    ChatRoomId = table.Column<int>(type: "int", nullable: false),
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
                        name: "FK_Messages_ChatRooms_ChatRoomId",
                        column: x => x.ChatRoomId,
                        principalTable: "ChatRooms",
                        principalColumn: "Id");
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
                columns: new[] { "Id", "About", "CreatedComputerName", "CreatedDate", "CreatedIp", "Email", "FirstName", "LastLoginDate", "LastLogoutDate", "LastName", "MemberStatus", "ModifiedComputerName", "ModifiedDate", "ModifiedIp", "Password", "ProfilePicId", "Role", "Status", "UserName" },
                values: new object[] { 1, "hope", "Admin", new DateTime(2021, 6, 11, 1, 31, 25, 892, DateTimeKind.Local).AddTicks(2902), "127.0.0.1", "furkan_aslan2209@hotmail.com", "Furkan", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Aslan", 0, "Admin", new DateTime(2021, 6, 11, 1, 31, 25, 893, DateTimeKind.Local).AddTicks(6558), "127.0.0.1", "1903", 0, 0, 0, "HostGhost" });

            migrationBuilder.InsertData(
                table: "Members",
                columns: new[] { "Id", "About", "CreatedComputerName", "CreatedDate", "CreatedIp", "Email", "FirstName", "LastLoginDate", "LastLogoutDate", "LastName", "MemberStatus", "ModifiedComputerName", "ModifiedDate", "ModifiedIp", "Password", "ProfilePicId", "Role", "Status", "UserName" },
                values: new object[] { 2, "Turkiye", "Admin", new DateTime(2021, 6, 11, 1, 31, 25, 894, DateTimeKind.Local).AddTicks(903), "127.0.0.1", "mehmetcankural@hotmail.com", "Mehmetcan", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kural", 0, "Admin", new DateTime(2021, 6, 11, 1, 31, 25, 894, DateTimeKind.Local).AddTicks(911), "127.0.0.1", "1907", 0, 0, 0, "DarkSouls" });

            migrationBuilder.InsertData(
                table: "Members",
                columns: new[] { "Id", "About", "CreatedComputerName", "CreatedDate", "CreatedIp", "Email", "FirstName", "LastLoginDate", "LastLogoutDate", "LastName", "MemberStatus", "ModifiedComputerName", "ModifiedDate", "ModifiedIp", "Password", "ProfilePicId", "Role", "Status", "UserName" },
                values: new object[] { 3, "But I can't walk on the path of the right, because I'm wrong..", "Admin", new DateTime(2021, 6, 11, 1, 31, 25, 894, DateTimeKind.Local).AddTicks(917), "127.0.0.1", "frkkrm16@hotmail.com", "Kerem", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Buğra", 0, "Admin", new DateTime(2021, 6, 11, 1, 31, 25, 894, DateTimeKind.Local).AddTicks(919), "127.0.0.1", "1907", 0, 0, 0, "frkkrm16" });

            migrationBuilder.InsertData(
                table: "Friendships",
                columns: new[] { "Id", "ActionUserId", "ChatRoomId", "CreatedComputerName", "CreatedDate", "CreatedIp", "FriendShipStatus", "ModifiedComputerName", "ModifiedDate", "ModifiedIp", "Status", "UserOneId", "UserTwoId" },
                values: new object[,]
                {
                    { 1, 2, 1, "Admin", new DateTime(2021, 6, 11, 1, 31, 25, 896, DateTimeKind.Local).AddTicks(6302), "127.0.0.1", 1, "Admin", new DateTime(2021, 6, 11, 1, 31, 25, 896, DateTimeKind.Local).AddTicks(6311), "127.0.0.1", 0, 1, 2 },
                    { 2, 3, 2, "Admin", new DateTime(2021, 6, 11, 1, 31, 25, 896, DateTimeKind.Local).AddTicks(8637), "127.0.0.1", 1, "Admin", new DateTime(2021, 6, 11, 1, 31, 25, 896, DateTimeKind.Local).AddTicks(8643), "127.0.0.1", 0, 1, 3 }
                });

            migrationBuilder.InsertData(
                table: "MembersProfilePictures",
                columns: new[] { "Id", "CreatedComputerName", "CreatedDate", "CreatedIp", "Filename", "Filepath", "MemberId", "ModifiedComputerName", "ModifiedDate", "ModifiedIp", "Status" },
                values: new object[,]
                {
                    { 1, "Admin", new DateTime(2021, 6, 11, 1, 31, 25, 896, DateTimeKind.Local).AddTicks(309), "127.0.0.1", ".jpg", "http://localhost:52941/uploads/furkanaslan.jpg", 1, "Admin", new DateTime(2021, 6, 11, 1, 31, 25, 896, DateTimeKind.Local).AddTicks(327), "127.0.0.1", 0 },
                    { 2, "Admin", new DateTime(2021, 6, 11, 1, 31, 25, 896, DateTimeKind.Local).AddTicks(1798), "127.0.0.1", ".jpg", "http://localhost:52941/uploads/default.jpg", 2, "Admin", new DateTime(2021, 6, 11, 1, 31, 25, 896, DateTimeKind.Local).AddTicks(1805), "127.0.0.1", 0 },
                    { 3, "Admin", new DateTime(2021, 6, 11, 1, 31, 25, 896, DateTimeKind.Local).AddTicks(1808), "127.0.0.1", ".jpg", "http://localhost:52941/uploads/kerembugra", 3, "Admin", new DateTime(2021, 6, 11, 1, 31, 25, 896, DateTimeKind.Local).AddTicks(1810), "127.0.0.1", 0 }
                });

            migrationBuilder.InsertData(
                table: "ChatRooms",
                columns: new[] { "Id", "CreatedComputerName", "CreatedDate", "CreatedIp", "FriendshipId", "ModifiedComputerName", "ModifiedDate", "ModifiedIp", "Status" },
                values: new object[] { 1, "Admin", new DateTime(2021, 6, 11, 1, 31, 25, 897, DateTimeKind.Local).AddTicks(3592), "127.0.0.1", 1, "Admin", new DateTime(2021, 6, 11, 1, 31, 25, 897, DateTimeKind.Local).AddTicks(3601), "127.0.0.1", 0 });

            migrationBuilder.InsertData(
                table: "ChatRooms",
                columns: new[] { "Id", "CreatedComputerName", "CreatedDate", "CreatedIp", "FriendshipId", "ModifiedComputerName", "ModifiedDate", "ModifiedIp", "Status" },
                values: new object[] { 2, "Admin", new DateTime(2021, 6, 11, 1, 31, 25, 897, DateTimeKind.Local).AddTicks(4074), "127.0.0.1", 2, "Admin", new DateTime(2021, 6, 11, 1, 31, 25, 897, DateTimeKind.Local).AddTicks(4080), "127.0.0.1", 1 });

            migrationBuilder.InsertData(
                table: "Messages",
                columns: new[] { "Id", "Body", "ChatRoomId", "CreatedComputerName", "CreatedDate", "CreatedIp", "MessageImageStatus", "MessageStatus", "ModifiedComputerName", "ModifiedDate", "ModifiedIp", "ReceivId", "SenderId", "Status" },
                values: new object[] { 1, "Junior, nasılsın?", 1, "Admin", new DateTime(2021, 6, 11, 1, 31, 25, 897, DateTimeKind.Local).AddTicks(8719), "127.0.0.1", 1, 1, "Admin", new DateTime(2021, 6, 11, 1, 31, 25, 897, DateTimeKind.Local).AddTicks(8728), "127.0.0.1", 1, 3, 0 });

            migrationBuilder.InsertData(
                table: "Messages",
                columns: new[] { "Id", "Body", "ChatRoomId", "CreatedComputerName", "CreatedDate", "CreatedIp", "MessageImageStatus", "MessageStatus", "ModifiedComputerName", "ModifiedDate", "ModifiedIp", "ReceivId", "SenderId", "Status" },
                values: new object[] { 2, "İyiyim, sen nasılsın?", 1, "Admin", new DateTime(2021, 6, 11, 1, 31, 25, 898, DateTimeKind.Local).AddTicks(1448), "127.0.0.1", 1, 1, "Admin", new DateTime(2021, 6, 11, 1, 31, 25, 898, DateTimeKind.Local).AddTicks(1455), "127.0.0.1", 3, 1, 0 });

            migrationBuilder.CreateIndex(
                name: "IX_ChatRooms_FriendshipId",
                table: "ChatRooms",
                column: "FriendshipId",
                unique: true);

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
                name: "IX_Messages_ChatRoomId",
                table: "Messages",
                column: "ChatRoomId");

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
                name: "MembersProfilePictures");

            migrationBuilder.DropTable(
                name: "Messages");

            migrationBuilder.DropTable(
                name: "ChatRooms");

            migrationBuilder.DropTable(
                name: "Friendships");

            migrationBuilder.DropTable(
                name: "Members");
        }
    }
}
