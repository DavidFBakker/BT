using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EMDB
{
    public class Packet
    {
        [Key]
        [Column(Order = 1)]
        public DateTime DT { get; set; }

        [Key]
        [Column(Order = 2)]
        public string Node { get; set; }

        public double SC { get; set; }
        public double DeltaSeconds { get; set; }
        public double V { get; set; }
        public double X { get; set; }

        public double E1 { get; set; }
        public double P1 { get; set; }
        public double Wh1 { get; set; }
        public double Delta1 { get; set; }
        public double W1 { get; set; }
        public double E2 { get; set; }
        public double P2 { get; set; }
        public double Wh2 { get; set; }
        public double Delta2 { get; set; }
        public double W2 { get; set; }
        public double E3 { get; set; }
        public double P3 { get; set; }
        public double Wh3 { get; set; }
        public double Delta3 { get; set; }
        public double W3 { get; set; }
        public double E4 { get; set; }
        public double P4 { get; set; }
        public double Wh4 { get; set; }
        public double Delta4 { get; set; }
        public double W4 { get; set; }
        public double E5 { get; set; }
        public double P5 { get; set; }
        public double Wh5 { get; set; }
        public double Delta5 { get; set; }
        public double W5 { get; set; }
        public double E6 { get; set; }
        public double P6 { get; set; }
        public double Wh6 { get; set; }
        public double Delta6 { get; set; }
        public double W6 { get; set; }
        public double E7 { get; set; }
        public double P7 { get; set; }
        public double Wh7 { get; set; }
        public double Delta7 { get; set; }
        public double W7 { get; set; }
        public double E8 { get; set; }
        public double P8 { get; set; }
        public double Wh8 { get; set; }
        public double Delta8 { get; set; }
        public double W8 { get; set; }
        public double E9 { get; set; }
        public double P9 { get; set; }
        public double Wh9 { get; set; }
        public double Delta9 { get; set; }
        public double W9 { get; set; }
        public double E10 { get; set; }
        public double P10 { get; set; }
        public double Wh10 { get; set; }
        public double Delta10 { get; set; }
        public double W10 { get; set; }
        public double E11 { get; set; }
        public double P11 { get; set; }
        public double Wh11 { get; set; }
        public double Delta11 { get; set; }
        public double W11 { get; set; }
        public double E12 { get; set; }
        public double P12 { get; set; }
        public double Wh12 { get; set; }
        public double Delta12 { get; set; }
        public double W12 { get; set; }
        public double E13 { get; set; }
        public double P13 { get; set; }
        public double Wh13 { get; set; }
        public double Delta13 { get; set; }
        public double W13 { get; set; }
        public double E14 { get; set; }
        public double P14 { get; set; }
        public double Wh14 { get; set; }
        public double Delta14 { get; set; }
        public double W14 { get; set; }
        public double E15 { get; set; }
        public double P15 { get; set; }
        public double Wh15 { get; set; }
        public double Delta15 { get; set; }
        public double W15 { get; set; }
        public double E16 { get; set; }
        public double P16 { get; set; }
        public double Wh16 { get; set; }
        public double Delta16 { get; set; }
        public double W16 { get; set; }
        public double E17 { get; set; }
        public double P17 { get; set; }
        public double Wh17 { get; set; }
        public double Delta17 { get; set; }
        public double W17 { get; set; }
        public double E18 { get; set; }
        public double P18 { get; set; }
        public double Wh18 { get; set; }
        public double Delta18 { get; set; }
        public double W18 { get; set; }
        public double E19 { get; set; }
        public double P19 { get; set; }
        public double Wh19 { get; set; }
        public double Delta19 { get; set; }
        public double W19 { get; set; }
        public double E20 { get; set; }
        public double P20 { get; set; }
        public double Wh20 { get; set; }
        public double Delta20 { get; set; }
        public double W20 { get; set; }
        public double E21 { get; set; }
        public double P21 { get; set; }
        public double Wh21 { get; set; }
        public double Delta21 { get; set; }
        public double W21 { get; set; }
        public double E22 { get; set; }
        public double P22 { get; set; }
        public double Wh22 { get; set; }
        public double Delta22 { get; set; }
        public double W22 { get; set; }
        public double E23 { get; set; }
        public double P23 { get; set; }
        public double Wh23 { get; set; }
        public double Delta23 { get; set; }
        public double W23 { get; set; }
        public double E24 { get; set; }
        public double P24 { get; set; }
        public double Wh24 { get; set; }
        public double Delta24 { get; set; }
        public double W24 { get; set; }
        public double E25 { get; set; }
        public double P25 { get; set; }
        public double Wh25 { get; set; }
        public double Delta25 { get; set; }
        public double W25 { get; set; }
        public double E26 { get; set; }
        public double P26 { get; set; }
        public double Wh26 { get; set; }
        public double Delta26 { get; set; }
        public double W26 { get; set; }
        public double E27 { get; set; }
        public double P27 { get; set; }
        public double Wh27 { get; set; }
        public double Delta27 { get; set; }
        public double W27 { get; set; }
        public double E28 { get; set; }
        public double P28 { get; set; }
        public double Wh28 { get; set; }
        public double Delta28 { get; set; }
        public double W28 { get; set; }
        public double E29 { get; set; }
        public double P29 { get; set; }
        public double Wh29 { get; set; }
        public double Delta29 { get; set; }
        public double W29 { get; set; }
        public double E30 { get; set; }
        public double P30 { get; set; }
        public double Wh30 { get; set; }
        public double Delta30 { get; set; }
        public double W30 { get; set; }
        public double E31 { get; set; }
        public double P31 { get; set; }
        public double Wh31 { get; set; }
        public double Delta31 { get; set; }
        public double W31 { get; set; }
        public double E32 { get; set; }
        public double P32 { get; set; }
        public double Wh32 { get; set; }
        public double Delta32 { get; set; }
        public double W32 { get; set; }


        public void Add(Packet packet)
        {
            DeltaSeconds = packet.SC - SC;
            SC = packet.SC;
            var doubleervalDiv = DeltaSeconds / 3600;

            Delta1 = packet.E1 - E1;
            E1 = packet.E1;
            Delta2 = packet.E2 - E2;
            E2 = packet.E2;
            Delta3 = packet.E3 - E3;
            E3 = packet.E3;
            Delta4 = packet.E4 - E4;
            E4 = packet.E4;
            Delta5 = packet.E5 - E5;
            E5 = packet.E5;
            Delta6 = packet.E6 - E6;
            E6 = packet.E6;
            Delta7 = packet.E7 - E7;
            E7 = packet.E7;
            Delta8 = packet.E8 - E8;
            E8 = packet.E8;
            Delta9 = packet.E9 - E9;
            E9 = packet.E9;
            Delta10 = packet.E10 - E10;
            E10 = packet.E10;
            Delta11 = packet.E11 - E11;
            E11 = packet.E11;
            Delta12 = packet.E12 - E12;
            E12 = packet.E12;
            Delta13 = packet.E13 - E13;
            E13 = packet.E13;
            Delta14 = packet.E14 - E14;
            E14 = packet.E14;
            Delta15 = packet.E15 - E15;
            E15 = packet.E15;
            Delta16 = packet.E16 - E16;
            E16 = packet.E16;
            Delta17 = packet.E17 - E17;
            E17 = packet.E17;
            Delta18 = packet.E18 - E18;
            E18 = packet.E18;
            Delta19 = packet.E19 - E19;
            E19 = packet.E19;
            Delta20 = packet.E20 - E20;
            E20 = packet.E20;
            Delta21 = packet.E21 - E21;
            E21 = packet.E21;
            Delta22 = packet.E22 - E22;
            E22 = packet.E22;
            Delta23 = packet.E23 - E23;
            E23 = packet.E23;
            Delta24 = packet.E24 - E24;
            E24 = packet.E24;
            Delta25 = packet.E25 - E25;
            E25 = packet.E25;
            Delta26 = packet.E26 - E26;
            E26 = packet.E26;
            Delta27 = packet.E27 - E27;
            E27 = packet.E27;
            Delta28 = packet.E28 - E28;
            E28 = packet.E28;
            Delta29 = packet.E29 - E29;
            E29 = packet.E29;
            Delta30 = packet.E30 - E30;
            E30 = packet.E30;
            Delta31 = packet.E31 - E31;
            E31 = packet.E31;
            Delta32 = packet.E32 - E32;
            E32 = packet.E32;

            W1 = Delta1 / DeltaSeconds;
            W2 = Delta2 / DeltaSeconds;
            W3 = Delta3 / DeltaSeconds;
            W4 = Delta4 / DeltaSeconds;
            W5 = Delta5 / DeltaSeconds;
            W6 = Delta6 / DeltaSeconds;
            W7 = Delta7 / DeltaSeconds;
            W8 = Delta8 / DeltaSeconds;
            W9 = Delta9 / DeltaSeconds;
            W10 = Delta10 / DeltaSeconds;
            W11 = Delta11 / DeltaSeconds;
            W12 = Delta12 / DeltaSeconds;
            W13 = Delta13 / DeltaSeconds;
            W14 = Delta14 / DeltaSeconds;
            W15 = Delta15 / DeltaSeconds;
            W16 = Delta16 / DeltaSeconds;
            W17 = Delta17 / DeltaSeconds;
            W18 = Delta18 / DeltaSeconds;
            W19 = Delta19 / DeltaSeconds;
            W20 = Delta20 / DeltaSeconds;
            W21 = Delta21 / DeltaSeconds;
            W22 = Delta22 / DeltaSeconds;
            W23 = Delta23 / DeltaSeconds;
            W24 = Delta24 / DeltaSeconds;
            W25 = Delta25 / DeltaSeconds;
            W26 = Delta26 / DeltaSeconds;
            W27 = Delta27 / DeltaSeconds;
            W28 = Delta28 / DeltaSeconds;
            W29 = Delta29 / DeltaSeconds;
            W30 = Delta30 / DeltaSeconds;
            W31 = Delta31 / DeltaSeconds;
            W32 = Delta32 / DeltaSeconds;


            Wh1 += packet.P1 * doubleervalDiv;
            Wh2 += packet.P2 * doubleervalDiv;
            Wh3 += packet.P3 * doubleervalDiv;
            Wh4 += packet.P4 * doubleervalDiv;
            Wh5 += packet.P5 * doubleervalDiv;
            Wh6 += packet.P6 * doubleervalDiv;
            Wh7 += packet.P7 * doubleervalDiv;
            Wh8 += packet.P8 * doubleervalDiv;
            Wh9 += packet.P9 * doubleervalDiv;
            Wh10 += packet.P10 * doubleervalDiv;
            Wh11 += packet.P11 * doubleervalDiv;
            Wh12 += packet.P12 * doubleervalDiv;
            Wh13 += packet.P13 * doubleervalDiv;
            Wh14 += packet.P14 * doubleervalDiv;
            Wh15 += packet.P15 * doubleervalDiv;
            Wh16 += packet.P16 * doubleervalDiv;
            Wh17 += packet.P17 * doubleervalDiv;
            Wh18 += packet.P18 * doubleervalDiv;
            Wh19 += packet.P19 * doubleervalDiv;
            Wh20 += packet.P20 * doubleervalDiv;
            Wh21 += packet.P21 * doubleervalDiv;
            Wh22 += packet.P22 * doubleervalDiv;
            Wh23 += packet.P23 * doubleervalDiv;
            Wh24 += packet.P24 * doubleervalDiv;
            Wh25 += packet.P25 * doubleervalDiv;
            Wh26 += packet.P26 * doubleervalDiv;
            Wh27 += packet.P27 * doubleervalDiv;
            Wh28 += packet.P28 * doubleervalDiv;
            Wh29 += packet.P29 * doubleervalDiv;
            Wh30 += packet.P30 * doubleervalDiv;
            Wh31 += packet.P31 * doubleervalDiv;
            Wh32 += packet.P32 * doubleervalDiv;

            P1 = packet.P1;
            P2 = packet.P2;
            P3 = packet.P3;
            P4 = packet.P4;
            P5 = packet.P5;
            P6 = packet.P6;
            P7 = packet.P7;
            P8 = packet.P8;
            P9 = packet.P9;
            P10 = packet.P10;
            P11 = packet.P11;
            P12 = packet.P12;
            P13 = packet.P13;
            P14 = packet.P14;
            P15 = packet.P15;
            P16 = packet.P16;
            P17 = packet.P17;
            P18 = packet.P18;
            P19 = packet.P19;
            P20 = packet.P20;
            P21 = packet.P21;
            P22 = packet.P22;
            P23 = packet.P23;
            P24 = packet.P24;
            P25 = packet.P25;
            P26 = packet.P26;
            P27 = packet.P27;
            P28 = packet.P28;
            P29 = packet.P29;
            P30 = packet.P30;
            P31 = packet.P31;
            P32 = packet.P32;

        }
    }
}