/*
 - The .IndexOf() method returns the index of the first occurrence 
   of a specified character or substring within a given string. 
 - The method .LastIndexOf() returns the index position of the last
   occurrence of a character or string within a given string. 
 - Both the Indexof() and LastIndexOf() methods return -1 if the 
   character or string is not found.
*/

// ============ Example 1 (IndexOf & LastIndexOf) =====================
string message = "hello there!";

int first_h = message.IndexOf('h');
int last_h = message.LastIndexOf('h');

Console.WriteLine($"For the message: '{message}', the first 'h' is at position {first_h} and the last 'h' is at position {last_h}.\n");

// ============ Example 2 (IndexOf & LastIndexOf) =====================
string message2 = "(What if) there are (more than) one (set of parentheses)?";
while (true)
{
    int openingPosition1 = message2.IndexOf('(');
    if (openingPosition1 == -1) break;

    openingPosition1 += 1;
    int closingPosition = message2.IndexOf(')');
    int length = closingPosition - openingPosition1;
    Console.WriteLine(message2.Substring(openingPosition1, length));

    // Note the overload of the Substring to return only the remaining 
    // unprocessed message:
    message2 = message2.Substring(closingPosition + 1);
}


/*
 - .IndexOfAny() reports the index of the first occurrence of 
    any character in a supplied array of characters. 
 -  The method returns -1 if all characters in the array of characters 
    are not found.
 -  IndexOfAny() will scan through the string(left to right) comparing each
    char in the string to all char elements in the char array.
    If it finds a match it returns that index.
*/
// ============ Example 1 (IndexOfAny) ========================
string message3 = "Hello, world!";
char[] charsToFind = ['a', 'e', 'i'];

int index = message3.IndexOfAny(charsToFind);

Console.WriteLine($"Found '{message3[index]}' in '{message3}' at index: {index}.\n");

// ============ Example 2 (IndexOfAny - Overloaded verion that recieves 2nd param - starting index) ========================
string message4 = "Help (find) the {opening symbols}";
Console.WriteLine($"Searching THIS Message: {message4}");
char[] openSymbols = { '[', '{', '(' };
int startPosition = 5;
int openingPosition = message4.IndexOfAny(openSymbols);
Console.WriteLine($"Found WITHOUT using startPosition: {message4.Substring(openingPosition)}");

openingPosition = message4.IndexOfAny(openSymbols, startPosition);
Console.WriteLine($"Found WITH using startPosition {startPosition}:  {message4.Substring(openingPosition)}");
