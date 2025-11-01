// ====  String data type's Array methods - ToCharArray()
// Separate string int char array then reverse the array then merge the char array into a string
string value = "abc123";
char[] valueArray = value.ToCharArray();
Array.Reverse(valueArray);
string result = new string(valueArray);
Console.WriteLine(result);

// Join elements in the char array using "," & the Join()
string joinedResult = String.Join(",", valueArray);
Console.WriteLine("\",\"-Joined char array into a string : "+joinedResult);

// Separate ","-joined string to be separated using '," & Split()
string[] items = joinedResult.Split(',');
foreach (string item in items)
{
    Console.WriteLine(item);
}