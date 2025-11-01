/*
 - Remove() -> Used when there's a standard and consistent 
               position of the characters you want to remove 
               from the string.
 - Remove(startIndex, count)
*/
string data = "12345John Smith          5000  3  ";
string updatedData = data.Remove(5, 20);
Console.WriteLine($"OG string len {data.Length},OG str : \"{data}\"\nUpdated len : {updatedData.Length} ,updatedData : \"{updatedData}\"\n");

/*
 - Replace() -> Used when you need to replace one or more 
                characters with a different character (or no 
                character).
 - Replace() replaces every instance of the given characters,
   not just the first or last instance.
 - Replace(pattenInString, valueToReplaceWith)
*/
string ogMessage = "This--is--ex-amp-le--da-ta";
string message = ogMessage;
message = message.Replace("--", " ");
message = message.Replace("-", "");
Console.WriteLine($"OG string : \"{ogMessage}\"\nUpdated message \"{message}\"");