public class Solution {
    public int LongestPalindrome(string s) {
        var hash = new HashSet<char>();
        int maxLength = 0;

        foreach (var c in s)
        {
            if (hash.Contains(c))
            {
                hash.Remove(c);
                maxLength += 2;
            }
            else
                hash.Add(c);
        }

        int ans;
        if (hash.Count > 0)
            ans = maxLength + 1;
        else
            ans = maxLength;

        return ans;
    }
}