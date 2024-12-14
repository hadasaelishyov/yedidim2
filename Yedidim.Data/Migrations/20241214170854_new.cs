using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Yedidim.Data.Migrations
{
    public partial class @new : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CallsFromPeople_TypesOfCall_TypesOfCallId",
                table: "CallsFromPeople");

            migrationBuilder.DropForeignKey(
                name: "FK_CallsFromPeople_Volunteers_VolunteerId",
                table: "CallsFromPeople");

            migrationBuilder.DropColumn(
                name: "IdTypesOfCall",
                table: "CallsFromPeople");

            migrationBuilder.DropColumn(
                name: "IdVolunteer",
                table: "CallsFromPeople");

            migrationBuilder.RenameColumn(
                name: "VolunteerId",
                table: "CallsFromPeople",
                newName: "VolunteerID");

            migrationBuilder.RenameColumn(
                name: "TypesOfCallId",
                table: "CallsFromPeople",
                newName: "TypesOfCallID");

            migrationBuilder.RenameIndex(
                name: "IX_CallsFromPeople_VolunteerId",
                table: "CallsFromPeople",
                newName: "IX_CallsFromPeople_VolunteerID");

            migrationBuilder.RenameIndex(
                name: "IX_CallsFromPeople_TypesOfCallId",
                table: "CallsFromPeople",
                newName: "IX_CallsFromPeople_TypesOfCallID");

            migrationBuilder.AddForeignKey(
                name: "FK_CallsFromPeople_TypesOfCall_TypesOfCallID",
                table: "CallsFromPeople",
                column: "TypesOfCallID",
                principalTable: "TypesOfCall",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CallsFromPeople_Volunteers_VolunteerID",
                table: "CallsFromPeople",
                column: "VolunteerID",
                principalTable: "Volunteers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CallsFromPeople_TypesOfCall_TypesOfCallID",
                table: "CallsFromPeople");

            migrationBuilder.DropForeignKey(
                name: "FK_CallsFromPeople_Volunteers_VolunteerID",
                table: "CallsFromPeople");

            migrationBuilder.RenameColumn(
                name: "VolunteerID",
                table: "CallsFromPeople",
                newName: "VolunteerId");

            migrationBuilder.RenameColumn(
                name: "TypesOfCallID",
                table: "CallsFromPeople",
                newName: "TypesOfCallId");

            migrationBuilder.RenameIndex(
                name: "IX_CallsFromPeople_VolunteerID",
                table: "CallsFromPeople",
                newName: "IX_CallsFromPeople_VolunteerId");

            migrationBuilder.RenameIndex(
                name: "IX_CallsFromPeople_TypesOfCallID",
                table: "CallsFromPeople",
                newName: "IX_CallsFromPeople_TypesOfCallId");

            migrationBuilder.AddColumn<int>(
                name: "IdTypesOfCall",
                table: "CallsFromPeople",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdVolunteer",
                table: "CallsFromPeople",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_CallsFromPeople_TypesOfCall_TypesOfCallId",
                table: "CallsFromPeople",
                column: "TypesOfCallId",
                principalTable: "TypesOfCall",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CallsFromPeople_Volunteers_VolunteerId",
                table: "CallsFromPeople",
                column: "VolunteerId",
                principalTable: "Volunteers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
