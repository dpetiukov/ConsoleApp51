Func<List<string>, string> findLongestWord = words =>
{
    string longest = "";
    foreach (string word in words)
    {
        if (word.Length > longest.Length)
        {
            longest = word;
        }
    }
    return longest;
};

List<string> words = new List<string>
{
    "cat",
    "programming",
    "house",
    "computer"
};

Console.WriteLine(findLongestWord(words));
