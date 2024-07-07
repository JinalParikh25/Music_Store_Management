﻿using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.SqlServer;

#nullable disable

namespace Music_Store_Management.Migrations
{
    /// <inheritdoc />
    public partial class PopulateMembershipTypes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO MembershipTypes (Id,SignUpFee,DurationInMonths,DiscountRate) VALUES (1,0,0,0)");
            migrationBuilder.Sql("INSERT INTO MembershipTypes (Id,SignUpFee,DurationInMonths,DiscountRate) VALUES (2,30,1,10)");
            migrationBuilder.Sql("INSERT INTO MembershipTypes (Id,SignUpFee,DurationInMonths,DiscountRate) VALUES (3,90,3,15)");
            migrationBuilder.Sql("INSERT INTO MembershipTypes (Id,SignUpFee,DurationInMonths,DiscountRate) VALUES (4,300,12,20)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
