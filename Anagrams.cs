public class Anagrams{

 public static string[] input = new string[0];
       public static Dictionary<string, List<string>> _hash = new Dictionary<string, List<string>>();

    public static IList<IList<string>> GroupAnagrams(string[] strs) {
            string[] anagramArray = new string[strs.Length];
        foreach (var str in strs)
        {
                 string sortedStr = new string(str.ToCharArray().OrderBy(c => c).ToArray());
                if (!_hash.ContainsKey(sortedStr)){
                    
                _hash[sortedStr] = new List<string>();
                }
                _hash[sortedStr].Add(str);

        }
       List<string> anagramList = new List<string>();
        foreach (var entry in _hash.Values)
        {
            anagramList.AddRange(entry);
        }
        var result =_hash.Values.Select(list => (IList<string>)list).ToList<IList<string>>();
        _hash= new Dictionary<string, List<string>>();
        return  result;
    }
}