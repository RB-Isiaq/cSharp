using System.Collections.Generic;

Dictionary<int, string> myDictionary = new Dictionary<int, string>();

myDictionary.Add(1, "Ridwan");
myDictionary.Add(2, "Bukola");
myDictionary.Add(3, "Isiaq");
myDictionary.Add(4, "IRB");

foreach (KeyValuePair<int, string> item in myDictionary)
{
    Console.WriteLine($"Key {item.Key}: value {item.Value}");
}