// ============================ Example 1 ====================
string input = "there are snakes at the zoo";

Console.WriteLine(input);
Console.WriteLine(ReverseSentence(input));

string ReverseSentence(string input) 
{
    string result = "";
    string[] words = input.Split(" ");
    foreach(string word in words) 
    {
        result += ReverseWord(word) + " ";
    }
    return result.Trim();
}

string ReverseWord(string word)
{
    string result = "";
    for (int i = word.Length - 1; i >= 0; i--)
    {
        result += word[i];
    }
    return result;
}

// ============================ Example 2 ====================
string[] words = {"racecar" ,"talented", "deified", "tent", "tenet"};

Console.WriteLine("\nIs it a palindrome?");
foreach (string word in words) 
{
    Console.WriteLine($"{word}: {IsPalindrome(word)}");
}
bool IsPalindrome(string word) 
{
    int start = 0;
    int end = word.Length - 1;

    while (start < end) 
    {
        if (word[start] != word[end]) 
        {
            return false;
        }
        start++;
        end--;
    }

    return true;
}