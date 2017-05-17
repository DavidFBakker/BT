using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using EMDB.Models;

namespace EMDB.Migrations
{
    [DbContext(typeof(EMContext))]
    [Migration("20170516012711_Updated Packet with W")]
    partial class UpdatedPacketwithW
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.2")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EMDB.EmToName", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Channel");

                    b.Property<string>("Name");

                    b.Property<string>("Node");

                    b.HasKey("Id");

                    b.ToTable("EmToNames");
                });

            modelBuilder.Entity("EMDB.Packet", b =>
                {
                    b.Property<DateTime>("DT");

                    b.Property<string>("Node");

                    b.Property<double>("Delta1");

                    b.Property<double>("Delta10");

                    b.Property<double>("Delta11");

                    b.Property<double>("Delta12");

                    b.Property<double>("Delta13");

                    b.Property<double>("Delta14");

                    b.Property<double>("Delta15");

                    b.Property<double>("Delta16");

                    b.Property<double>("Delta17");

                    b.Property<double>("Delta18");

                    b.Property<double>("Delta19");

                    b.Property<double>("Delta2");

                    b.Property<double>("Delta20");

                    b.Property<double>("Delta21");

                    b.Property<double>("Delta22");

                    b.Property<double>("Delta23");

                    b.Property<double>("Delta24");

                    b.Property<double>("Delta25");

                    b.Property<double>("Delta26");

                    b.Property<double>("Delta27");

                    b.Property<double>("Delta28");

                    b.Property<double>("Delta29");

                    b.Property<double>("Delta3");

                    b.Property<double>("Delta30");

                    b.Property<double>("Delta31");

                    b.Property<double>("Delta32");

                    b.Property<double>("Delta4");

                    b.Property<double>("Delta5");

                    b.Property<double>("Delta6");

                    b.Property<double>("Delta7");

                    b.Property<double>("Delta8");

                    b.Property<double>("Delta9");

                    b.Property<double>("DeltaSeconds");

                    b.Property<int>("E1");

                    b.Property<int>("E10");

                    b.Property<int>("E11");

                    b.Property<int>("E12");

                    b.Property<int>("E13");

                    b.Property<int>("E14");

                    b.Property<int>("E15");

                    b.Property<int>("E16");

                    b.Property<int>("E17");

                    b.Property<int>("E18");

                    b.Property<int>("E19");

                    b.Property<int>("E2");

                    b.Property<int>("E20");

                    b.Property<int>("E21");

                    b.Property<int>("E22");

                    b.Property<int>("E23");

                    b.Property<int>("E24");

                    b.Property<int>("E25");

                    b.Property<int>("E26");

                    b.Property<int>("E27");

                    b.Property<int>("E28");

                    b.Property<int>("E29");

                    b.Property<int>("E3");

                    b.Property<int>("E30");

                    b.Property<int>("E31");

                    b.Property<int>("E32");

                    b.Property<int>("E4");

                    b.Property<int>("E5");

                    b.Property<int>("E6");

                    b.Property<int>("E7");

                    b.Property<int>("E8");

                    b.Property<int>("E9");

                    b.Property<int>("P1");

                    b.Property<int>("P10");

                    b.Property<int>("P11");

                    b.Property<int>("P12");

                    b.Property<int>("P13");

                    b.Property<int>("P14");

                    b.Property<int>("P15");

                    b.Property<int>("P16");

                    b.Property<int>("P17");

                    b.Property<int>("P18");

                    b.Property<int>("P19");

                    b.Property<int>("P2");

                    b.Property<int>("P20");

                    b.Property<int>("P21");

                    b.Property<int>("P22");

                    b.Property<int>("P23");

                    b.Property<int>("P24");

                    b.Property<int>("P25");

                    b.Property<int>("P26");

                    b.Property<int>("P27");

                    b.Property<int>("P28");

                    b.Property<int>("P29");

                    b.Property<int>("P3");

                    b.Property<int>("P30");

                    b.Property<int>("P31");

                    b.Property<int>("P32");

                    b.Property<int>("P4");

                    b.Property<int>("P5");

                    b.Property<int>("P6");

                    b.Property<int>("P7");

                    b.Property<int>("P8");

                    b.Property<int>("P9");

                    b.Property<int>("SC");

                    b.Property<double>("V");

                    b.Property<double>("W1");

                    b.Property<double>("W10");

                    b.Property<double>("W11");

                    b.Property<double>("W12");

                    b.Property<double>("W13");

                    b.Property<double>("W14");

                    b.Property<double>("W15");

                    b.Property<double>("W16");

                    b.Property<double>("W17");

                    b.Property<double>("W18");

                    b.Property<double>("W19");

                    b.Property<double>("W2");

                    b.Property<double>("W20");

                    b.Property<double>("W21");

                    b.Property<double>("W22");

                    b.Property<double>("W23");

                    b.Property<double>("W24");

                    b.Property<double>("W25");

                    b.Property<double>("W26");

                    b.Property<double>("W27");

                    b.Property<double>("W28");

                    b.Property<double>("W29");

                    b.Property<double>("W3");

                    b.Property<double>("W30");

                    b.Property<double>("W31");

                    b.Property<double>("W32");

                    b.Property<double>("W4");

                    b.Property<double>("W5");

                    b.Property<double>("W6");

                    b.Property<double>("W7");

                    b.Property<double>("W8");

                    b.Property<double>("W9");

                    b.Property<double>("Wh1");

                    b.Property<double>("Wh10");

                    b.Property<double>("Wh11");

                    b.Property<double>("Wh12");

                    b.Property<double>("Wh13");

                    b.Property<double>("Wh14");

                    b.Property<double>("Wh15");

                    b.Property<double>("Wh16");

                    b.Property<double>("Wh17");

                    b.Property<double>("Wh18");

                    b.Property<double>("Wh19");

                    b.Property<double>("Wh2");

                    b.Property<double>("Wh20");

                    b.Property<double>("Wh21");

                    b.Property<double>("Wh22");

                    b.Property<double>("Wh23");

                    b.Property<double>("Wh24");

                    b.Property<double>("Wh25");

                    b.Property<double>("Wh26");

                    b.Property<double>("Wh27");

                    b.Property<double>("Wh28");

                    b.Property<double>("Wh29");

                    b.Property<double>("Wh3");

                    b.Property<double>("Wh30");

                    b.Property<double>("Wh31");

                    b.Property<double>("Wh32");

                    b.Property<double>("Wh4");

                    b.Property<double>("Wh5");

                    b.Property<double>("Wh6");

                    b.Property<double>("Wh7");

                    b.Property<double>("Wh8");

                    b.Property<double>("Wh9");

                    b.Property<int>("X");

                    b.HasKey("DT", "Node");

                    b.ToTable("Packets");
                });
        }
    }
}
