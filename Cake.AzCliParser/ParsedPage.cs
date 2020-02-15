using System;
using System.Collections.Generic;

namespace Cake.AzCliParser
{
    public class ParsedPage
    {
        public List<PageHeader> Headers { get; set; }
    }

    public class PageHeader
    {
        public PageHeader(string line)
        {
            Title = line;
            NameValues = new List<NameValue>();
            TextBlocks = new List<TextBlock>();
        }

        public string Title { get; set; }

        public List<NameValue> NameValues { get; set; }
        public List<TextBlock> TextBlocks { get; set; }

        public void AddTextBlock(TextBlock textBlock)
        {
            if (!string.IsNullOrWhiteSpace(textBlock.Text))
            {
                TextBlocks.Add(textBlock);
            }
        }
    }

    public class TextBlock
    {
        public TextBlock(string text)
        {
            Text = text.Trim();
            IndentationLevel = GetIndentationLevel(text);
        }

        private int GetIndentationLevel(string text)
        {
            if (text.StartsWith("        "))
            {
                return 2;
            }

            if (text.StartsWith("    "))
            {
                return 1;
            }

            if (text.StartsWith(" "))
            {
                throw new ArgumentException("Unsupported indentation level for line " + text);
            }

            return 0;
        }

        public int IndentationLevel { get; set; }
        public string Text { get; set; }
        public TextBlock NestedText { get; set; }
    }

    public class NameValue
    {
        public NameValue(string name, string value)
        {
            Name = name.Trim();
            Value = value;
        }

        public string Name { get; set; }
        public string Value { get; set; }
    }
}