public class PureRecurseMemo {
  public static Dictionary<string,int> memo = new Dictionary<string,int>();
  
  public static int LatticePaths(int row, int col)
  {
    if (row<0 || col<0){
      return 0;

    }
    if (row == 0 && col==0) {
       return 1;

    }

if (memo.ContainsKey(row + "_" + col))
 {
   return memo[row + "_" + col];
 }
    int up = LatticePaths(row-1, col);
    int left = LatticePaths(row, col-1);
     memo.Add(row + "_" + col, up+left);
     return up + left;
   }
}
