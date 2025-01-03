namespace AlgorithmLibrary.LeetcodeProblems;

public class MergeStringsAlternately : LeetcodeProblem
{
    public MergeStringsAlternately() : base(1768, "Merge Strings Alternately") { }

    public override void Solve()
    {
        Console.WriteLine("Enter word1:");
        string word1 = Console.ReadLine() ?? "";
        Console.WriteLine("Enter word2:");
        string word2 = Console.ReadLine() ?? "";

        if(word1.Length < 1 || word1.Length > 100 || word2.Length < 1 || word2.Length > 100)
        {
            Console.WriteLine("Words should be betwenn 1,100 long.");
            return;
        }

        var result = MergeAlternately(word1, word2);
        Console.WriteLine($"Result: {result}");
    }

    private string MergeAlternately(string word1, string word2)
    {
        string result = "";
        int maxLength = word1.Length > word2.Length ? word1.Length : word2.Length;
        int currentStringPos = 0;

        while (currentStringPos < maxLength)
        {
            if (currentStringPos < word1.Length)
            {
                result = result + word1[currentStringPos];
            }
            if (currentStringPos < word2.Length)
            {
                result = result + word2[currentStringPos];
            }

            currentStringPos++;
        }

        return result;
    }
}
