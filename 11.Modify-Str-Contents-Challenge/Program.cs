// TARGET OUTPUT
/*
Quantity: 5000
Output: <h2>Widgets &reg;</h2><span>5000</span>
*/
const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";

string quantity = "";
string output = "";

// Your work here
// Quantity : 
const string opSpan = "<span>";
int openingSpanPos = input.IndexOf(opSpan);
int closingSpanPos = input.IndexOf("</span>");

openingSpanPos += opSpan.Length;
int quantityStrLen = closingSpanPos - openingSpanPos;
quantity = input.Substring(openingSpanPos, quantityStrLen);

// Output : 
output = input.Replace("&trade", "&reg");
const string divOp = "<div>";
int openingDivPos = output.IndexOf(divOp);
int closingDivPos = output.IndexOf("</div>");

openingDivPos += divOp.Length;
int outputStrLen = closingDivPos - openingDivPos;
output = output.Substring(openingDivPos,outputStrLen);

Console.WriteLine($"Quantity: {quantity}");
Console.WriteLine($"Output: {output}");