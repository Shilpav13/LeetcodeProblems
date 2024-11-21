public class Solution {
    public bool IsPalindrome(string s) {
        var varun=new StringBuilder();
        foreach(char c in s)
        {
            if(char.IsLetterOrDigit(c))
            {
                varun.Append(char.ToLower(c));
            }
        }
        String shilpa = varun.ToString();
        int left=0; int right=shilpa.Length-1;
        while(left<right)
        {
            if(shilpa[left]!=shilpa[right])
            {
                return false;
            }
            left++;
            right--;
        }
        return true;
    }
}