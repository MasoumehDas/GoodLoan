using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class changeUserMenu : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserRoleMenuAccess_UserMenu",
                table: "UserRoleMenuAccess");

            migrationBuilder.DropColumn(
                name: "ParentId",
                table: "UserMenu");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "UserRoleMenuAccess",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2022, 5, 16, 0, 56, 9, 200, DateTimeKind.Local).AddTicks(8070),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2022, 4, 23, 17, 33, 2, 226, DateTimeKind.Local).AddTicks(4958));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "UserRole",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2022, 5, 16, 0, 56, 9, 198, DateTimeKind.Local).AddTicks(7863),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2022, 4, 23, 17, 33, 2, 224, DateTimeKind.Local).AddTicks(9953));

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "UserMenu",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "UserMenu",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2022, 5, 16, 0, 56, 9, 191, DateTimeKind.Local).AddTicks(7324),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2022, 4, 23, 17, 33, 2, 221, DateTimeKind.Local).AddTicks(898));

            migrationBuilder.AddColumn<string>(
                name: "ControlID",
                table: "UserMenu",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Lang",
                table: "UserMenu",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "User",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2022, 5, 16, 0, 56, 9, 183, DateTimeKind.Local).AddTicks(2030),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2022, 4, 23, 17, 33, 2, 215, DateTimeKind.Local).AddTicks(6411));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Payment",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2022, 5, 16, 0, 56, 9, 175, DateTimeKind.Local).AddTicks(7689),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2022, 4, 23, 17, 33, 2, 209, DateTimeKind.Local).AddTicks(6502));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Loan",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2022, 5, 16, 0, 56, 9, 170, DateTimeKind.Local).AddTicks(6511),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2022, 4, 23, 17, 33, 2, 206, DateTimeKind.Local).AddTicks(7756));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Installment",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2022, 5, 16, 0, 56, 9, 125, DateTimeKind.Local).AddTicks(6281),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2022, 4, 23, 17, 33, 2, 184, DateTimeKind.Local).AddTicks(2577));

            migrationBuilder.CreateTable(
                name: "_Enums",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EnumsType = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    EnumsValue = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    EntitiyUsed = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    EnumsTitle = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Enums", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Setting",
                columns: table => new
                {
                    SettingId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SettingName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    SettinCaption = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    SettingValue = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Category = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValue: new DateTime(2022, 5, 16, 0, 56, 9, 178, DateTimeKind.Local).AddTicks(41)),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifyUserId = table.Column<int>(type: "int", nullable: true),
                    CreateUserId = table.Column<int>(type: "int", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: true, defaultValue: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Setting", x => x.SettingId);
                });

            migrationBuilder.CreateTable(
                name: "UserSubMenu",
                columns: table => new
                {
                    UserSubMenuId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ControlID = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    SelectorID = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    MenuTitle = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Lang = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsShowMenu = table.Column<bool>(type: "bit", nullable: true, defaultValue: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValue: new DateTime(2022, 5, 16, 0, 56, 9, 203, DateTimeKind.Local).AddTicks(1431)),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifyUserId = table.Column<int>(type: "int", nullable: true),
                    CreateUserId = table.Column<int>(type: "int", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: true, defaultValue: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserSubMenu", x => x.UserSubMenuId);
                });

            migrationBuilder.CreateTable(
                name: "VisitedHistory",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Date_shansi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Browser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifyUserId = table.Column<int>(type: "int", nullable: true),
                    CreateUserId = table.Column<int>(type: "int", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VisitedHistory", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_UserRoleMenuAccess_UserMenu",
                table: "UserRoleMenuAccess",
                column: "UserMenuId",
                principalTable: "UserSubMenu",
                principalColumn: "UserSubMenuId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserRoleMenuAccess_UserMenu",
                table: "UserRoleMenuAccess");

            migrationBuilder.DropTable(
                name: "_Enums");

            migrationBuilder.DropTable(
                name: "Setting");

            migrationBuilder.DropTable(
                name: "UserSubMenu");

            migrationBuilder.DropTable(
                name: "VisitedHistory");

            migrationBuilder.DropColumn(
                name: "ControlID",
                table: "UserMenu");

            migrationBuilder.DropColumn(
                name: "Lang",
                table: "UserMenu");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "UserRoleMenuAccess",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2022, 4, 23, 17, 33, 2, 226, DateTimeKind.Local).AddTicks(4958),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2022, 5, 16, 0, 56, 9, 200, DateTimeKind.Local).AddTicks(8070));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "UserRole",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2022, 4, 23, 17, 33, 2, 224, DateTimeKind.Local).AddTicks(9953),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2022, 5, 16, 0, 56, 9, 198, DateTimeKind.Local).AddTicks(7863));

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "UserMenu",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "UserMenu",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2022, 4, 23, 17, 33, 2, 221, DateTimeKind.Local).AddTicks(898),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2022, 5, 16, 0, 56, 9, 191, DateTimeKind.Local).AddTicks(7324));

            migrationBuilder.AddColumn<int>(
                name: "ParentId",
                table: "UserMenu",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "User",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2022, 4, 23, 17, 33, 2, 215, DateTimeKind.Local).AddTicks(6411),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2022, 5, 16, 0, 56, 9, 183, DateTimeKind.Local).AddTicks(2030));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Payment",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2022, 4, 23, 17, 33, 2, 209, DateTimeKind.Local).AddTicks(6502),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2022, 5, 16, 0, 56, 9, 175, DateTimeKind.Local).AddTicks(7689));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Loan",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2022, 4, 23, 17, 33, 2, 206, DateTimeKind.Local).AddTicks(7756),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2022, 5, 16, 0, 56, 9, 170, DateTimeKind.Local).AddTicks(6511));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Installment",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2022, 4, 23, 17, 33, 2, 184, DateTimeKind.Local).AddTicks(2577),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2022, 5, 16, 0, 56, 9, 125, DateTimeKind.Local).AddTicks(6281));

            migrationBuilder.AddForeignKey(
                name: "FK_UserRoleMenuAccess_UserMenu",
                table: "UserRoleMenuAccess",
                column: "UserMenuId",
                principalTable: "UserMenu",
                principalColumn: "UserMenuId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
