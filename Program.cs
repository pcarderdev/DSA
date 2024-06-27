namespace DSA;

class Program
{
    static void Main(string[] args)
    {
        int[] nums = { 1, 2, 2, 4, 5, 1 };
        bool x = ContainsDuplicate.HasDuplicate(nums);
        Console.WriteLine(x);
    }
}
