using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LCA_Model.Migrations
{
    public partial class connectionid : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ConnectionId",
                table: "Members",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "ChatRooms",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 13, 16, 28, 7, 156, DateTimeKind.Local).AddTicks(8747), new DateTime(2021, 6, 13, 16, 28, 7, 156, DateTimeKind.Local).AddTicks(8755) });

            migrationBuilder.UpdateData(
                table: "ChatRooms",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 13, 16, 28, 7, 156, DateTimeKind.Local).AddTicks(9229), new DateTime(2021, 6, 13, 16, 28, 7, 156, DateTimeKind.Local).AddTicks(9235) });

            migrationBuilder.UpdateData(
                table: "Friendships",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 13, 16, 28, 7, 156, DateTimeKind.Local).AddTicks(876), new DateTime(2021, 6, 13, 16, 28, 7, 156, DateTimeKind.Local).AddTicks(892) });

            migrationBuilder.UpdateData(
                table: "Friendships",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 13, 16, 28, 7, 156, DateTimeKind.Local).AddTicks(3205), new DateTime(2021, 6, 13, 16, 28, 7, 156, DateTimeKind.Local).AddTicks(3214) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 13, 16, 28, 7, 149, DateTimeKind.Local).AddTicks(8045), new DateTime(2021, 6, 13, 16, 28, 7, 151, DateTimeKind.Local).AddTicks(8983) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 13, 16, 28, 7, 152, DateTimeKind.Local).AddTicks(4215), new DateTime(2021, 6, 13, 16, 28, 7, 152, DateTimeKind.Local).AddTicks(4226) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 13, 16, 28, 7, 152, DateTimeKind.Local).AddTicks(4234), new DateTime(2021, 6, 13, 16, 28, 7, 152, DateTimeKind.Local).AddTicks(4236) });

            migrationBuilder.UpdateData(
                table: "MembersProfilePictures",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 13, 16, 28, 7, 155, DateTimeKind.Local).AddTicks(2112), new DateTime(2021, 6, 13, 16, 28, 7, 155, DateTimeKind.Local).AddTicks(2152) });

            migrationBuilder.UpdateData(
                table: "MembersProfilePictures",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 13, 16, 28, 7, 155, DateTimeKind.Local).AddTicks(3998), new DateTime(2021, 6, 13, 16, 28, 7, 155, DateTimeKind.Local).AddTicks(4008) });

            migrationBuilder.UpdateData(
                table: "MembersProfilePictures",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 13, 16, 28, 7, 155, DateTimeKind.Local).AddTicks(4012), new DateTime(2021, 6, 13, 16, 28, 7, 155, DateTimeKind.Local).AddTicks(4018) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 13, 16, 28, 7, 157, DateTimeKind.Local).AddTicks(3819), new DateTime(2021, 6, 13, 16, 28, 7, 157, DateTimeKind.Local).AddTicks(3827) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 13, 16, 28, 7, 157, DateTimeKind.Local).AddTicks(8122), new DateTime(2021, 6, 13, 16, 28, 7, 157, DateTimeKind.Local).AddTicks(8134) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ConnectionId",
                table: "Members");

            migrationBuilder.UpdateData(
                table: "ChatRooms",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 11, 3, 9, 2, 383, DateTimeKind.Local).AddTicks(8898), new DateTime(2021, 6, 11, 3, 9, 2, 383, DateTimeKind.Local).AddTicks(8906) });

            migrationBuilder.UpdateData(
                table: "ChatRooms",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 11, 3, 9, 2, 383, DateTimeKind.Local).AddTicks(9349), new DateTime(2021, 6, 11, 3, 9, 2, 383, DateTimeKind.Local).AddTicks(9354) });

            migrationBuilder.UpdateData(
                table: "Friendships",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 11, 3, 9, 2, 383, DateTimeKind.Local).AddTicks(2222), new DateTime(2021, 6, 11, 3, 9, 2, 383, DateTimeKind.Local).AddTicks(2231) });

            migrationBuilder.UpdateData(
                table: "Friendships",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 11, 3, 9, 2, 383, DateTimeKind.Local).AddTicks(4353), new DateTime(2021, 6, 11, 3, 9, 2, 383, DateTimeKind.Local).AddTicks(4360) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 11, 3, 9, 2, 378, DateTimeKind.Local).AddTicks(9838), new DateTime(2021, 6, 11, 3, 9, 2, 380, DateTimeKind.Local).AddTicks(3243) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 11, 3, 9, 2, 380, DateTimeKind.Local).AddTicks(7907), new DateTime(2021, 6, 11, 3, 9, 2, 380, DateTimeKind.Local).AddTicks(7915) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 11, 3, 9, 2, 380, DateTimeKind.Local).AddTicks(7921), new DateTime(2021, 6, 11, 3, 9, 2, 380, DateTimeKind.Local).AddTicks(7923) });

            migrationBuilder.UpdateData(
                table: "MembersProfilePictures",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 11, 3, 9, 2, 382, DateTimeKind.Local).AddTicks(6479), new DateTime(2021, 6, 11, 3, 9, 2, 382, DateTimeKind.Local).AddTicks(6490) });

            migrationBuilder.UpdateData(
                table: "MembersProfilePictures",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 11, 3, 9, 2, 382, DateTimeKind.Local).AddTicks(7879), new DateTime(2021, 6, 11, 3, 9, 2, 382, DateTimeKind.Local).AddTicks(7884) });

            migrationBuilder.UpdateData(
                table: "MembersProfilePictures",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 11, 3, 9, 2, 382, DateTimeKind.Local).AddTicks(7888), new DateTime(2021, 6, 11, 3, 9, 2, 382, DateTimeKind.Local).AddTicks(7889) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 11, 3, 9, 2, 384, DateTimeKind.Local).AddTicks(3484), new DateTime(2021, 6, 11, 3, 9, 2, 384, DateTimeKind.Local).AddTicks(3492) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 11, 3, 9, 2, 384, DateTimeKind.Local).AddTicks(6048), new DateTime(2021, 6, 11, 3, 9, 2, 384, DateTimeKind.Local).AddTicks(6055) });
        }
    }
}
