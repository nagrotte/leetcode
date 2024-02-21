using Microsoft.VisualBasic;

public class fibonacci{

public static int[] fib = {0,1};
public static Dictionary<int, int> memo = new Dictionary<int,int>();
public static long[] tab_memo= {0,1};

public static int Pure_Fib(int n){

//Base 

if (n<=1)
{

    return n;
}

//Recursion

return Pure_Fib(n-1) +Pure_Fib(n-2);

}



public static int Memo_Fib(int n){

//Base 

if (n<=1)
{

    return n;
}

//Recursion
if (memo.ContainsKey(n)){

      return memo[n];  

}
int val = Pure_Fib(n-1) +Pure_Fib(n-2);
memo.Add(n,val);
return val; 

}



public static long Tab_Fib(int n){

//Base 
if (n<=1)
{

    return n;
}
long[] fib = new long[n + 1];
fib[0]=0;
fib[1]=1;

//Recursion

for (int i=2;i<=n;i++){

    fib[i] = fib[i-1] + fib[i-2];
}

return fib[n];

}

/* public static long Tab_Helper(int n){

    long[] tab_memo = new long[n+1];
    for (int i=0; i<n; i++){

            tab_memo[i] =-1;

    }

}

public static long Tab_Fib_Memo(int n){

//Base 
if (n<=1)
{

    return n;
}
long[] fib = new long[n + 1];
fib[0]=0;
fib[1]=1;
//Recursion


for (int i=2;i<=n;i++){

    tab_memo[i] = tab_memo[i-1] + tab_memo[i-2];
}

return tab_memo[n];

} */



}