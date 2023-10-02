using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MtecDevs.Migrations
{
    public partial class populardados : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "04656110-a95f-4a0e-b0b7-23c9526f587a", "5e5730e1-36a4-4dd2-97b2-a1b16e358bad", "Usuário", "USUÁRIO" },
                    { "22fba5f8-26a0-4f39-8528-b5b60328a504", "da122714-3e76-4f08-a0bf-df6db5188a11", "Moderador", "MODERADOR" },
                    { "ab82aaf3-c1ba-4234-901c-c26d44235c04", "b08b1771-6f90-4f9f-9767-c92c65d4bf2f", "Administrador", "ADMINISTRADOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "4dc07cde-b627-47fe-9c4e-a91bd1e4ef1a", 0, "2d30e0e1-a0fc-46b5-9b07-bfef27a59746", "mariaviih772@gmail.com", true, false, null, "MARIAVIIH772@GMAIL.COM", "MARIAVITORIA", "AQAAAAEAACcQAAAAEDhPrcoMWOClPm5TQEcdpAvWjNZhSzRdcnsAmcEFB33e9K1sA/CoXXyne+fPXsskAQ==", "14997827680", true, "fdb40ac5-7fcc-4769-b7d4-606574e642ec", false, "MariaVitoria" });

            migrationBuilder.InsertData(
                table: "TipoDev",
                columns: new[] { "id", "Nome" },
                values: new object[,]
                {
                    { (byte)1, "fullStack" },
                    { (byte)2, "FrondEnd" },
                    { (byte)3, "BackEnd" },
                    { (byte)4, "Design" },
                    { (byte)5, "Jogos" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ab82aaf3-c1ba-4234-901c-c26d44235c04", "4dc07cde-b627-47fe-9c4e-a91bd1e4ef1a" });

            migrationBuilder.InsertData(
                table: "Usuario",
                columns: new[] { "UserId", "DataNascimento", "Foto", "Nome", "TipoDevId" },
                values: new object[] { "4dc07cde-b627-47fe-9c4e-a91bd1e4ef1a", new DateTime(2006, 6, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "/img/usuarios/", "MARIAVITORIA", (byte)1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "04656110-a95f-4a0e-b0b7-23c9526f587a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "22fba5f8-26a0-4f39-8528-b5b60328a504");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ab82aaf3-c1ba-4234-901c-c26d44235c04", "4dc07cde-b627-47fe-9c4e-a91bd1e4ef1a" });

            migrationBuilder.DeleteData(
                table: "TipoDev",
                keyColumn: "id",
                keyValue: (byte)2);

            migrationBuilder.DeleteData(
                table: "TipoDev",
                keyColumn: "id",
                keyValue: (byte)3);

            migrationBuilder.DeleteData(
                table: "TipoDev",
                keyColumn: "id",
                keyValue: (byte)4);

            migrationBuilder.DeleteData(
                table: "TipoDev",
                keyColumn: "id",
                keyValue: (byte)5);

            migrationBuilder.DeleteData(
                table: "Usuario",
                keyColumn: "UserId",
                keyValue: "4dc07cde-b627-47fe-9c4e-a91bd1e4ef1a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ab82aaf3-c1ba-4234-901c-c26d44235c04");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4dc07cde-b627-47fe-9c4e-a91bd1e4ef1a");

            migrationBuilder.DeleteData(
                table: "TipoDev",
                keyColumn: "id",
                keyValue: (byte)1);
        }
    }
}
