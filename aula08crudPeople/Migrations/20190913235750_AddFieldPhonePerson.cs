﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace aula08crudPeople.Migrations
{
    public partial class AddFieldPhonePerson : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "phone",
                table: "People",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "phone",
                table: "People");
        }
    }
}
