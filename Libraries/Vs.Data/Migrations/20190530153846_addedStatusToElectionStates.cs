using Microsoft.EntityFrameworkCore.Migrations;

namespace Vs.Data.Migrations
{
    public partial class addedStatusToElectionStates : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsCompleted",
                table: "ElectionStates");

            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "ElectionStates",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Status",
                table: "ElectionStates");

            migrationBuilder.AddColumn<bool>(
                name: "IsCompleted",
                table: "ElectionStates",
                nullable: false,
                defaultValue: false);
        }
    }
}
