// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Persistence;

namespace Persistence.Migrations
{
    [DbContext(typeof(RepositoryDbContext))]
    [Migration("20220423130302_initialization")]
    partial class initialization
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.15")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Domain.Entities.Installment", b =>
                {
                    b.Property<int>("InstallmentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool?>("Active")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(true);

                    b.Property<DateTime?>("CreateDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2022, 4, 23, 17, 33, 2, 184, DateTimeKind.Local).AddTicks(2577));

                    b.Property<int?>("CreateUserId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("InstallmentAmount")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("InstallmentDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("InstallmentDate_shansi")
                        .HasMaxLength(11)
                        .HasColumnType("nvarchar(11)");

                    b.Property<byte>("InstallmentStatus")
                        .HasColumnType("tinyint");

                    b.Property<int>("LoanId")
                        .HasColumnType("int");

                    b.Property<int?>("ModifyUserId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("PaymentDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("PaymentDate_shansi")
                        .HasMaxLength(11)
                        .HasColumnType("nvarchar(11)");

                    b.Property<int?>("PaymentId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.HasKey("InstallmentId");

                    b.HasIndex("LoanId");

                    b.HasIndex("PaymentId");

                    b.ToTable("Installment");
                });

            modelBuilder.Entity("Domain.Entities.Loan", b =>
                {
                    b.Property<int>("LoanId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool?>("Active")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(true);

                    b.Property<DateTime?>("CreateDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2022, 4, 23, 17, 33, 2, 206, DateTimeKind.Local).AddTicks(7756));

                    b.Property<int?>("CreateUserId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long?>("InstallmentAmount")
                        .HasColumnType("bigint");

                    b.Property<int?>("InstallmentCount")
                        .HasColumnType("int");

                    b.Property<long>("LoanAmount")
                        .HasColumnType("bigint");

                    b.Property<byte>("LoanStatus")
                        .HasColumnType("tinyint");

                    b.Property<int?>("ModifyUserId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("PaymentDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("PaymentDate_Shamsi")
                        .HasMaxLength(11)
                        .HasColumnType("nvarchar(11)");

                    b.Property<int?>("PaymentId")
                        .HasColumnType("int");

                    b.Property<long?>("RemainAmount")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int?>("UserSponsorId")
                        .HasColumnType("int");

                    b.HasKey("LoanId");

                    b.HasIndex("PaymentId");

                    b.HasIndex("UserId");

                    b.ToTable("Loan");
                });

            modelBuilder.Entity("Domain.Entities.Payment", b =>
                {
                    b.Property<int>("PaymentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool?>("Active")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(true);

                    b.Property<long>("Amount")
                        .HasColumnType("bigint");

                    b.Property<string>("CardNumber")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<bool>("Confirm")
                        .HasColumnType("bit");

                    b.Property<string>("ConfirmUserDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ConfirmUserId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreateDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2022, 4, 23, 17, 33, 2, 209, DateTimeKind.Local).AddTicks(6502));

                    b.Property<int?>("CreateUserId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FileUload")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ModifyUserId")
                        .HasColumnType("int");

                    b.Property<DateTime>("PaymentDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("PaymentDate_Shamsi")
                        .HasMaxLength(11)
                        .HasColumnType("nvarchar(11)");

                    b.Property<byte>("PaymentStatus")
                        .HasColumnType("tinyint");

                    b.Property<string>("RefrenceNumber")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("PaymentId");

                    b.HasIndex("UserId");

                    b.ToTable("Payment");
                });

            modelBuilder.Entity("Domain.Entities.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool?>("Active")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(true);

                    b.Property<string>("BankName")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("CardNumber")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<DateTime?>("CreateDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2022, 4, 23, 17, 33, 2, 215, DateTimeKind.Local).AddTicks(6411));

                    b.Property<int?>("CreateUserId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Mobile")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("nvarchar(11)");

                    b.Property<int?>("ModifyUserId")
                        .HasColumnType("int");

                    b.Property<string>("Password")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.Property<byte>("UserActiveType")
                        .HasColumnType("tinyint");

                    b.Property<byte>("UserGender")
                        .HasColumnType("tinyint");

                    b.Property<string>("UserName")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<byte>("UserStatus")
                        .HasColumnType("tinyint");

                    b.Property<byte>("UserStatusLife")
                        .HasColumnType("tinyint");

                    b.HasKey("UserId");

                    b.HasIndex("RoleId");

                    b.ToTable("User");
                });

            modelBuilder.Entity("Domain.Entities.UserMenu", b =>
                {
                    b.Property<int>("UserMenuId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool?>("Active")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(true);

                    b.Property<DateTime?>("CreateDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2022, 4, 23, 17, 33, 2, 221, DateTimeKind.Local).AddTicks(898));

                    b.Property<int?>("CreateUserId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("IsShow")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(true);

                    b.Property<int?>("ModifyUserId")
                        .HasColumnType("int");

                    b.Property<int?>("ParentId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.HasKey("UserMenuId");

                    b.ToTable("UserMenu");
                });

            modelBuilder.Entity("Domain.Entities.UserRole", b =>
                {
                    b.Property<int>("RoleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool?>("Active")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(true);

                    b.Property<DateTime?>("CreateDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2022, 4, 23, 17, 33, 2, 224, DateTimeKind.Local).AddTicks(9953));

                    b.Property<int?>("CreateUserId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ModifyUserId")
                        .HasColumnType("int");

                    b.Property<string>("RoleName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.HasKey("RoleId");

                    b.ToTable("UserRole");
                });

            modelBuilder.Entity("Domain.Entities.UserRoleMenuAccess", b =>
                {
                    b.Property<int>("UserRoleMenuAccessId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool?>("Active")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(true);

                    b.Property<DateTime?>("CreateDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2022, 4, 23, 17, 33, 2, 226, DateTimeKind.Local).AddTicks(4958));

                    b.Property<int?>("CreateUserId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ModifyUserId")
                        .HasColumnType("int");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("UserMenuId")
                        .HasColumnType("int");

                    b.HasKey("UserRoleMenuAccessId");

                    b.HasIndex("RoleId");

                    b.HasIndex("UserMenuId");

                    b.ToTable("UserRoleMenuAccess");
                });

            modelBuilder.Entity("Domain.Entities.Installment", b =>
                {
                    b.HasOne("Domain.Entities.Loan", "Loan")
                        .WithMany("Installments")
                        .HasForeignKey("LoanId")
                        .HasConstraintName("FK_Installment_Loan")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.Payment", "Payment")
                        .WithMany("Installments")
                        .HasForeignKey("PaymentId")
                        .HasConstraintName("FK_Installment_Payment")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.Navigation("Loan");

                    b.Navigation("Payment");
                });

            modelBuilder.Entity("Domain.Entities.Loan", b =>
                {
                    b.HasOne("Domain.Entities.Payment", "Payment")
                        .WithMany("Loans")
                        .HasForeignKey("PaymentId")
                        .HasConstraintName("FK_Loan_Payment");

                    b.HasOne("Domain.Entities.User", "User")
                        .WithMany("Loans")
                        .HasForeignKey("UserId")
                        .HasConstraintName("FK_Loan_User")
                        .IsRequired();

                    b.Navigation("Payment");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Domain.Entities.Payment", b =>
                {
                    b.HasOne("Domain.Entities.User", "User")
                        .WithMany("Payments")
                        .HasForeignKey("UserId")
                        .HasConstraintName("FK_Payment_User");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Domain.Entities.User", b =>
                {
                    b.HasOne("Domain.Entities.UserRole", "UserRole")
                        .WithMany("Users")
                        .HasForeignKey("RoleId")
                        .HasConstraintName("FK_UserRole_User")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("UserRole");
                });

            modelBuilder.Entity("Domain.Entities.UserRoleMenuAccess", b =>
                {
                    b.HasOne("Domain.Entities.UserRole", "UserRole")
                        .WithMany("UserRoleMenuAccess")
                        .HasForeignKey("RoleId")
                        .HasConstraintName("FK_UserRoleMenuAccess_UserRole")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.UserMenu", "UserMenu")
                        .WithMany("UserRoleMenuAccess")
                        .HasForeignKey("UserMenuId")
                        .HasConstraintName("FK_UserRoleMenuAccess_UserMenu")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("UserMenu");

                    b.Navigation("UserRole");
                });

            modelBuilder.Entity("Domain.Entities.Loan", b =>
                {
                    b.Navigation("Installments");
                });

            modelBuilder.Entity("Domain.Entities.Payment", b =>
                {
                    b.Navigation("Installments");

                    b.Navigation("Loans");
                });

            modelBuilder.Entity("Domain.Entities.User", b =>
                {
                    b.Navigation("Loans");

                    b.Navigation("Payments");
                });

            modelBuilder.Entity("Domain.Entities.UserMenu", b =>
                {
                    b.Navigation("UserRoleMenuAccess");
                });

            modelBuilder.Entity("Domain.Entities.UserRole", b =>
                {
                    b.Navigation("UserRoleMenuAccess");

                    b.Navigation("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
