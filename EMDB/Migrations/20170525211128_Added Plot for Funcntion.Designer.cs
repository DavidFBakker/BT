using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using EMDB.Models;

namespace EMDB.Migrations
{
    [DbContext(typeof(EMContext))]
    [Migration("20170525211128_Added Plot for Funcntion")]
    partial class AddedPlotforFuncntion
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.2")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EMDB.Channels", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Channel");

                    b.Property<int>("ChannelNumber");

                    b.Property<string>("ChannelType");

                    b.Property<string>("Name");

                    b.Property<string>("Node");

                    b.HasKey("Id");

                    b.ToTable("Channels");
                });

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

            modelBuilder.Entity("EMDB.InputNames", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("InputNames");
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

                    b.Property<double>("E1");

                    b.Property<double>("E10");

                    b.Property<double>("E11");

                    b.Property<double>("E12");

                    b.Property<double>("E13");

                    b.Property<double>("E14");

                    b.Property<double>("E15");

                    b.Property<double>("E16");

                    b.Property<double>("E17");

                    b.Property<double>("E18");

                    b.Property<double>("E19");

                    b.Property<double>("E2");

                    b.Property<double>("E20");

                    b.Property<double>("E21");

                    b.Property<double>("E22");

                    b.Property<double>("E23");

                    b.Property<double>("E24");

                    b.Property<double>("E25");

                    b.Property<double>("E26");

                    b.Property<double>("E27");

                    b.Property<double>("E28");

                    b.Property<double>("E29");

                    b.Property<double>("E3");

                    b.Property<double>("E30");

                    b.Property<double>("E31");

                    b.Property<double>("E32");

                    b.Property<double>("E4");

                    b.Property<double>("E5");

                    b.Property<double>("E6");

                    b.Property<double>("E7");

                    b.Property<double>("E8");

                    b.Property<double>("E9");

                    b.Property<double>("P1");

                    b.Property<double>("P10");

                    b.Property<double>("P11");

                    b.Property<double>("P12");

                    b.Property<double>("P13");

                    b.Property<double>("P14");

                    b.Property<double>("P15");

                    b.Property<double>("P16");

                    b.Property<double>("P17");

                    b.Property<double>("P18");

                    b.Property<double>("P19");

                    b.Property<double>("P2");

                    b.Property<double>("P20");

                    b.Property<double>("P21");

                    b.Property<double>("P22");

                    b.Property<double>("P23");

                    b.Property<double>("P24");

                    b.Property<double>("P25");

                    b.Property<double>("P26");

                    b.Property<double>("P27");

                    b.Property<double>("P28");

                    b.Property<double>("P29");

                    b.Property<double>("P3");

                    b.Property<double>("P30");

                    b.Property<double>("P31");

                    b.Property<double>("P32");

                    b.Property<double>("P4");

                    b.Property<double>("P5");

                    b.Property<double>("P6");

                    b.Property<double>("P7");

                    b.Property<double>("P8");

                    b.Property<double>("P9");

                    b.Property<double>("SC");

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

                    b.Property<double>("X");

                    b.HasKey("DT", "Node");

                    b.ToTable("Packets");
                });

            modelBuilder.Entity("EMDB.Plot", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DT");

                    b.Property<string>("Name");

                    b.Property<double>("Value");

                    b.HasKey("Id");

                    b.ToTable("Plots");
                });
        }
    }
}
