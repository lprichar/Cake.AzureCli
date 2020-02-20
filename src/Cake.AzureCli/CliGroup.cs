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

        private void AppendArguments(ProcessArgumentBuilder processArgumentBuilder, ProcessArgumentBuilder arguments)
        {
            if (arguments != null)
            {
                foreach (var argument in arguments)
                {
                    processArgumentBuilder.Append(argument);
                }
            }
        }

        protected void AppendIfNonNull(ProcessArgumentBuilder processArgumentBuilder, string paramName, string setting)
        {
            if (!string.IsNullOrEmpty(setting))
            {
                // todo: any way to figure out when to AppendQuoted or AppendSecret?
                processArgumentBuilder.Append(paramName).Append(setting);
            }
        }

        protected dynamic Execute(ProcessArgumentBuilder processArgumentBuilder, AzSettingsBase settings)
        {
            AppendArguments(processArgumentBuilder, settings.Arguments);
            var commandExecutor = new CommandExecutor(Context);
            return commandExecutor.ExecuteCommand(processArgumentBuilder);
        }

    }
}
