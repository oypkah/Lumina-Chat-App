using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LCA_Model.Migrations
{
    public partial class lastmessagechatroom : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "LastMessage",
                table: "ChatRooms",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LastMessage",
                table: "ChatRooms");

            migrationBuilder.UpdateData(
                table: "ChatRooms",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 11, 1, 31, 25, 897, DateTimeKind.Local).AddTicks(3592), new DateTime(2021, 6, 11, 1, 31, 25, 897, DateTimeKind.Local).AddTicks(3601) });

            migrationBuilder.UpdateData(
                table: "ChatRooms",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 11, 1, 31, 25, 897, DateTimeKind.Local).AddTicks(4074), new DateTime(2021, 6, 11, 1, 31, 25, 897, DateTimeKind.Local).AddTicks(4080) });

            migrationBuilder.UpdateData(
                table: "Friendships",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 11, 1, 31, 25, 896, DateTimeKind.Local).AddTicks(6302), new DateTime(2021, 6, 11, 1, 31, 25, 896, DateTimeKind.Local).AddTicks(6311) });

            migrationBuilder.UpdateData(
                table: "Friendships",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 11, 1, 31, 25, 896, DateTimeKind.Local).AddTicks(8637), new DateTime(2021, 6, 11, 1, 31, 25, 896, DateTimeKind.Local).AddTicks(8643) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 11, 1, 31, 25, 892, DateTimeKind.Local).AddTicks(2902), new DateTime(2021, 6, 11, 1, 31, 25, 893, DateTimeKind.Local).AddTicks(6558) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 11, 1, 31, 25, 894, DateTimeKind.Local).AddTicks(903), new DateTime(2021, 6, 11, 1, 31, 25, 894, DateTimeKind.Local).AddTicks(911) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 11, 1, 31, 25, 894, DateTimeKind.Local).AddTicks(917), new DateTime(2021, 6, 11, 1, 31, 25, 894, DateTimeKind.Local).AddTicks(919) });

            migrationBuilder.UpdateData(
                table: "MembersProfilePictures",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 11, 1, 31, 25, 896, DateTimeKind.Local).AddTicks(309), new DateTime(2021, 6, 11, 1, 31, 25, 896, DateTimeKind.Local).AddTicks(327) });

            migrationBuilder.UpdateData(
                table: "MembersProfilePictures",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 11, 1, 31, 25, 896, DateTimeKind.Local).AddTicks(1798), new DateTime(2021, 6, 11, 1, 31, 25, 896, DateTimeKind.Local).AddTicks(1805) });

            migrationBuilder.UpdateData(
                table: "MembersProfilePictures",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 11, 1, 31, 25, 896, DateTimeKind.Local).AddTicks(1808), new DateTime(2021, 6, 11, 1, 31, 25, 896, DateTimeKind.Local).AddTicks(1810) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 11, 1, 31, 25, 897, DateTimeKind.Local).AddTicks(8719), new DateTime(2021, 6, 11, 1, 31, 25, 897, DateTimeKind.Local).AddTicks(8728) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 11, 1, 31, 25, 898, DateTimeKind.Local).AddTicks(1448), new DateTime(2021, 6, 11, 1, 31, 25, 898, DateTimeKind.Local).AddTicks(1455) });
        }
    }
}
