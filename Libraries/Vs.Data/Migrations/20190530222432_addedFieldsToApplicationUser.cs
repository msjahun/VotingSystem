using Microsoft.EntityFrameworkCore.Migrations;

namespace Vs.Data.Migrations
{
    public partial class addedFieldsToApplicationUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "HasAgreedToTermsAndConditions",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "HasVotedForCandidate",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsRegisteredForElection",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HasAgreedToTermsAndConditions",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "HasVotedForCandidate",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "IsRegisteredForElection",
                table: "AspNetUsers");
        }
    }
}
