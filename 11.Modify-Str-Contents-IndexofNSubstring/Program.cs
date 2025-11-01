/*
 IndexOf() - Gives index of first occurence of a specific character or word from some string. 
 Substring(startIndex, len) - Extract a new string from the original starting from the provided index & takes 
                              (len - 1) characters
*/

// =============== Example 1 ===================
string message = "Find what is (inside the parentheses)";

int openingPosition = message.IndexOf('(');
int closingPosition = message.IndexOf(')');

// Add 1 to skip the "(" single character
openingPosition += 1;
int length = closingPosition - openingPosition;
Console.WriteLine(message.Substring(openingPosition, length));


// ================ Example 2 ===================
string message2 = "What is the value <span>between the tags</span>?";

const string openSpan = "<span>";
const string closeSpan = "</span>";

int openingPosition2 = message2.IndexOf(openSpan);
int closingPosition2 = message2.IndexOf(closeSpan);

openingPosition2 += openSpan.Length;
int length2 = closingPosition2 - openingPosition2;
Console.WriteLine(message2.Substring(openingPosition2, length2));