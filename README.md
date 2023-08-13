# Python Documentation

# Python File Reader

This Python script reads a file and prints its content in hexadecimal and ASCII format. It is designed to be run from the command line and requires the name of the file to be read as a command line argument.

## Script Explanation

The script starts by importing the `sys` module, which provides access to some variables used or maintained by the Python interpreter and to functions that interact strongly with the interpreter. It is used in this script to read command line arguments and to handle the script termination.

The `main()` function is the entry point of the script. It first tries to read the file name from the command line arguments. If no argument is provided, it prints an error message and exits with a status code of 1.

Next, it tries to open the file in binary mode. If the file does not exist, it prints an error message and exits with a status code of 1.

The script then enters a loop where it reads the file in chunks of 16 bytes. For each chunk, it prints the bytes in hexadecimal format, followed by the ASCII representation of the bytes. Non-printable characters are replaced with a dot.

The loop continues until there are no more bytes to read from the file.

## Usage

To use this script, run it from the command line and provide the name of the file to be read as an argument. For example:

```
python file_reader.py myfile.txt
```

This will print the content of `myfile.txt` in hexadecimal and ASCII format.

## Dependencies

This script requires Python 3.6 or later. It does not require any external libraries.

---

# C# Documentation

# CSharp File Reader

This CSharp script is designed to read a file and display its contents in both hexadecimal and ASCII formats. It takes a file path as an argument, checks if the file exists, and then reads and displays the file content.

## Libraries Used

- `System`: This is a fundamental library in CSharp that provides base functionalities such as Console for input/output operations.

- `System.IO`: This library is used for input/output operations, in this case, reading from a file. It provides the FileStream and File classes used in the script.

## Script Explanation

The script starts by checking if a file path has been provided as an argument. If not, it prompts the user to provide one and then terminates.

Next, it checks if the file at the provided path exists. If the file does not exist, it informs the user and then terminates.

If the file exists, it opens the file in read mode using a FileStream. It then reads the file in chunks of 16 bytes at a time.

For each chunk, it first displays the offset (the position in the file where the chunk starts) in hexadecimal format. Then it displays each byte in the chunk in hexadecimal format. If the chunk is less than 8 bytes, it adds an extra space for alignment.

After displaying the hexadecimal representation, it displays the ASCII representation of each byte. If the byte represents a non-printable ASCII character (less than 32 or greater than 126), it displays a dot ('.') instead.

This process continues until the entire file has been read and displayed.

## Usage

To use this script, compile it and run it from the command line, providing the path to the file you want to read as an argument. For example:

```
csc Program.cs
Program.exe C:\path\to\your\file.txt
```

This will display the contents of `file.txt` in the console.

---

# Java Documentation

# HexViewer

This Java script, HexViewer, is a simple utility that reads a file and prints its content in hexadecimal format. It is useful for viewing binary files that contain non-printable characters.

## How it works

The script takes a file name as a command-line argument. It opens the file, reads it byte by byte, and prints each byte in hexadecimal format. After every 16 bytes, it prints a newline to format the output in a more readable way.

If there is an error reading the file, such as the file not existing or not having the necessary permissions, the script prints an error message and exits.

## Imported Libraries

The script uses two libraries from the Java standard library:

- `java.io.FileInputStream`: This class is a part of Java's I/O (Input/Output) package. It is used for reading data from files. In this script, it is used to open the file and read it byte by byte.

- `java.io.IOException`: This class is used to handle exceptions that can occur when trying to read or write a file. In this script, it is used to catch and handle any errors that occur while trying to read the file.

## Usage

To use the script, compile it with a Java compiler, then run it with the name of the file you want to view as an argument. For example:

```
javac HexViewer.java
java HexViewer myfile.bin
```

This will print the contents of `myfile.bin` in hexadecimal format.

---
