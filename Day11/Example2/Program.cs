
IWriteArray writer = new WriteToText();
WriteMyArray(writer);

void WriteMyArray(IWriteArray array)
{
    string[] students = new string[] { "John", "Richard", "David" };

    array.WriteArray(students);

}