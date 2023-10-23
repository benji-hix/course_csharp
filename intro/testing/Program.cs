

List<string> firstName = new List<string>();
firstName.Add("Julie");
firstName.Add("Harold");
firstName.Add("James");
firstName.Add("Monica");
List<int> age = new List<int>();
age.Add(6);
age.Add(12);
age.Add(7);
age.Add(10);

static Dictionary<string,int> GenerateDictionary(List<string> Names, List<int> Numbers)
{
    Dictionary<string, int> output = new Dictionary<string, int>();

    for (int i = 0; i < Names.Count; i++) {
        output.Add(Names[i], Numbers[i]);
    }

    return output;
}

Dictionary<string, int> result8 = GenerateDictionary(firstName, age);

foreach (KeyValuePair<string, int> entry in result8) {
    Console.WriteLine($"{entry.Key} - {entry.Value}");
}