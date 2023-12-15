using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ContactManagerAPI.Migrations
{
    public partial class RequiredMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Phonenumber",
                table: "Contacts",
                newName: "PhoneNumber");

            migrationBuilder.RenameColumn(
                name: "Lastname",
                table: "Contacts",
                newName: "LastName");

            migrationBuilder.RenameColumn(
                name: "Firstname",
                table: "Contacts",
                newName: "FirstName");

            migrationBuilder.RenameColumn(
                name: "Displayname",
                table: "Contacts",
                newName: "DisplayName");

            migrationBuilder.RenameColumn(
                name: "Birthdate",
                table: "Contacts",
                newName: "BirthDate");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastChangeTimestamp",
                table: "Contacts",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DisplayName",
                table: "Contacts",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Contacts_Email",
                table: "Contacts",
                column: "Email",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Contacts_Email",
                table: "Contacts");

            migrationBuilder.RenameColumn(
                name: "PhoneNumber",
                table: "Contacts",
                newName: "Phonenumber");

            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "Contacts",
                newName: "Lastname");

            migrationBuilder.RenameColumn(
                name: "FirstName",
                table: "Contacts",
                newName: "Firstname");

            migrationBuilder.RenameColumn(
                name: "DisplayName",
                table: "Contacts",
                newName: "Displayname");

            migrationBuilder.RenameColumn(
                name: "BirthDate",
                table: "Contacts",
                newName: "Birthdate");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastChangeTimestamp",
                table: "Contacts",
                type: "timestamp with time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<string>(
                name: "Displayname",
                table: "Contacts",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");
        }
    }
}
