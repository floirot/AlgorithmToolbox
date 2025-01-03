using AlgorithmLibrary;

Console.WriteLine("Welcome to the Algorithm Toolbox!");
//Console.WriteLine("1. Quick Sort");
Console.WriteLine("2. Exit");
Console.Write("Choose an option: ");
string choice = Console.ReadLine();

switch (choice)
{
    case "1":
        int[] array = { 5, 3, 8, 4, 2 };
        Console.WriteLine("Original Array: " + string.Join(", ", array));
        //QuickSort.Sort(array, 0, array.Length - 1);
        Console.WriteLine("Sorted Array: " + string.Join(", ", array));
        break;
    case "2":
        Console.WriteLine("Exiting...");
        break;
    default:
        Console.WriteLine("Invalid option. Try again.");
        break;
}
