// Array declaration
string[] fraudulentOrderIDs = new string[3];

Console.WriteLine($"Unassigned value {fraudulentOrderIDs[1]}");

// Assign values to array elements
fraudulentOrderIDs[0] = "A123";
fraudulentOrderIDs[1] = "B456";
fraudulentOrderIDs[2] = "C789";

// Retrieve array value at specific indices
Console.WriteLine($"First: {fraudulentOrderIDs[0]}");
Console.WriteLine($"Second: {fraudulentOrderIDs[1]}");
Console.WriteLine($"Third: {fraudulentOrderIDs[2]}");

// Initialize Array
string[] hobbies = ["Drawing","Gaming","Watching movies"]; // Newer version
string[] movies = {"Quiet Place","Conjuring","Anabelle"}; // Older version

Console.WriteLine($"User has {hobbies.Length} hobbies & has watched {movies.Length} movies");

Console.WriteLine($"Reassign First: {fraudulentOrderIDs[0]}");
Console.WriteLine($"There are {fraudulentOrderIDs.Length} fraudulent orders to process.");