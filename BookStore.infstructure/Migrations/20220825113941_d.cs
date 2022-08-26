﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookStore.infstructure.Migrations
{
    public partial class d : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Books");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Books",
                type: "varchar(150)",
                nullable: false,
                defaultValue: "");
        }
    }
}
