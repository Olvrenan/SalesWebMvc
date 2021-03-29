using Microsoft.EntityFrameworkCore.Migrations;

namespace SalesWebMvc.Migrations
{
    public partial class departmentUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Seller_Department_Departmentid",
                table: "Seller");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "Seller",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "email",
                table: "Seller",
                newName: "Email");

            migrationBuilder.RenameColumn(
                name: "birthDay",
                table: "Seller",
                newName: "BirthDay");

            migrationBuilder.RenameColumn(
                name: "baseSalary",
                table: "Seller",
                newName: "BaseSalary");

            migrationBuilder.RenameColumn(
                name: "Departmentid",
                table: "Seller",
                newName: "DepartmentId");

            migrationBuilder.RenameIndex(
                name: "IX_Seller_Departmentid",
                table: "Seller",
                newName: "IX_Seller_DepartmentId");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Department",
                newName: "Id");

            migrationBuilder.AlterColumn<int>(
                name: "DepartmentId",
                table: "Seller",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Seller_Department_DepartmentId",
                table: "Seller",
                column: "DepartmentId",
                principalTable: "Department",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Seller_Department_DepartmentId",
                table: "Seller");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Seller",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "Seller",
                newName: "email");

            migrationBuilder.RenameColumn(
                name: "DepartmentId",
                table: "Seller",
                newName: "Departmentid");

            migrationBuilder.RenameColumn(
                name: "BirthDay",
                table: "Seller",
                newName: "birthDay");

            migrationBuilder.RenameColumn(
                name: "BaseSalary",
                table: "Seller",
                newName: "baseSalary");

            migrationBuilder.RenameIndex(
                name: "IX_Seller_DepartmentId",
                table: "Seller",
                newName: "IX_Seller_Departmentid");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Department",
                newName: "id");

            migrationBuilder.AlterColumn<int>(
                name: "Departmentid",
                table: "Seller",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Seller_Department_Departmentid",
                table: "Seller",
                column: "Departmentid",
                principalTable: "Department",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
