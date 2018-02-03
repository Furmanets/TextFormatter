using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextFormatterLib
{
    public class TextFormatter
    {

        public string Justify(string text, int width)
        {
            string[] sl = text.Split(' ');
            StringBuilder resultText = new StringBuilder();
            StringBuilder currentLine = new StringBuilder();
            for (int i = 0; i < sl.Length; i++)
            {
                if (currentLine.Length != 0)
                {
                    currentLine.Append(' ');
                }
                currentLine.Append(sl[i]);

                if (sl[i + 1].Length + currentLine.Length > width)
                {
                    currentLine.Append(AddingSpaces(currentLine, width));
                    currentLine.Append('\n');
                    resultText.Append(currentLine);
                    currentLine.Clear();
                }
            }

            return resultText.ToString();
        }

        public string AddingSpaces(StringBuilder currentLine, int width)
        {
            int index = 0;
            while (currentLine.Length != width)
            {
                if (currentLine[index] == ' ')
                {
                    currentLine.Insert(index, ' ');
                    index++;
                }
                index++;
                if (currentLine.Length == index)
                {
                    index = 0;
                }
            }

            return currentLine.ToString();
        }
    }
}
