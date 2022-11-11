namespace LeetCode.TasksMedium;
public class TaskGroupAnagrams {
    public IList<IList<string>> GroupAnagrams(string[] strs) {
        Dictionary<string, IList<string>> dict = new();
        foreach(var s in strs){
            string str = String.Concat(s.OrderBy(ch => ch));
            if(!dict.ContainsKey(str)) 
                dict.Add(str, new List<string>{s});
            else
                dict[str].Add(s);
        }
        return dict.Values.ToList();
    }
}