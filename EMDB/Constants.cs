#region Using Directives

using System;

#endregion

namespace EMDB
{
    public class Constants
    {
        public enum InputType
        {
            Delta1,
            Delta10,
            Delta11,
            Delta12,
            Delta13,
            Delta14,
            Delta15,
            Delta16,
            Delta17,
            Delta18,
            Delta19,
            Delta2,
            Delta20,
            Delta21,
            Delta22,
            Delta23,
            Delta24,
            Delta25,
            Delta26,
            Delta27,
            Delta28,
            Delta29,
            Delta3,
            Delta30,
            Delta31,
            Delta32,
            Delta4,
            Delta5,
            Delta6,
            Delta7,
            Delta8,
            Delta9,
            E1,
            E10,
            E11,
            E12,
            E13,
            E14,
            E15,
            E16,
            E17,
            E18,
            E19,
            E2,
            E20,
            E21,
            E22,
            E23,
            E24,
            E25,
            E26,
            E27,
            E28,
            E29,
            E3,
            E30,
            E31,
            E32,
            E4,
            E5,
            E6,
            E7,
            E8,
            E9,
            P1,
            P10,
            P11,
            P12,
            P13,
            P14,
            P15,
            P16,
            P17,
            P18,
            P19,
            P2,
            P20,
            P21,
            P22,
            P23,
            P24,
            P25,
            P26,
            P27,
            P28,
            P29,
            P3,
            P30,
            P31,
            P32,
            P4,
            P5,
            P6,
            P7,
            P8,
            P9,
            SC,
            W9,
            V,
            Wh1,
            Wh10,
            Wh11,
            Wh12,
            Wh13,
            Wh14,
            Wh15,
            Wh16,
            Wh17,
            Wh18,
            Wh19,
            Wh2,
            Wh20,
            Wh21,
            Wh22,
            Wh23,
            Wh24,
            Wh25,
            Wh26,
            Wh27,
            Wh28,
            Wh29,
            Wh3,
            Wh30,
            Wh31,
            Wh32,
            Wh4,
            Wh5,
            Wh6,
            Wh7,
            Wh8,
            Wh9,
            X,
            DeltaSeconds,
            W1,
            W10,
            W11,
            W12,
            W13,
            W14,
            W15,
            W16,
            W17,
            W18,
            W19,
            W2,
            W20,
            W21,
            W22,
            W23,
            W24,
            W25,
            W26,
            W27,
            W28,
            W29,
            W3,
            W30,
            W31,
            W32,
            W4,
            W5,
            W6,
            W7,
            W8
        }

        public static string[] ValidInputs
        {
            get
            {
                var validInputs = Enum.GetNames(typeof(Constants.InputType));
                return validInputs;
            }
        }
    }

    public static class Extensions{

        
        //public static Constants.InputType ToInputType(this string name)
        //{
        //    Constants.InputType def;
        //    Enum.TryParse(name, true, out def);
        //    return def;
        //}
    }
}