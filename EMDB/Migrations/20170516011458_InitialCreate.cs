using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace EMDB.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EmToNames",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Channel = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Node = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmToNames", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Packets",
                columns: table => new
                {
                    DT = table.Column<DateTime>(nullable: false),
                    Node = table.Column<string>(nullable: false),
                    Delta1 = table.Column<double>(nullable: false),
                    Delta10 = table.Column<double>(nullable: false),
                    Delta11 = table.Column<double>(nullable: false),
                    Delta12 = table.Column<double>(nullable: false),
                    Delta13 = table.Column<double>(nullable: false),
                    Delta14 = table.Column<double>(nullable: false),
                    Delta15 = table.Column<double>(nullable: false),
                    Delta16 = table.Column<double>(nullable: false),
                    Delta17 = table.Column<double>(nullable: false),
                    Delta18 = table.Column<double>(nullable: false),
                    Delta19 = table.Column<double>(nullable: false),
                    Delta2 = table.Column<double>(nullable: false),
                    Delta20 = table.Column<double>(nullable: false),
                    Delta21 = table.Column<double>(nullable: false),
                    Delta22 = table.Column<double>(nullable: false),
                    Delta23 = table.Column<double>(nullable: false),
                    Delta24 = table.Column<double>(nullable: false),
                    Delta25 = table.Column<double>(nullable: false),
                    Delta26 = table.Column<double>(nullable: false),
                    Delta27 = table.Column<double>(nullable: false),
                    Delta28 = table.Column<double>(nullable: false),
                    Delta29 = table.Column<double>(nullable: false),
                    Delta3 = table.Column<double>(nullable: false),
                    Delta30 = table.Column<double>(nullable: false),
                    Delta31 = table.Column<double>(nullable: false),
                    Delta32 = table.Column<double>(nullable: false),
                    Delta4 = table.Column<double>(nullable: false),
                    Delta5 = table.Column<double>(nullable: false),
                    Delta6 = table.Column<double>(nullable: false),
                    Delta7 = table.Column<double>(nullable: false),
                    Delta8 = table.Column<double>(nullable: false),
                    Delta9 = table.Column<double>(nullable: false),
                    E1 = table.Column<int>(nullable: false),
                    E10 = table.Column<int>(nullable: false),
                    E11 = table.Column<int>(nullable: false),
                    E12 = table.Column<int>(nullable: false),
                    E13 = table.Column<int>(nullable: false),
                    E14 = table.Column<int>(nullable: false),
                    E15 = table.Column<int>(nullable: false),
                    E16 = table.Column<int>(nullable: false),
                    E17 = table.Column<int>(nullable: false),
                    E18 = table.Column<int>(nullable: false),
                    E19 = table.Column<int>(nullable: false),
                    E2 = table.Column<int>(nullable: false),
                    E20 = table.Column<int>(nullable: false),
                    E21 = table.Column<int>(nullable: false),
                    E22 = table.Column<int>(nullable: false),
                    E23 = table.Column<int>(nullable: false),
                    E24 = table.Column<int>(nullable: false),
                    E25 = table.Column<int>(nullable: false),
                    E26 = table.Column<int>(nullable: false),
                    E27 = table.Column<int>(nullable: false),
                    E28 = table.Column<int>(nullable: false),
                    E29 = table.Column<int>(nullable: false),
                    E3 = table.Column<int>(nullable: false),
                    E30 = table.Column<int>(nullable: false),
                    E31 = table.Column<int>(nullable: false),
                    E32 = table.Column<int>(nullable: false),
                    E4 = table.Column<int>(nullable: false),
                    E5 = table.Column<int>(nullable: false),
                    E6 = table.Column<int>(nullable: false),
                    E7 = table.Column<int>(nullable: false),
                    E8 = table.Column<int>(nullable: false),
                    E9 = table.Column<int>(nullable: false),
                    P1 = table.Column<int>(nullable: false),
                    P10 = table.Column<int>(nullable: false),
                    P11 = table.Column<int>(nullable: false),
                    P12 = table.Column<int>(nullable: false),
                    P13 = table.Column<int>(nullable: false),
                    P14 = table.Column<int>(nullable: false),
                    P15 = table.Column<int>(nullable: false),
                    P16 = table.Column<int>(nullable: false),
                    P17 = table.Column<int>(nullable: false),
                    P18 = table.Column<int>(nullable: false),
                    P19 = table.Column<int>(nullable: false),
                    P2 = table.Column<int>(nullable: false),
                    P20 = table.Column<int>(nullable: false),
                    P21 = table.Column<int>(nullable: false),
                    P22 = table.Column<int>(nullable: false),
                    P23 = table.Column<int>(nullable: false),
                    P24 = table.Column<int>(nullable: false),
                    P25 = table.Column<int>(nullable: false),
                    P26 = table.Column<int>(nullable: false),
                    P27 = table.Column<int>(nullable: false),
                    P28 = table.Column<int>(nullable: false),
                    P29 = table.Column<int>(nullable: false),
                    P3 = table.Column<int>(nullable: false),
                    P30 = table.Column<int>(nullable: false),
                    P31 = table.Column<int>(nullable: false),
                    P32 = table.Column<int>(nullable: false),
                    P4 = table.Column<int>(nullable: false),
                    P5 = table.Column<int>(nullable: false),
                    P6 = table.Column<int>(nullable: false),
                    P7 = table.Column<int>(nullable: false),
                    P8 = table.Column<int>(nullable: false),
                    P9 = table.Column<int>(nullable: false),
                    SC = table.Column<int>(nullable: false),
                    SecCounter = table.Column<double>(nullable: false),
                    V = table.Column<double>(nullable: false),
                    Wh1 = table.Column<double>(nullable: false),
                    Wh10 = table.Column<double>(nullable: false),
                    Wh11 = table.Column<double>(nullable: false),
                    Wh12 = table.Column<double>(nullable: false),
                    Wh13 = table.Column<double>(nullable: false),
                    Wh14 = table.Column<double>(nullable: false),
                    Wh15 = table.Column<double>(nullable: false),
                    Wh16 = table.Column<double>(nullable: false),
                    Wh17 = table.Column<double>(nullable: false),
                    Wh18 = table.Column<double>(nullable: false),
                    Wh19 = table.Column<double>(nullable: false),
                    Wh2 = table.Column<double>(nullable: false),
                    Wh20 = table.Column<double>(nullable: false),
                    Wh21 = table.Column<double>(nullable: false),
                    Wh22 = table.Column<double>(nullable: false),
                    Wh23 = table.Column<double>(nullable: false),
                    Wh24 = table.Column<double>(nullable: false),
                    Wh25 = table.Column<double>(nullable: false),
                    Wh26 = table.Column<double>(nullable: false),
                    Wh27 = table.Column<double>(nullable: false),
                    Wh28 = table.Column<double>(nullable: false),
                    Wh29 = table.Column<double>(nullable: false),
                    Wh3 = table.Column<double>(nullable: false),
                    Wh30 = table.Column<double>(nullable: false),
                    Wh31 = table.Column<double>(nullable: false),
                    Wh32 = table.Column<double>(nullable: false),
                    Wh4 = table.Column<double>(nullable: false),
                    Wh5 = table.Column<double>(nullable: false),
                    Wh6 = table.Column<double>(nullable: false),
                    Wh7 = table.Column<double>(nullable: false),
                    Wh8 = table.Column<double>(nullable: false),
                    Wh9 = table.Column<double>(nullable: false),
                    X = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Packets", x => new { x.DT, x.Node });
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EmToNames");

            migrationBuilder.DropTable(
                name: "Packets");
        }
    }
}
