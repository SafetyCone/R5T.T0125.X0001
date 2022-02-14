using System;

using R5T.B0001;
using R5T.B0002;
using R5T.T0125.T002;


namespace R5T.T0125.X0001
{
    public static class Instances
    {
        public static INamespaceNameOperator NamespaceNameOperator { get; } = B0002.NamespaceNameOperator.Instance;
        public static INamespaceNameTokenOperator NamespaceNameTokenOperator { get; } = B0002.NamespaceNameTokenOperator.Instance;
        public static ITypeName TypeName { get; } = B0001.TypeName.Instance;
        public static ITypeNameOperator TypeNameOperator { get; } = B0001.TypeNameOperator.Instance;
        public static IUsingDirectiveBlockLabel UsingDirectiveBlockLabel { get; } = T002.UsingDirectiveBlockLabel.Instance;
        public static IUsingNameAliasDirectiveBlockLabel UsingNameAliasDirectiveBlockLabel { get; } = T002.UsingNameAliasDirectiveBlockLabel.Instance;
    }
}
