using System.IO;
using System.Reflection;

namespace Cake.ProjectGenerator.Test.Resources
{
    public class ResourceManager
    {
        public static string GetResource(string resourceName)
        {
            resourceName = "Cake.ProjectGenerator.Test.Resources." + resourceName;
            var assembly = Assembly.GetExecutingAssembly();

            using Stream stream = assembly.GetManifestResourceStream(resourceName);
            using StreamReader reader = new StreamReader(stream);
            return reader.ReadToEnd();
        }

        public static string GetAzLogin()
        {
            return GetResource("AzLogin.txt");
        }

        public static string GetAzAksInstallConnector()
        {
            return GetResource("AzAksInstallConnector.txt");
        }
    }
}
