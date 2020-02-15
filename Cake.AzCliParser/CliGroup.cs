﻿using System.Collections.Generic;

namespace Cake.AzCliParser
{
    public class CliProgram
    {
        public CliGroup RootCommand { get; set; }
        public List<CliArgument> GlobalArguments { get; set; }
    }

    public class CliGroup
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public List<CliGroup> Subgroups { get; set; }
        public List<CliCommand> Commands { get; set; }
    }

    public class CliCommand
    {
        public string Name { get; set; }
        public string ShortDescription { get; set; }
        public List<CliArgument> Arguments { get; set; }
        public bool IsPreview { get; set; }
        public List<CliExample> Examples { get; set; }

        public void Merge(CliCommand command)
        {
            Arguments = command.Arguments;
            Examples = command.Examples;
        }
    }

    public class CliExample
    {
        public string Description { get; set; }
        public string Example { get; set; }
    }

    public class CliArgument
    {
        public string Name { get; set; }
        public string ShortName { get; set; }
        public string Description { get; set; }
        public bool Required { get; set; }
    }
}
