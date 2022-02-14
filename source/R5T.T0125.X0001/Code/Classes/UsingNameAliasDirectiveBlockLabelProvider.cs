using System;
using System.Threading.Tasks;

using R5T.T0125.T001;


namespace R5T.T0125.X0001
{
    /// <summary>
    /// Rivet specific.
    /// <inheritdoc cref="IUsingNameAliasDirectiveBlockLabelProvider" path="/summary"/>
    /// </summary>
    public class UsingNameAliasDirectiveBlockLabelProvider : IUsingNameAliasDirectiveBlockLabelProvider
    {
        public Task<string> GetBlockLabel(
            string destinationName,
            string sourceNameExpression,
            string localNamespaceName)
        {
            string Internal()
            {
                var isDocumentation = Instances.TypeNameOperator.Equals(
                    destinationName,
                    Instances.TypeName.Documentation());
                if(isDocumentation)
                {
                    return Instances.UsingNameAliasDirectiveBlockLabel.Documentation();
                }

                var isGlossary = Instances.TypeNameOperator.Equals(
                    destinationName,
                    Instances.TypeName.Glossary());
                if(isGlossary)
                {
                    return Instances.UsingNameAliasDirectiveBlockLabel.Documentation();
                }

                var isInstances = Instances.TypeNameOperator.Equals(
                    destinationName,
                    Instances.TypeName.Instances());
                if(isInstances)
                {
                    return Instances.UsingNameAliasDirectiveBlockLabel.Instances();
                }

                var isInterface = Instances.TypeNameOperator.IsInterface(destinationName);
                if(isInterface)
                {
                    return Instances.UsingNameAliasDirectiveBlockLabel.Interfaces();
                }

                // Otherwise, use the default, even if it's a class (as there is no way to tell a class from a namespace).
                var output = Instances.UsingNameAliasDirectiveBlockLabel.Default();
                return output;
            }

            var output = Internal();

            return Task.FromResult(output);
        }
    }
}
