using Cake.Core;
using Cake.Core.IO;

namespace Cake.AzureCli
{
    public abstract class CliGroup
    {
        protected readonly ICakeContext Context;

        protected CliGroup(ICakeContext context)
        {
            Context = context;
        }

        private void AppendArguments(ref string baseCommand, ProcessArgumentBuilder arguments)
        {
            if (arguments != null)
            {
                baseCommand += " " + arguments.Render().TrimEnd();
            }
        }

        protected void AppendIfNonNull(ref string baseCommand, string paramName, string setting)
        {
            if (!string.IsNullOrEmpty(setting))
            {
                baseCommand += $" {paramName}={setting}";
            }
        }

        protected dynamic Execute(string baseCommand, AzSettingsBase settings)
        {
            AppendArguments(ref baseCommand, settings.Arguments);
            var commandExecutor = new CommandExecutor(Context);
            return commandExecutor.ExecuteCommand(baseCommand);
        }

    }
}
