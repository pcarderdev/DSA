using System.Collections;
using System.Threading.Tasks.Dataflow;

namespace DSA;

public class ValidAnagram
{

  // Elegant method only works if all letters in s and t are lowercase
  public bool IsAnagramElegantSolution(string s, string t)
  {
    // Low hanging fruit
    if (s.Length != t.Length) return false;

    // Store of 'alphabet'
    int[] store = new int[26];

    // val at index in s++, t--
    for (int i = 0; i < s.Length; i++)
    {
      store[s[i] - 'a']++;
      store[t[i] - 'a']--;
    }

    // Make sure store is clean
    foreach (int v in store) if (v != 0) return false;
    return true;
  }


  public bool IsAnagram(string s, string t)
  {
    Dictionary<char, int> tbl = new Dictionary<char, int>();

    // Loop through s and add all the chars to our tbl
    // If key exists, val++
    // If key does not exist, create entry with val 1

    foreach (char c in s)
    {
      if (tbl.ContainsKey(c))
      {
        tbl[c] = tbl[c] + 1;
      }
      else
      {
        tbl.Add(c, 1);
      }
    }

    // Loop through t and subtract from tbl vals
    // If key exists, val-- 
    //     If val < 0, return false
    // If key does not exist, return false
    foreach (char c in t)
    {
      if (tbl.ContainsKey(c))
      {
        tbl[c] = tbl[c] - 1;
      }
      else
      {
        return false;
      }
    }


    // Loop through tbl, check all vals == 0
    // If val != 0, return false
    foreach (KeyValuePair<char, int> kvp in tbl)
    {
      if (kvp.Value != 0)
      {
        return false;
      }
    }

    // return true
    return true;
  }

}