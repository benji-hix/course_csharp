//* 1 Iterate and print values
static void PrintList(List<string> MyList)
{
    foreach (string entry in MyList) {
        Console.WriteLine(entry);
    }
}
List<string> TestStringList = new List<string>() {"Harry", "Steve", "Carla", "Jeanne"};
PrintList(TestStringList);

//* 2 print sum
static void SumOfNumbers(List<int> IntList)
{
    int sum = 0;
    foreach (int entry in IntList) {
        sum += entry;
    }
    Console.WriteLine(sum);
}
List<int> TestIntList = new List<int>() {2,7,12,9,3};
// You should get back 33 in this example
SumOfNumbers(TestIntList);

//* 3 Find Max
static int FindMax(List<int> IntList)
{
    int max = IntList[0];
    foreach (int entry in IntList) {
        if (entry > max) {
            max = entry;
        }
    }
    return max;
}
List<int> TestIntList2 = new List<int>() {-9,12,10,3,17,5};
// You should get back 17 in this example
Console.WriteLine(FindMax(TestIntList2));

//* 4 Square the values
static List<int> SquareValues(List<int> IntList)
{
    for (int i = 0; i < IntList.Count; i++) {
        int temp = IntList[i] * IntList[i];
        IntList[i] = temp;
    }
    return IntList;
}
List<int> TestIntList3 = new List<int>() {1,2,3,4,5};
// You should get back [1,4,9,16,25], think about how you will show that this worked
List<int> result4 =SquareValues(TestIntList3);
foreach (int entry in result4) {
    Console.WriteLine(entry);
}

//* 5 Replace negative numbers with 0
static int[] NonNegatives(int[] IntArray)
{
    for (int i = 0; i < IntArray.Length; i++) {
        if (IntArray[i] < 0) {
            IntArray[i] = 0;
        }
    }
    return IntArray;
}
int[] TestIntArray = new int[] {-1,2,3,-4,5};
// You should get back [0,2,3,0,5], think about how you will show that this worked
int[] result5 = NonNegatives(TestIntArray);
foreach (int entry in result5) {
    Console.WriteLine(entry);
}

//* 6 Print dictionary
static void PrintDictionary(Dictionary<string,string> MyDictionary)
{
    foreach (KeyValuePair<string, string> entry in MyDictionary) {
        Console.WriteLine($"{entry.Key}: {entry.Value}");
    }
}
Dictionary<string,string> TestDict = new Dictionary<string,string>();
TestDict.Add("HeroName", "Iron Man");
TestDict.Add("RealName", "Tony Stark");
TestDict.Add("Powers", "Money and intelligence");
PrintDictionary(TestDict);

//* 7 Find Key
static bool FindKey(Dictionary<string,string> MyDictionary, string SearchTerm)
{
    if (MyDictionary.ContainsKey(SearchTerm)) {
        return true;
    } else {
        return false;
    }
}
// Use the TestDict from the earlier example or make your own
// This should print true
Console.WriteLine(FindKey(TestDict, "RealName"));
// This should print false
Console.WriteLine(FindKey(TestDict, "Name"));

//* 8 Generate a Dictionary
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