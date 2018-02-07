using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TextFormatterLib;

namespace UnitTests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void InitializationTest()
        {
            var tf = new TextFormatter();
            var text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vestibulum sagittis dolor mauris, at elementum ligula tempor eget. In quis rhoncus nunc, at aliquet orci. Fusce at dolor sit amet felis suscipit tristique.";

            var result = tf.Justify(text, 30);

            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void ThePresenceOfTransportSigns()
        {
            var tf = new TextFormatter();
            var text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vestibulum sagittis dolor mauris, at elementum ligula tempor eget. In quis rhoncus nunc, at aliquet orci. Fusce at dolor sit amet felis suscipit tristique.";

            var result = tf.Justify(text, 45);

            Assert.IsTrue(result.Contains("\n"));
        }

        [TestMethod]
        public void OneWordTest()
        {
            var tf = new TextFormatter();
            var text = "Lorem";

            var result = tf.Justify(text, 5);
            
            Assert.IsTrue(result == "Lorem");
            
        }

        [TestMethod]
        public void TwoWordTest()
        {
            var tf = new TextFormatter();
            var text = "Lorem sit";

            var result = tf.Justify(text, 5);

            Assert.IsTrue(result == "Lorem\nsit");

        }

        [TestMethod]
        public void TestLengthLines()
        {
            var tf = new TextFormatter();
            var text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vestibulum sagittis dolor mauris, at elementum ligula tempor eget. In quis rhoncus nunc, at aliquet orci. Fusce at dolor sit amet felis suscipit tristique.";

            var result = tf.Justify(text, 27);
            var textLines = result.Split('\n');

            for (var i = 0; i < textLines.Length - 1; i++)
            {
                Assert.IsTrue(textLines[i].Length == 27);
            }
        }

        [TestMethod]
        public void TransferSignAtTheEnd()
        {
            var tf = new TextFormatter();
            var text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vestibulum sagittis dolor mauris, at elementum ligula tempor eget. In quis rhoncus nunc, at aliquet orci. Fusce at dolor sit amet felis suscipit tristique.";

            var result = tf.Justify(text, 15);

            Assert.IsFalse(result[result.Length - 1] == '\n');

        }

        [TestMethod]
        public void TestSpacesInLastLine()
        {
            var tf = new TextFormatter();
            var text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vestibulum sagittis dolor mauris, at elementum ligula tempor eget. In quis rhoncus nunc, at aliquet orci. Fusce at dolor sit amet felis suscipit tristique.";
            var numberOfSpacesInARow = 0;

            var result = tf.Justify(text, 31);
            var textLines = result.Split('\n');

            for (var i = 0; i < textLines[textLines.Length - 1].Length; i++)
            {
                if (textLines[textLines.Length - 1][i] == ' ')
                {
                    numberOfSpacesInARow++;
                }
                else
                {
                    numberOfSpacesInARow = 0;
                }
                Assert.IsTrue(numberOfSpacesInARow<=1);
            }

        }

        [TestMethod]
        public void WidthLineExeption()
        {
            var tf = new TextFormatter();
            var text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vestibulum sagittis dolor mauris, at elementum ligula tempor eget. In quis rhoncus nunc, at aliquet orci. Fusce at dolor sit amet felis suscipit tristique.";

            try
            {
                tf.Justify(text, 1);
            }
            catch (Exception e)
            {
                Assert.IsTrue(e.Message == "Error! The width can not be shorter than the word.");
            }

        }


        [TestMethod]
        public void NumberOfSpacesBetweenWords()
        {
            var tf = new TextFormatter();
            var text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vestibulum sagittis dolor mauris, at elementum ligula tempor eget. In quis rhoncus nunc, at aliquet orci. Fusce at dolor sit amet felis suscipit tristique.";


            var result = tf.Justify(text, 30);
            var textLines = result.Split('\n');


            foreach (var line in textLines)
            {
                var countSpaces = 0;
                var lastCountSpaces = 30;
                foreach (var symbol in line)
                {
                    if (symbol == ' ')
                    {
                        countSpaces++;
                    }
                    else
                    {
                        if (countSpaces != 0)
                        {
                            Assert.IsTrue(lastCountSpaces >= countSpaces);
                            lastCountSpaces = countSpaces;
                        }
                        countSpaces = 0;
                    }
                }
            }
        }

    }
}
