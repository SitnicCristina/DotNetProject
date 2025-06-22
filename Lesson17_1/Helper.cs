namespace DotNetExamples.Lesson17;

public static class Helper
{
    public static string GenerareCodUnic(string prefix)
    {
        Random rand = new Random();
        int randomNumber = rand.Next();
        string codUnic = prefix + randomNumber;
        return codUnic;
    }

}