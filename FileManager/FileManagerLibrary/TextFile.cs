using System;
using System.IO;

namespace FileManagerLibrary
{
    public class TextFile : Files
    {
        public readonly ulong NumberOfLines;

        public readonly ulong NumberOfSymbolsWithWhiteSpace;

        public readonly ulong NumberOfSymbolsWithoutWhiteSpace;

        public readonly ulong NumberOfWords;

        public readonly int NumberOfParagraphs;

        private readonly char[] Separators = { ' ', '-', '+', '=', '.', ',', '!', '?', ':', ';', '\\', '\t', '\n', '\r' };

        public TextFile(string path)
        {
            if(File.Exists(path))
            {
                NumberOfLines = (ulong)File.ReadAllLines(path).LongLength;

                string temp = File.ReadAllText(path);

                NumberOfSymbolsWithWhiteSpace = (ulong)temp.Length;

                NumberOfSymbolsWithoutWhiteSpace = (ulong)temp.Replace(" ", string.Empty).Length;

                NumberOfWords = (ulong)temp.Split(Separators, StringSplitOptions.RemoveEmptyEntries).LongLength;

                NumberOfParagraphs = temp.Split("\n\t").Length;
            }
            else
            {
                Console.WriteLine("File doesn't exist.");
            }
            
        }
    }
}
