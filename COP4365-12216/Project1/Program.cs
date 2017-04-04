using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    class Triangles
    {
        static void Main(string[] args)
        {
            Triangle('a');
            Triangle('b');
            Triangle('c');
            Triangle('d');
        }
        static void Triangle(char TriangleID)
        {
            int asteriskCount = 0; // default value for counter indicating number of asterisks to write per line
            int whitespaceCount = 0; // default value for counter indicating number of whitespace characters to write per line
            int triangleWidth = 10; // default width of all triangles based on project requirements

            switch (TriangleID) // set asterisk-width of first line based on TriangleID
            {
                case 'a':
                    asteriskCount = 1;
                    whitespaceCount = 0;
                    break;
                case 'b':
                    asteriskCount = triangleWidth;
                    whitespaceCount = 0;
                    break;
                case 'c':
                    asteriskCount = triangleWidth;
                    whitespaceCount = 0;
                    break;
                case 'd':
                    asteriskCount = 1;
                    whitespaceCount = triangleWidth - 1;
                    break;
                default: // this is an error since param is not a known TriangleID
                    break; // specific error message is written later in this method
            }
            Console.WriteLine("(" + TriangleID.ToString() + ")");

            switch (TriangleID)
            {
                case 'a':
                    // loop runs until the nested conditional statement is out of bounds
                    for (int i = 0; i < asteriskCount; i++)
                    {
                        // bounds checking for a 10-asterisk wide triangle
                        if (asteriskCount <= triangleWidth && asteriskCount > 0)
                        {
                            // nested loop runs once for each line of triangle
                            for (int b = 0; b < asteriskCount; b++)
                            {
                                Console.Write('*');
                            }
                            // once line is complete, add newline and increment the lines counter, 'a'
                            Console.WriteLine();
                            asteriskCount++;
                        }
                    }
                    break;
                case 'b':
                    // loop runs until the nested conditional statement is out of bounds
                    for (int i = asteriskCount; i > 0; i--)
                    {
                        // bounds checking for a 10-asterisk wide triangle
                        if (asteriskCount <= triangleWidth && asteriskCount > 0)
                        {
                            // nested loop runs once for each line of triangle
                            for (int b = 0; b < asteriskCount; b++)
                            {
                                Console.Write('*');
                            }
                            // once line is complete, add newline and decrement asteriskCount
                            Console.WriteLine();
                            asteriskCount--;
                        }
                    }
                    break;
                case 'c':
                    // loop runs until the nested conditional statement is out of bounds
                    for (int i = asteriskCount; i > 0; i--)
                    {
                        // bounds checking for a 10-asterisk wide triangle (note that whitespaceCount CAN be 0 but asteriskCount cannot)
                        if (asteriskCount <= triangleWidth && asteriskCount > 0 && whitespaceCount >= 0 && whitespaceCount < triangleWidth)
                        {
                            // nested loop runs once for each line of triangle
                            for (int b = 0; b < whitespaceCount; b++)
                            {
                                Console.Write(' ');
                            }
                            for (int b = 0; b < asteriskCount; b++)
                            {
                                Console.Write('*');
                            }
                            // once line is complete, add newline and increment the lines counter, 'a'
                            Console.WriteLine();
                            asteriskCount--;
                            whitespaceCount++;
                        }
                    }
                    break;
                case 'd':
                    // loop runs until the nested conditional statement is out of bounds
                    for (int i = whitespaceCount; i > 0; i--)
                    {
                        // bounds checking for a 10-asterisk wide triangle (note that whitespaceCount CAN be 0 but asteriskCount cannot)
                        if (asteriskCount <= triangleWidth && asteriskCount > 0 && whitespaceCount >= 0 && whitespaceCount < triangleWidth)
                        {
                            // nested loop runs once for each line of triangle
                            for (int b = 0; b < whitespaceCount; b++)
                            {
                                Console.Write(' ');
                            }
                            for (int b = 0; b < asteriskCount; b++)
                            {
                                Console.Write('*');
                            }
                            // once line is complete, add newline and increment the lines counter, 'a'
                            Console.WriteLine();
                            asteriskCount++;
                            whitespaceCount--;
                        }
                    }
                    break;
                default:
                    Console.WriteLine("That is not a known TriangleID");
                    break;
            }
            Console.WriteLine(); // add a newline after each triangle
        }
    }
}
