class Program
{
    static void Main(string[] args)
    {       
        const string path = @"path";
        const string filenamePdf = "arquivo.pdf";
        const string filenameDoc = @"arquivo.docx" ;

        FilePdf filePdf = new FilePdf();

        filePdf.WriteFile(path, filenamePdf);
        filePdf.OpenFile(path, filenamePdf);
        filePdf.ProtectFile(String.Concat(path, filenamePdf));

        FileDoc fileDoc = new FileDoc();
        fileDoc.WriteFile(path, filenameDoc);
        fileDoc.OpenFile(path, filenameDoc);
        fileDoc.ProtectFile(String.Concat(path, filenameDoc));
    }
}