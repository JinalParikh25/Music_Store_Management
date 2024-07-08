using Microsoft.Build.Experimental;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Music_Store_Management.Migrations
{
    /// <inheritdoc />
    public partial class updateValueInGenres : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Insert into Genres (Name) Values ('Comedy')");
            migrationBuilder.Sql("Insert into Genres (Name) Values ('Horror')");
            migrationBuilder.Sql("Insert into Genres (Name) Values ('Thriller')");
            migrationBuilder.Sql("Insert into Genres (Name) Values ('Drama')");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
