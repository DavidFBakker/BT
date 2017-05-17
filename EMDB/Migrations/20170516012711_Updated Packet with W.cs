using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EMDB.Migrations
{
    public partial class UpdatedPacketwithW : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SecCounter",
                table: "Packets",
                newName: "W9");

            migrationBuilder.AddColumn<double>(
                name: "DeltaSeconds",
                table: "Packets",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "W1",
                table: "Packets",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "W10",
                table: "Packets",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "W11",
                table: "Packets",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "W12",
                table: "Packets",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "W13",
                table: "Packets",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "W14",
                table: "Packets",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "W15",
                table: "Packets",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "W16",
                table: "Packets",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "W17",
                table: "Packets",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "W18",
                table: "Packets",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "W19",
                table: "Packets",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "W2",
                table: "Packets",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "W20",
                table: "Packets",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "W21",
                table: "Packets",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "W22",
                table: "Packets",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "W23",
                table: "Packets",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "W24",
                table: "Packets",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "W25",
                table: "Packets",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "W26",
                table: "Packets",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "W27",
                table: "Packets",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "W28",
                table: "Packets",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "W29",
                table: "Packets",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "W3",
                table: "Packets",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "W30",
                table: "Packets",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "W31",
                table: "Packets",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "W32",
                table: "Packets",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "W4",
                table: "Packets",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "W5",
                table: "Packets",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "W6",
                table: "Packets",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "W7",
                table: "Packets",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "W8",
                table: "Packets",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DeltaSeconds",
                table: "Packets");

            migrationBuilder.DropColumn(
                name: "W1",
                table: "Packets");

            migrationBuilder.DropColumn(
                name: "W10",
                table: "Packets");

            migrationBuilder.DropColumn(
                name: "W11",
                table: "Packets");

            migrationBuilder.DropColumn(
                name: "W12",
                table: "Packets");

            migrationBuilder.DropColumn(
                name: "W13",
                table: "Packets");

            migrationBuilder.DropColumn(
                name: "W14",
                table: "Packets");

            migrationBuilder.DropColumn(
                name: "W15",
                table: "Packets");

            migrationBuilder.DropColumn(
                name: "W16",
                table: "Packets");

            migrationBuilder.DropColumn(
                name: "W17",
                table: "Packets");

            migrationBuilder.DropColumn(
                name: "W18",
                table: "Packets");

            migrationBuilder.DropColumn(
                name: "W19",
                table: "Packets");

            migrationBuilder.DropColumn(
                name: "W2",
                table: "Packets");

            migrationBuilder.DropColumn(
                name: "W20",
                table: "Packets");

            migrationBuilder.DropColumn(
                name: "W21",
                table: "Packets");

            migrationBuilder.DropColumn(
                name: "W22",
                table: "Packets");

            migrationBuilder.DropColumn(
                name: "W23",
                table: "Packets");

            migrationBuilder.DropColumn(
                name: "W24",
                table: "Packets");

            migrationBuilder.DropColumn(
                name: "W25",
                table: "Packets");

            migrationBuilder.DropColumn(
                name: "W26",
                table: "Packets");

            migrationBuilder.DropColumn(
                name: "W27",
                table: "Packets");

            migrationBuilder.DropColumn(
                name: "W28",
                table: "Packets");

            migrationBuilder.DropColumn(
                name: "W29",
                table: "Packets");

            migrationBuilder.DropColumn(
                name: "W3",
                table: "Packets");

            migrationBuilder.DropColumn(
                name: "W30",
                table: "Packets");

            migrationBuilder.DropColumn(
                name: "W31",
                table: "Packets");

            migrationBuilder.DropColumn(
                name: "W32",
                table: "Packets");

            migrationBuilder.DropColumn(
                name: "W4",
                table: "Packets");

            migrationBuilder.DropColumn(
                name: "W5",
                table: "Packets");

            migrationBuilder.DropColumn(
                name: "W6",
                table: "Packets");

            migrationBuilder.DropColumn(
                name: "W7",
                table: "Packets");

            migrationBuilder.DropColumn(
                name: "W8",
                table: "Packets");

            migrationBuilder.RenameColumn(
                name: "W9",
                table: "Packets",
                newName: "SecCounter");
        }
    }
}
