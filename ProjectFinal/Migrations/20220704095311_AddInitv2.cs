using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjectFinal.Migrations
{
    public partial class AddInitv2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tasks_Projects_InProjectProjectId",
                table: "Tasks");

            migrationBuilder.DropForeignKey(
                name: "FK_Tasks_Users_AssignUserUserId",
                table: "Tasks");

            migrationBuilder.RenameColumn(
                name: "status",
                table: "Tasks",
                newName: "Status");

            migrationBuilder.RenameColumn(
                name: "InProjectProjectId",
                table: "Tasks",
                newName: "InProjectId");

            migrationBuilder.RenameColumn(
                name: "AssignUserUserId",
                table: "Tasks",
                newName: "AssignbyUserId");

            migrationBuilder.RenameIndex(
                name: "IX_Tasks_InProjectProjectId",
                table: "Tasks",
                newName: "IX_Tasks_InProjectId");

            migrationBuilder.RenameIndex(
                name: "IX_Tasks_AssignUserUserId",
                table: "Tasks",
                newName: "IX_Tasks_AssignbyUserId");

            migrationBuilder.AddColumn<int>(
                name: "AcceptInviation",
                table: "ProjectMembers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Tasks_Projects_InProjectId",
                table: "Tasks",
                column: "InProjectId",
                principalTable: "Projects",
                principalColumn: "ProjectId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Tasks_Users_AssignbyUserId",
                table: "Tasks",
                column: "AssignbyUserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tasks_Projects_InProjectId",
                table: "Tasks");

            migrationBuilder.DropForeignKey(
                name: "FK_Tasks_Users_AssignbyUserId",
                table: "Tasks");

            migrationBuilder.DropColumn(
                name: "AcceptInviation",
                table: "ProjectMembers");

            migrationBuilder.RenameColumn(
                name: "Status",
                table: "Tasks",
                newName: "status");

            migrationBuilder.RenameColumn(
                name: "InProjectId",
                table: "Tasks",
                newName: "InProjectProjectId");

            migrationBuilder.RenameColumn(
                name: "AssignbyUserId",
                table: "Tasks",
                newName: "AssignUserUserId");

            migrationBuilder.RenameIndex(
                name: "IX_Tasks_InProjectId",
                table: "Tasks",
                newName: "IX_Tasks_InProjectProjectId");

            migrationBuilder.RenameIndex(
                name: "IX_Tasks_AssignbyUserId",
                table: "Tasks",
                newName: "IX_Tasks_AssignUserUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tasks_Projects_InProjectProjectId",
                table: "Tasks",
                column: "InProjectProjectId",
                principalTable: "Projects",
                principalColumn: "ProjectId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Tasks_Users_AssignUserUserId",
                table: "Tasks",
                column: "AssignUserUserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
