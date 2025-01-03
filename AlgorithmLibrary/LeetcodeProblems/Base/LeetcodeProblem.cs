namespace AlgorithmLibrary.LeetcodeProblems;

public abstract class LeetcodeProblem
{
    public int Number { get; }
    public string Name { get; }

    protected LeetcodeProblem(int number, string name)
    {
        Number = number;
        Name = name;
    }

    public abstract void Solve();

    public override string ToString()
    {
        return $"{Number}. {Name}";
    }
}

