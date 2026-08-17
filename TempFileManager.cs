using System;
using System.IO;

namespace CSharpLearning;


public class TempFileManager : IDisposable
{
    private string filepath;
    public TempFileManager (string content)
    {
        filepath = Path.GetTempFileName();
        File.WriteAllText (filepath, content);
        Console.WriteLine ("All text copied");
    }
    public void Dispose()
    {
        if(File.Exists(filepath))
        {
            File.Delete(filepath);
            Console.WriteLine("Temporary file deleted");
        }

        GC.SuppressFinalize(this);
    }
    ~TempFileManager()
    {
        Console.WriteLine("Finalizer executed");
        if (File.Exists(filepath))
        {
            File.Delete(filepath);
            Console.WriteLine("Temporary file deleted");
        }
    }
    public string GetFilePath()
    {
        return filepath;
    }
}