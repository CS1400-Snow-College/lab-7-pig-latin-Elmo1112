Console.Write("Please enter the message: ");
string message = Console.ReadLine().ToLower();

string[] words = message.Split(' ');
string pigLatin = "";

foreach (string word in words)
{
    string pigWord = word;
    char first = word[0];

    if ("aeiou".IndexOf(first) >= 0)
    {
        pigWord = word + "way";
    }
    else
    {
        int i = 0;
        while (i < word.Length && "aeiou".IndexOf(word[i]) == -1)
        {
            i++;
        }
        pigWord = word.Substring(i) + word.Substring(0, i) + "ay";
    }

    pigLatin += pigWord + " ";
}

Console.WriteLine("In Pig Latin that's: " + pigLatin.Trim());

int shift = 5;
string cryptogram = "";

foreach (char c in pigLatin)
{
    if (char.IsLetter(c))
    {
        char shifted = (char)(c + shift);
        if (shifted > 'z') shifted = (char)(shifted - 26);
        cryptogram += shifted;
    }
    else
    {
        cryptogram += c;
    }
}

Console.WriteLine("We can encrypt that as: " + cryptogram);



