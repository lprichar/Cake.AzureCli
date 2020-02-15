namespace Cake.AzCliParser
{
    public abstract class ParserBase
    {
        public bool ParseTag(ref string name, string tag)
        {
            bool containsTag = name.Contains(tag);
            if (containsTag)
            {
                name = name.Replace(tag, "").Trim();
            }

            return containsTag;
        }
    }
}