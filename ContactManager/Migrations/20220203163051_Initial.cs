using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ContactManager.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categoriy",
                columns: table => new
                {
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categoriy", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Contacts",
                columns: table => new
                {
                    ContactId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Firstname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Lastname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Organization = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateAdded = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CategoryID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacts", x => x.ContactId);
                    table.ForeignKey(
                        name: "FK_Contacts_Categoriy_CategoryID",
                        column: x => x.CategoryID,
                        principalTable: "Categoriy",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categoriy",
                columns: new[] { "CategoryId", "Name" },
                values: new object[,]
                {
                    { 1, "Family" },
                    { 2, "Friend" },
                    { 3, "Work" },
                    { 4, "Other" }
                });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "ContactId", "CategoryID", "DateAdded", "Email", "Firstname", "Lastname", "Organization", "Phone" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2022, 2, 3, 11, 30, 51, 263, DateTimeKind.Local).AddTicks(513), "frodo@gomain.ca", "Frodo", "Baggings", null, "416-123-1233" },
                    { 2, 1, new DateTime(2022, 2, 3, 11, 30, 51, 263, DateTimeKind.Local).AddTicks(539), "frodo@gomain.ca", "FPI", "Baggings", null, "416-123-1233" },
                    { 3, 2, new DateTime(2022, 2, 3, 11, 30, 51, 263, DateTimeKind.Local).AddTicks(541), "frodo@gomain.ca", "ABC", "Baggings", null, "416-123-1233" },
                    { 4, 3, new DateTime(2022, 2, 3, 11, 30, 51, 263, DateTimeKind.Local).AddTicks(543), "frodo@gomain.ca", "CFH", "Baggings", null, "416-123-1233" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Contacts_CategoryID",
                table: "Contacts",
                column: "CategoryID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Contacts");

            migrationBuilder.DropTable(
                name: "Categoriy");
        }
    }
}
