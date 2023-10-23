//* Three Basic Arrays

int[] intArr = {0, 1, 2, 3, 4, 5, 6, 7, 8, 9};
string[] stringArr = {"Tim", "Martin", "Nikki", "Sara"};
bool[] boolArr = new bool[10];

// for (int i = 0; i < boolArr.Length; i++) {
//     if (i % 2 == 0) {
//         boolArr[i] = true;
//     } else {
//         boolArr[i] = false;
//     }
//     Console.WriteLine($"{boolArr[i]}");
// }

//* List of Flavors

List<string> listFlavor = new List<string>();
listFlavor.Add("chocolate");
listFlavor.Add("vanilla");
listFlavor.Add("mint chocolate chip");
listFlavor.Add("rose");
listFlavor.Add("cookie dough");
Console.WriteLine(listFlavor.Count);
Console.WriteLine(listFlavor[2]);
listFlavor.RemoveAt(2);
Console.WriteLine(listFlavor.Count);


//* User Dictionary

Dictionary<string, string> dictUsers = new Dictionary<string, string>();
//* add key value pairs consisting of user from before and random ice cream flavour
Random rand = new Random();
foreach (string name in stringArr) {
    dictUsers.Add(name, listFlavor[rand.Next(0, 4)]);
}
//* print each key-value pair 
foreach (KeyValuePair<string, string> entry in dictUsers) {
    Console.WriteLine($"{entry.Key} - {entry.Value}");
}