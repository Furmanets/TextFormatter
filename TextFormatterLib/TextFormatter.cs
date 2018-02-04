using System;
using System.Text;

namespace TextFormatterLib
{
    public class TextFormatter
    {

        public string Justify(string text, int width)
        {
            var words = text.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var resultText = new StringBuilder();
            var currentLine = new StringBuilder();

            for (var i = 0; i < words.Length; i++)
            {
                if (width < words[i].Length)
                {
                    throw new Exception("Error! The width can not be shorter than the word.");
                }

                if (currentLine.Length != 0)
                {
                    currentLine.Append(' ');
                }
                currentLine.Append(words[i]);

                if (i == words.Length - 1 || words[i + 1].Length + currentLine.Length + 1 > width)
                {
                    if (i != words.Length - 1)
                    {
                        resultText.Append(AddingSpaces(currentLine, width));
                        resultText.Append('\n');
                    }
                    else
                    {
                        resultText.Append(currentLine);
                    }

                    currentLine.Clear();
                }


            }

            return resultText.ToString();
        }

        public string AddingSpaces(StringBuilder currentLine, int width)
        {
            int index = 0;
            var words = currentLine.ToString().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            if (words.Length > 1)
            {

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
            }

            return currentLine.ToString();
        }
    }
}
