using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LCA_Model.Migrations
{
    public partial class ismembertyping_status : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IsMemberTypingStatus",
                table: "Members",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "ChatRooms",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 13, 19, 53, 42, 780, DateTimeKind.Local).AddTicks(2892), new DateTime(2021, 6, 13, 19, 53, 42, 780, DateTimeKind.Local).AddTicks(2901) });

            migrationBuilder.UpdateData(
                table: "ChatRooms",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 13, 19, 53, 42, 780, DateTimeKind.Local).AddTicks(3453), new DateTime(2021, 6, 13, 19, 53, 42, 780, DateTimeKind.Local).AddTicks(3460) });

            migrationBuilder.UpdateData(
                table: "Friendships",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 13, 19, 53, 42, 779, DateTimeKind.Local).AddTicks(5551), new DateTime(2021, 6, 13, 19, 53, 42, 779, DateTimeKind.Local).AddTicks(5561) });

            migrationBuilder.UpdateData(
                table: "Friendships",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 13, 19, 53, 42, 779, DateTimeKind.Local).AddTicks(7795), new DateTime(2021, 6, 13, 19, 53, 42, 779, DateTimeKind.Local).AddTicks(7803) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 13, 19, 53, 42, 775, DateTimeKind.Local).AddTicks(676), new DateTime(2021, 6, 13, 19, 53, 42, 776, DateTimeKind.Local).AddTicks(4752) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 13, 19, 53, 42, 776, DateTimeKind.Local).AddTicks(8892), new DateTime(2021, 6, 13, 19, 53, 42, 776, DateTimeKind.Local).AddTicks(8899) });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 13, 19, 53, 42, 776, DateTimeKind.Local).AddTicks(8905), new DateTime(2021, 6, 13, 19, 53, 42, 776, DateTimeKind.Local).AddTicks(8907) });

            migrationBuilder.UpdateData(
                table: "MembersProfilePictures",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 13, 19, 53, 42, 778, DateTimeKind.Local).AddTicks(9121), new DateTime(2021, 6, 13, 19, 53, 42, 778, DateTimeKind.Local).AddTicks(9147) });

            migrationBuilder.UpdateData(
                table: "MembersProfilePictures",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 13, 19, 53, 42, 779, DateTimeKind.Local).AddTicks(856), new DateTime(2021, 6, 13, 19, 53, 42, 779, DateTimeKind.Local).AddTicks(863) });

            migrationBuilder.UpdateData(
                table: "MembersProfilePictures",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 13, 19, 53, 42, 779, DateTimeKind.Local).AddTicks(867), new DateTime(2021, 6, 13, 19, 53, 42, 779, DateTimeKind.Local).AddTicks(868) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 13, 19, 53, 42, 780, DateTimeKind.Local).AddTicks(8016), new DateTime(2021, 6, 13, 19, 53, 42, 780, DateTimeKind.Local).AddTicks(8025) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 6, 13, 19, 53, 42, 781, DateTimeKind.Local).AddTicks(734), new DateTime(2021, 6, 13, 19, 53, 42, 781, DateTimeKind.Local).AddTicks(741) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsMemberTypingStatus",
                table: "Members");

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
    }
}
