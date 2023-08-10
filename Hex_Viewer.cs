```CSharp
using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        if (args.Length == 0)
        {
            Console.WriteLine("Please provide a file path.");
            return;
        }

        string filePath = args[0];

        if (!File.Exists(filePath))
        {
            Console.WriteLine("File does not exist.");
            return;
        }

        using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
        {
            byte[] buffer = new byte[16];
            long offset = 0;
            int bytesRead;

            while ((bytesRead = fs.Read(buffer, 0, buffer.Length)) > 0)
            {
                Console.Write("{0:X8}  ", offset);

                for (int i = 0; i < bytesRead; i++)
                {
                    Console.Write("{0:X2} ", buffer[i]);
                    if (i == 7)
                        Console.Write(" ");
                }

                if (bytesRead < 8)
                    Console.Write(" ");

                for (int i = bytesRead; i < 16; i++)
                    Console.Write("   ");

                Console.Write(" ");

                for (int i = 0; i < bytesRead; i++)
                {
                    if (buffer[i] < 32 || buffer[i] > 126)
                        Console.Write(".");
                    else
                        Console.Write((char)buffer[i]);
                }

                Console.WriteLine();
                offset += bytesRead;
            }
        }
    }
}
```