using GroupDocs.Merger;
using GroupDocs.Merger.Domain.Options;

public abstract class FileSecurity
{
    public void ProtectFile(string path)
    {
        this.FileExist(path);
        AddPasswordOptions addOptions = new AddPasswordOptions("mySECRETpassWORD");

        using (Merger merger = new Merger(path))
        {
            merger.AddPassword(addOptions);
            merger.Save(path);
        }
    }

    public void FileExist(string path)
    {
        FileInfo file = new FileInfo(path);

        if(!file.Exists) 
            throw new ArgumentException("File not found");
    }
}