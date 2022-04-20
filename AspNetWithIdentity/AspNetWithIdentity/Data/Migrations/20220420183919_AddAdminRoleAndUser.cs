using AspNetWithIdentity.Data.Extensions;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AspNetWithIdentity.Data.Migrations
{
    public partial class AddAdminRoleAndUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddRole("admin");
            migrationBuilder.AddUserWithRoles("admin@gmail.com", "Admin123!", new[] { "admin" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
        }
    }
}
