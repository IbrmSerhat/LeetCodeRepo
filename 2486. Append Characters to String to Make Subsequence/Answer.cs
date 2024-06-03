public class Solution {
    public int AppendCharacters(string s, string t) {
        int size = t.Length;
        int j = 0;
        for( int i = 0 ; i < s.Length; i++){
            if(s[i] == t[j]){
                size--;
                if(j < t.Length - 1) j++;
            }
        }
        return size;
    }
}