namespace DotNetExamples;

public class Lesson10
{
    // public static void Main(string[] args)
    // {
    //     string rootPath = Directory.GetCurrentDirectory();
    //     string parentPath = Directory.GetParent(rootPath).Parent.Parent.FullName;
    //     
    //     #region Ex1 Compararea Conținutului a Două Fișiere
    //     // create file1.txt, write some text there, read the text from file
    //     string filePath1 = parentPath + "/file1.txt";
    //     using (FileStream fs = File.Create(filePath1)) { }
    //     File.WriteAllText(filePath1, "Here the text for 1 file");
    //     string content_file1 = File.ReadAllText(filePath1);
    //     Console.WriteLine(content_file1);
    //     
    //     // create file2.txt, write some text there, read the text from file
    //     string filePath2 = parentPath + "/file2.txt";
    //     using (FileStream fs = File.Create(filePath2)) { }
    //     File.WriteAllText(filePath1, "Here the text for 2 file");
    //     string content_file2 = File.ReadAllText(filePath1);
    //     Console.WriteLine(content_file2);
    //     
    //     // compare the content of 2 files
    //     bool filesEqual = String.Equals(content_file1, content_file2);
    //     Console.WriteLine($"Fisierele sunt identice: {filesEqual}");
    //     #endregion
    //
    //     #region Ex2 Mutarea Fișierelor într-un Director Nou
    //     // create the folder 'SourceFolder' and 'BackupFolder'
    //     string directorySourceFolder = parentPath + "/SourceFolder/";
    //     Directory.CreateDirectory(directorySourceFolder);
    //     string directoryBackupFolder = parentPath + "/BackupFolder/";
    //     Directory.CreateDirectory(directoryBackupFolder);
    //     
    //     // Create files in 'SourceFolder'
    //     string[] files = { "file1.txt", "file2.txt", "file3.txt", "file4.txt" };
    //     foreach (var file in files)
    //     {
    //         FileInfo fileInfo = new FileInfo(directorySourceFolder + file);
    //         fileInfo.Create().Close();
    //     }
    //     
    //     // muta toate fisierele din SourceFolder in BackupFolder
    //     foreach (string file in files)
    //     {
    //         FileInfo fileInfo = new FileInfo(directorySourceFolder + file);
    //         fileInfo.MoveTo(directoryBackupFolder+file);
    //     }
    //     #endregion
    // }
}