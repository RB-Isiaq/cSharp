public class WriteToConsole : IWriteArray
{
    public void WriteArray(string[] students)
    {
        foreach (string student in students)
        {
            Console.WriteLine(student);
        }
    }
}