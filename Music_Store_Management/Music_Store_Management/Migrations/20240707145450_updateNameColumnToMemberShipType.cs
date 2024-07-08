using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Music_Store_Management.Migrations
{
    /// <inheritdoc />
    public partial class updateNameColumnToMemberShipType : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Update MembershipTypes SET Name='Pay as you Go' where Id = 1");
            migrationBuilder.Sql("Update MembershipTypes SET Name='Monthly' where Id = 2");
            migrationBuilder.Sql("Update MembershipTypes SET Name='Quartely' where Id = 3");
            migrationBuilder.Sql("Update MembershipTypes SET Name='Annual' where Id = 4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
