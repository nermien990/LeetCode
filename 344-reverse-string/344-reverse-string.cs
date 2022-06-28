public class Solution {
    public void ReverseString(char[] s) {
        char temp = ' ';
        int right = s.Length-1;
        for(int i = 0; i < right; i++)
        {
            temp = s[i];
            s[i] = s[right];
            s[right] = temp;
            right --;
        }
        
        
    }
}