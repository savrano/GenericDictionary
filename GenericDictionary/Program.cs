using GenericDictionary;

MyDictionary<int, string> myDict = new MyDictionary<int, string>();

myDict.Add(1, "Yağız");
Console.WriteLine("Length: " + myDict.Length);

myDict.Add(2, "Savran");
Console.WriteLine("Length: " + myDict.Length);

foreach (var values in myDict.Values)
{
    Console.WriteLine("Values: "+ values);
}
