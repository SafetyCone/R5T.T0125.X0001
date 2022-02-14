using System;

using R5T.T0125.T002;

using UsingDirectiveBlockSortOrder = R5T.T0125.T001.UsingDirectiveBlockSortOrder;

using Instances = R5T.T0125.X0001.Instances;


namespace System
{
    public static class IUsingDirectiveBlockSortOrderExtensions
    {
        public static UsingDirectiveBlockSortOrder RivetNamespaces(this IUsingDirectiveBlockSortOrder _)
        {
            var output = UsingDirectiveBlockSortOrder.From(
                Instances.UsingDirectiveBlockLabel.System(),
                Instances.UsingDirectiveBlockLabel.Microsoft(),
                Instances.UsingDirectiveBlockLabel.R5T_Named(),
                Instances.UsingDirectiveBlockLabel.R5T_Numbered(),
                Instances.UsingDirectiveBlockLabel.Default(),
                Instances.UsingDirectiveBlockLabel.LocalNamespace(),
                Instances.UsingDirectiveBlockLabel.Special());

            return output;
        }

        public static UsingDirectiveBlockSortOrder RivetNameAliases(this IUsingDirectiveBlockSortOrder _)
        {
            var output = UsingDirectiveBlockSortOrder.From(
                Instances.UsingNameAliasDirectiveBlockLabel.Interfaces(),
                Instances.UsingNameAliasDirectiveBlockLabel.Classes(),
                Instances.UsingNameAliasDirectiveBlockLabel.Default(),
                Instances.UsingNameAliasDirectiveBlockLabel.Documentation(),
                Instances.UsingNameAliasDirectiveBlockLabel.Instances());

            return output;
        }
    }
}
