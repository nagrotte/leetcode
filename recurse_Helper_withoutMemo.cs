public class RecursionHelperwithoutMemo{

 public static string inputstr; 
  public static List<string> resultArray = new List<string>();


public static void wrapper(string input){
  inputstr = input; 
  string output = "["; 
  findCombinations("",0);
  int i= 0;
  foreach(string s in resultArray)
  {
    if(i< resultArray.Count-1){

       output = output + s + ", " ;
    }
    else {

      output = output + s + "]";
    }

    i++;
  }
Console.WriteLine("Count:" + resultArray.Count);
  
  Console.WriteLine(output);
}

public static void   findCombinations(string str , int depth) {

  // base
  if ( depth == inputstr.Length) {
    resultArray.Add(str);
    return;
  }

  // recursion

  findCombinations(str, depth+1);
  findCombinations(str + inputstr[depth], depth+1); 
  }


}