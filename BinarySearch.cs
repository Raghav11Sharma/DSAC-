public class BinarySearch{
    public BinarySearch()
    {
        
    }

    public void  Search(int[] a,int key)
    {
        int len = a.Length;
        int middlepoint = len/2;
         Array.Sort(a);
        if(key < middlepoint)
        {
         for(int i=1;i<middlepoint;i++)
         {
            if(key == a[i]) 
            { Console.WriteLine("array value found at first half"+ a[i]);  }
         }
        }
        else
        {
            for(int i=middlepoint;i<len;i++)
            {
               if(key == a[i]) 
            { 
                Console.WriteLine("array value found at second half"+ a[i]);

            }
            }
        }

    }
}