namespace Tasks;
public class TaskValidAnagram {
    public bool IsAnagram(string s, string t) {
       s = String.Concat(s.OrderBy(ch => ch));
       t = String.Concat(t.OrderBy(ch => ch));
       if(s.Equals(t))
           return true;
        return false;

    }
}