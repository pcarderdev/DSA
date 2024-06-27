namespace DSA;

public class ContainsDuplicate
{
    public static bool HasDuplicate(int[] nums)
    {

        HashSet<int> set = new HashSet<int>();

        // Loop through nums, adding num to set
        // If set already contains, num -> true
        // If exits loop, -> false
        foreach (int num in nums)
        {
            if (set.Contains(num)) return true;
            set.Add(num);
        }
        return false;
    }
}