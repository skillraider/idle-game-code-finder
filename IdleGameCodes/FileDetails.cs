namespace IdleGameCodes;

public class FileDetails
{
    public string Path { get; set; } = string.Empty;

    public FileInfo? FileInfo { get; set; }

    public List<string> Lines { get; set; } = new();

    public FileDetails(string path)
    {
        Path = path;
    }

    public void GetFileInfo()
    {
        FileInfo = new(Path);
    }

    public void ReadFile()
    {
        FileStream fs = new(Path, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
        StreamReader sr = new(fs);
        string? line;
        while ((line = sr.ReadLine()) is not null)
        {
            Lines.Add(line);
        }
    }
}