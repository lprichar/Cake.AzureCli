using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text.RegularExpressions;

namespace Cake.AzCliParser
{
    public class PageParser
    {
        public ParsedPage ParseString(string helpPage)
        {
            Debug.Assert(!string.IsNullOrWhiteSpace(helpPage));

            var lines = helpPage.Split("\n")
                .Select(l => l.TrimEnd('\r'));

            var pageHeaders = new List<PageHeader>();
            PageHeader currentPageHeader = null;
            NameValue currentNameValue = null;
            TextBlock currentTextBlock = null;
            foreach (var line in lines)
            {
                bool isHeader = IsHeader(line);
                if (isHeader)
                {
                    currentPageHeader = new PageHeader(line);
                    pageHeaders.Add(currentPageHeader);
                    currentNameValue = null;
                }
                else
                {
                    if (currentPageHeader != null)
                    {
                        var isNameValuePair = IsNameValuePair(line);
                        if (isNameValuePair)
                        {
                            var nameValue = line.Split(" : ");
                            currentNameValue = new NameValue(nameValue[0], nameValue[1]);
                            currentPageHeader.NameValues.Add(currentNameValue);
                        }
                        else
                        {
                            if (currentNameValue != null)
                            {
                                currentNameValue.Value += " " + line.Trim();
                            }
                            else
                            {
                                var newestTextBlock = new TextBlock(line);
                                if (currentTextBlock != null)
                                {
                                    var newestIndentationLevel = newestTextBlock.IndentationLevel;
                                    var lastIndentationLevel = currentTextBlock.IndentationLevel;
                                    if (lastIndentationLevel == newestIndentationLevel)
                                    {
                                        currentTextBlock.Text += " " + newestTextBlock.Text;
                                    }

                                    if (newestIndentationLevel > lastIndentationLevel)
                                    {
                                        currentTextBlock.NestedText = new TextBlock(line);
                                        currentTextBlock = currentTextBlock.NestedText;
                                    }

                                    if (newestIndentationLevel < lastIndentationLevel)
                                    {
                                        if (!string.IsNullOrWhiteSpace(line))
                                        {
                                            currentTextBlock = newestTextBlock;
                                            currentPageHeader.AddTextBlock(currentTextBlock);
                                        }
                                    }
                                }
                                else
                                {
                                    if (!string.IsNullOrWhiteSpace(line))
                                    {
                                        currentTextBlock = newestTextBlock;
                                        currentPageHeader.AddTextBlock(currentTextBlock);
                                    }
                                }
                            }
                        }
                    }
                }
            }

            return new ParsedPage
            {
                Headers = pageHeaders
            };
        }

        public static bool IsNameValuePair(string line)
        {
            var numberOfPrefixingSpaces = new Regex("^( )+[^ ]").Match(line).Groups[1].Captures.Count;
            var lineIsIndentedPrettyFar = numberOfPrefixingSpaces > 12;
            return line.Contains(" : ") && !lineIsIndentedPrettyFar;
        }

        private bool IsHeader(string line)
        {
            if (string.IsNullOrWhiteSpace(line)) return false;
            return !line.StartsWith(" ");
        }
    }
}