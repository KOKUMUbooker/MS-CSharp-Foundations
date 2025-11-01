// ======================== Implicit conversion ================
int first = 2;
string second = "4";
string result = first + second;
Console.WriteLine("Implicit conversion from int to string, result : " + result);

// ===================== Explicit conversions ===================
// i) Calling methods from the variable eg ToString() in int
int first2 = 5;
int second2 = 7;
string message = first2.ToString() + second2.ToString();
Console.WriteLine(" Calling methods from the variable " + message);

// ii) Calling methods from data types eg int.Parse
// a) int.Parse - Unsafe ie can fail & terminate program if given invalid var type
string first3 = "5";
string second3 = "7";
int sum = int.Parse(first3) + int.Parse(second3);
Console.WriteLine("Calling methods from data types : " + sum);
// b) int.TryParse - Safe alternative; returns true if the conversion is successful, false if it's unsuccessful.
string value = "102";
int result4 = 0;
if (int.TryParse(value, out result4))
{
   Console.WriteLine($"Measurement: {result}");
}
else
{
   Console.WriteLine("Unable to report the measurement.");
}

// iii) Using the Convert class eg Convert.ToInt23("34)
string value1 = "5";
string value2 = "7";
int result2 = Convert.ToInt32(value1) * Convert.ToInt32(value2);
Console.WriteLine(result2);

// =========  Type casting vs Conversion
int value4 = (int)1.5m; // casting truncates
Console.WriteLine(value4);

int value3 = Convert.ToInt32(1.5m); // converting rounds up
Console.WriteLine(value3);
