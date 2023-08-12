string filePath = args[0];

if (!File.Exists(filePath))
{
    Console.WriteLine("File does not exist.");
    return;
}