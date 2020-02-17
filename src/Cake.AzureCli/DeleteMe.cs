//using Newtonsoft.Json;
//using System.Collections.Generic;
//using System.IO;

//namespace Cake.AzureCli
//{
//    public class DeleteMe
//    {
//        public void DoIt()
//        {
//            List<int> ints = null;
//            foreach (var i in ints)
//            {

//            }
//            var templateFile = new FileInfo(Host.TemplateFile);
//            var currentFolder = templateFile.Directory.FullName;
//            var azCliHelpOutputFileLocation = Path.Combine(currentFolder, "AzCliHelpOutput.json");
//            var azCliHelpOutputJson = File.ReadAllText(azCliHelpOutputFileLocation);
//            var cliProgram = JsonConvert.DeserializeObject<CliProgram>(azCliHelpOutputJson);
//            return cliProgram.RootCommand.Name;
//        }
//    }
//}
