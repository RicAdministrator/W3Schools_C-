using System;
using System.IO;  // include the System.IO namespace

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            string writeText = "Hello World!";  // Create a text string

            // Create a file and write the contents of writeText to it
            // If the file already exists, it will be overwritten.
            // Filepath = ZC_Write_To_A_File_And_Read_It\bin\Debug\net9.0\filename.txt
            File.WriteAllText("filename.txt", writeText);

            string readText = File.ReadAllText("filename.txt"); // Read the contents of the file
            Console.WriteLine(readText); // Output the content
        }
    }
}

// Output:
// Hello World!