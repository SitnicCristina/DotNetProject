namespace DotNetExamples;

public class Lesson12
{
    // public static async Task Main(string[] args)
    // {
    //     #region Ex1 Citire asincronă de fișiere
    //     string rootPath = Directory.GetCurrentDirectory();
    //     string directorySourceFolder = Directory.GetParent(rootPath).Parent.Parent.FullName + "/MyDirecoty/";
    //     
    //     // Get all .txt files
    //     string[] files = Directory.GetFiles(directorySourceFolder, "*.txt");
    //
    //     var results = await Task.WhenAll(
    //         files.Select(async file =>
    //         {
    //             int lines = await ReadLinesAsync(file);
    //             return (File: Path.GetFileName(file), Lines: lines);
    //         })
    //     );
    //     
    //     // Print the results
    //     foreach (var result in results)
    //     {
    //         Console.WriteLine($"{result.File} has {result.Lines} lines.");
    //     }
    //     
    //     static async Task<int> ReadLinesAsync(string filePath)
    //     {
    //         int counter_lines = 0;
    //         using (StreamReader reader = new StreamReader(filePath))
    //         {
    //             while (await reader.ReadLineAsync() != null)
    //             {
    //                 counter_lines++;
    //             }
    //         }
    //         return counter_lines;
    //     }
    //     
    //     #endregion
    // }
}