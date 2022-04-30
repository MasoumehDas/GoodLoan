using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class initialization : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UserMenu",
                columns: table => new
                {
                    UserMenuId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ParentId = table.Column<int>(type: "int", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsShow = table.Column<bool>(type: "bit", nullable: true, defaultValue: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValue: new DateTime(2022, 4, 23, 17, 33, 2, 221, DateTimeKind.Local).AddTicks(898)),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifyUserId = table.Column<int>(type: "int", nullable: true),
                    CreateUserId = table.Column<int>(type: "int", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: true, defaultValue: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserMenu", x => x.UserMenuId);
                });

            migrationBuilder.CreateTable(
                name: "UserRole",
                columns: table => new
                {
                    RoleId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValue: new DateTime(2022, 4, 23, 17, 33, 2, 224, DateTimeKind.Local).AddTicks(9953)),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifyUserId = table.Column<int>(type: "int", nullable: true),
                    CreateUserId = table.Column<int>(type: "int", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: true, defaultValue: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRole", x => x.RoleId);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Mobile = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: false),
                    UserGender = table.Column<byte>(type: "tinyint", nullable: false),
                    UserStatusLife = table.Column<byte>(type: "tinyint", nullable: false),
                    UserActiveType = table.Column<byte>(type: "tinyint", nullable: false),
                    UserStatus = table.Column<byte>(type: "tinyint", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Password = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    CardNumber = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    BankName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValue: new DateTime(2022, 4, 23, 17, 33, 2, 215, DateTimeKind.Local).AddTicks(6411)),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifyUserId = table.Column<int>(type: "int", nullable: true),
                    CreateUserId = table.Column<int>(type: "int", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: true, defaultValue: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.UserId);
                    table.ForeignKey(
                        name: "FK_UserRole_User",
                        column: x => x.RoleId,
                        principalTable: "UserRole",
                        principalColumn: "RoleId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserRoleMenuAccess",
                columns: table => new
                {
                    UserRoleMenuAccessId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    UserMenuId = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValue: new DateTime(2022, 4, 23, 17, 33, 2, 226, DateTimeKind.Local).AddTicks(4958)),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifyUserId = table.Column<int>(type: "int", nullable: true),
                    CreateUserId = table.Column<int>(type: "int", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: true, defaultValue: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRoleMenuAccess", x => x.UserRoleMenuAccessId);
                    table.ForeignKey(
                        name: "FK_UserRoleMenuAccess_UserMenu",
                        column: x => x.UserMenuId,
                        principalTable: "UserMenu",
                        principalColumn: "UserMenuId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserRoleMenuAccess_UserRole",
                        column: x => x.RoleId,
                        principalTable: "UserRole",
                        principalColumn: "RoleId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Payment",
                columns: table => new
                {
                    PaymentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: true),
                    PaymentDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PaymentDate_Shamsi = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: true),
                    Amount = table.Column<long>(type: "bigint", nullable: false),
                    PaymentStatus = table.Column<byte>(type: "tinyint", nullable: false),
                    CardNumber = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    FileUload = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RefrenceNumber = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Confirm = table.Column<bool>(type: "bit", nullable: false),
                    ConfirmUserId = table.Column<int>(type: "int", nullable: true),
                    ConfirmUserDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValue: new DateTime(2022, 4, 23, 17, 33, 2, 209, DateTimeKind.Local).AddTicks(6502)),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifyUserId = table.Column<int>(type: "int", nullable: true),
                    CreateUserId = table.Column<int>(type: "int", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: true, defaultValue: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payment", x => x.PaymentId);
                    table.ForeignKey(
                        name: "FK_Payment_User",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Loan",
                columns: table => new
                {
                    LoanId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PaymentId = table.Column<int>(type: "int", nullable: true),
                    PaymentDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PaymentDate_Shamsi = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    UserSponsorId = table.Column<int>(type: "int", nullable: true),
                    LoanAmount = table.Column<long>(type: "bigint", nullable: false),
                    RemainAmount = table.Column<long>(type: "bigint", nullable: true),
                    InstallmentAmount = table.Column<long>(type: "bigint", nullable: true),
                    InstallmentCount = table.Column<int>(type: "int", nullable: true),
                    LoanStatus = table.Column<byte>(type: "tinyint", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValue: new DateTime(2022, 4, 23, 17, 33, 2, 206, DateTimeKind.Local).AddTicks(7756)),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifyUserId = table.Column<int>(type: "int", nullable: true),
                    CreateUserId = table.Column<int>(type: "int", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: true, defaultValue: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Loan", x => x.LoanId);
                    table.ForeignKey(
                        name: "FK_Loan_Payment",
                        column: x => x.PaymentId,
                        principalTable: "Payment",
                        principalColumn: "PaymentId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Loan_User",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Installment",
                columns: table => new
                {
                    InstallmentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LoanId = table.Column<int>(type: "int", nullable: false),
                    PaymentId = table.Column<int>(type: "int", nullable: true),
                    PaymentDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    InstallmentDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PaymentDate_shansi = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: true),
                    InstallmentDate_shansi = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: true),
                    InstallmentAmount = table.Column<long>(type: "bigint", nullable: false),
                    InstallmentStatus = table.Column<byte>(type: "tinyint", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValue: new DateTime(2022, 4, 23, 17, 33, 2, 184, DateTimeKind.Local).AddTicks(2577)),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifyUserId = table.Column<int>(type: "int", nullable: true),
                    CreateUserId = table.Column<int>(type: "int", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: true, defaultValue: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Installment", x => x.InstallmentId);
                    table.ForeignKey(
                        name: "FK_Installment_Loan",
                        column: x => x.LoanId,
                        principalTable: "Loan",
                        principalColumn: "LoanId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Installment_Payment",
                        column: x => x.PaymentId,
                        principalTable: "Payment",
                        principalColumn: "PaymentId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Installment_LoanId",
                table: "Installment",
                column: "LoanId");

            migrationBuilder.CreateIndex(
                name: "IX_Installment_PaymentId",
                table: "Installment",
                column: "PaymentId");

            migrationBuilder.CreateIndex(
                name: "IX_Loan_PaymentId",
                table: "Loan",
                column: "PaymentId");

            migrationBuilder.CreateIndex(
                name: "IX_Loan_UserId",
                table: "Loan",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Payment_UserId",
                table: "Payment",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_User_RoleId",
                table: "User",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_UserRoleMenuAccess_RoleId",
                table: "UserRoleMenuAccess",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_UserRoleMenuAccess_UserMenuId",
                table: "UserRoleMenuAccess",
                column: "UserMenuId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Installment");

            migrationBuilder.DropTable(
                name: "UserRoleMenuAccess");

            migrationBuilder.DropTable(
                name: "Loan");

            migrationBuilder.DropTable(
                name: "UserMenu");

            migrationBuilder.DropTable(
                name: "Payment");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "UserRole");
        }
    }
}
