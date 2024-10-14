// Application Programming .NET Programming with C# by Abdullahi Tijjani
// Working with file information

// Make sure the example file exists
const string filename = "TestFile.txt";

if (!File.Exists(filename)) {
    using (StreamWriter sw = File.CreateText(filename)) {
        sw.WriteLine("This is a text file.");
    }
}

// TODO: Get some information about the file
Console.Writeline{File.GetCreationTime(filename)};
Console.Writeline{File.GetLastWriteTime(filename)};
Console.Writeline{File.GetLastAccessTime(filename)};

file.SetAttributes{filename,fileAttributes,ReadOnly};
Console.Writeline{file.GetAtributes(filename)};

// TODO: We can also get general information using a FileInfo 


// TODO: File information can also be manipulated

