#region Using Directives

using System;
using EMDB;

#endregion

namespace Visualize
{
    public static class Config
    {
        public static DateTime MinDate => DB.StartDate();
        public static DateTime StartDate => DB.EndDate().AddDays(-1);
        public static DateTime EndDate => DB.EndDate();
    }
}