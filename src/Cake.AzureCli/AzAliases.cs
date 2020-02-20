using Cake.Core;
using Cake.Core.Annotations;

namespace Cake.AzureCli
{
    [CakeAliasCategory("Azure")]
    public static class AzAliases
    {
        [CakeMethodAlias]
        public static AzCliGroup Az(this ICakeContext context)
        {
            return new AzCliGroup(context);
        }
    }
}
