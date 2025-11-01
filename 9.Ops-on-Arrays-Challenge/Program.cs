string pangram = "The quick brown fox jumps over the lazy dog";

string[] pangramWords = pangram.Split(" ");

for (int i = 0; i < pangramWords.Length; i++)
{
    char[] letters = pangramWords[i].ToCharArray();
    Array.Reverse(letters);
    pangramWords[i] = String.Join("", letters);
}

Console.WriteLine(String.Join(" ",pangramWords));

