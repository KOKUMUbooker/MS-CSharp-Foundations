/* 
- Methods that add blank spaces for formatting purposes (PadLeft(), PadRight())
- Methods that compare two strings or facilitate comparison (Trim(), TrimStart(), TrimEnd(), GetHashcode(), the Length property)
- Methods that help you determine what's inside of a string, or even retrieve just a part of the string (Contains(), StartsWith(), EndsWith(), Substring())
- Methods that change the content of the string by replacing, inserting, or removing parts (Replace(), Insert(), Remove())
- Methods that turn a string into an array of strings or characters (Split(), ToCharArray())
*/

// - Pad function (PadLeft & PadRight) are overloaded functions
// - The no. provided ie 1st argument is the length of the string plus 
//   the white space characters that you want to add as padding
// - The other variant of the pad functions allows them to take in a 
//   second parameter which is used to specify a character to use for padding 
//   instead of whitespaces.

 string paymentId = "769C";
 string payeeName = "Mr. Stephen Ortega";
 string paymentAmount = "$5,000.00";

 var formattedLine = paymentId.PadRight(6);
 formattedLine += payeeName.PadRight(24);
 formattedLine += paymentAmount.PadLeft(10);

 Console.WriteLine("1234567890123456789012345678901234567890");
 Console.WriteLine(formattedLine);