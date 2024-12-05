using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Yedidim.Data.Migrations
{
    public partial class Keys : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IdVolunteer",
                table: "CallsFromPeople",
                newName: "IdVolunteerId");

            migrationBuilder.RenameColumn(
                name: "IdTypesOfCall",
                table: "CallsFromPeople",
                newName: "IdTypesOfCallId");

            migrationBuilder.CreateIndex(
                name: "IX_CallsFromPeople_IdTypesOfCallId",
                table: "CallsFromPeople",
                column: "IdTypesOfCallId");

            migrationBuilder.CreateIndex(
                name: "IX_CallsFromPeople_IdVolunteerId",
                table: "CallsFromPeople",
                column: "IdVolunteerId");

            migrationBuilder.AddForeignKey(
                name: "FK_CallsFromPeople_TypesOfCall_IdTypesOfCallId",
                table: "CallsFromPeople",
                column: "IdTypesOfCallId",
                principalTable: "TypesOfCall",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CallsFromPeople_Volunteers_IdVolunteerId",
                table: "CallsFromPeople",
                column: "IdVolunteerId",
                principalTable: "Volunteers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CallsFromPeople_TypesOfCall_IdTypesOfCallId",
                table: "CallsFromPeople");

            migrationBuilder.DropForeignKey(
                name: "FK_CallsFromPeople_Volunteers_IdVolunteerId",
                table: "CallsFromPeople");

            migrationBuilder.DropIndex(
                name: "IX_CallsFromPeople_IdTypesOfCallId",
                table: "CallsFromPeople");

            migrationBuilder.DropIndex(
                name: "IX_CallsFromPeople_IdVolunteerId",
                table: "CallsFromPeople");

            migrationBuilder.RenameColumn(
                name: "IdVolunteerId",
                table: "CallsFromPeople",
                newName: "IdVolunteer");

            migrationBuilder.RenameColumn(
                name: "IdTypesOfCallId",
                table: "CallsFromPeople",
                newName: "IdTypesOfCall");
        }
    }
}
