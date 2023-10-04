public class WriteToText : IWriteArray
{
    public void WriteArray(string[] students)
    {
        Console.WriteLine("I write to text file");
        foreach (string student in students)
        {
            Console.WriteLine(student);
        }
    }
}