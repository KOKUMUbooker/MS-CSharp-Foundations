string[] values = { "12.3", "45", "ABC", "11", "DEF" };
string msg = "";
decimal total = 0.0m;

foreach (string value in values)
{
    decimal curVal = 0.0m;
    if (decimal.TryParse(value, out curVal))
    {
        total += curVal;
    }
    else
    {
        msg += value;
    }
}

Console.WriteLine($"Message: {msg}");
Console.WriteLine("Total: " + total);

