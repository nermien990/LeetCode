public class Solution {
    public string ReverseWords(string s) {
        
     if (s.Length == 0)
        return s;
    
    var sb = new StringBuilder(s.Length);                    
            
    // i = iterating input string, j possition not yet appended to output
    for (int i = 0, j = 0; i <= s.Length; i++) {
        if (s[j] == ' ') {
            sb.Append(' ');
            j = i;
        }
        else if (s[j] != ' ' && (i >= s.Length || s[i] == ' ')) {
            // reverse j <--> i - 1
            for (int k = i - 1; k >= j; k--) {
                sb.Append(s[k]);
            } 
            j = i;
        }
    }
    return sb.ToString();  
        
    }
    
    
}