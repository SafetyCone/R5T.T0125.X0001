using System;

using R5T.T0125.T002;
using R5T.T0125.X0001;


namespace System
{
    public static class IUsingNameAliasDirectiveBlockLabelExtensions
    {
        public static string Documentation(this IUsingNameAliasDirectiveBlockLabel _)
        {
            return UsingNameAliasDirectiveBlockLabels.Documentation;
        }

        public static string Instances(this IUsingNameAliasDirectiveBlockLabel _)
        {
            return UsingNameAliasDirectiveBlockLabels.Instances;
        }
    }
}
