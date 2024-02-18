public class BitArraySorting{



  public static int[] BitArraySort(int[] arr)
  {
     int mid = 0;
     for (int i = 0; i < arr.Length; i++) {
         if (arr[i] == 0) {

           int temp = arr[i];
           
        
           
             arr[i] = arr[mid];
             arr[mid] = temp;
             mid++; 
         }
     }
     return arr; 
   }


}