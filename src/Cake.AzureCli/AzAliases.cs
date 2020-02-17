
using Cake.Core;
using Cake.Core.Annotations;
using Cake.Core.IO;

namespace Cake.AzureCli
{
    [CakeAliasCategory("Az")]
    public static class AzAliases
    {
        private static void AppendArguments(ref string baseCommand, ProcessArgumentBuilder arguments)
        {
            if (arguments != null)
            {
                baseCommand += " " + arguments.Render().TrimEnd();
            }
        }

        private static void AppendIfNonNull(ref string baseCommand, string paramName, string setting)
        {
            if (!string.IsNullOrEmpty(setting))
            {
                baseCommand += $" {paramName}={setting}";
            }
        }
        private static void az() { }    }
}

