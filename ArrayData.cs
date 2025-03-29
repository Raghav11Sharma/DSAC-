using System.Collections;
using System.Diagnostics.CodeAnalysis;
using System.Numerics;

public class ArrayData{
    public ArrayData(){}

    public double ArrayMedianfind(int[] nums1, int[] nums2)
    {
         int len1= nums1.Length;
        int len2= nums2.Length;
       List<int> newlist = new List<int>();
       for(int i =0;i<len1;i++)
       {
           newlist.Add(nums1[i]);
       }

        for(int j =0;j<len2;j++)
       {
           newlist.Add(nums2[j]);
       }

       int[] medianarray = newlist.ToArray();
      // Array.Sort(medianarray);
       int temp =0;
       for(int i =0;i<medianarray.Length;i++)
       {
        for(int j=i+1;j<medianarray.Length;j++)
        {
            if(medianarray[i]>medianarray[j])
            {
                temp = medianarray[i];
                medianarray[i] = medianarray[j];
                medianarray[j] = temp;
            }
        }
       }
       
       
       double d=0.0;
       double dd=0.0;
       int n = medianarray.Length;
       //int median = n/2;
       if(n%2==0){
        double halfvalue = medianarray[n/2]-1 + medianarray[n/2];
        d = halfvalue/2;
       return d;
       }
       else{
        int val = (n+1)/2;
       d = medianarray[val-1];
           //d = medianarray[median/2]+medianarray[median + 1/2];
            
           return d;
       }
    }

//largest element of array to find with complexity O(N)
public int LargestElementofArray(int[] arr)
{   
    int size = arr.Length;
    int largest = arr[0];
    for(int i =0;i<size;i++)
    {
        if(arr[i]>largest)
        {
            largest = arr[i];
        }
    }
    return largest;

}

//time complexity is 0(2N) which is good 
public int SecondLargestElementinArray(int[] arr)
{
    // int size = arr.Length;
    // int largest = arr[0];
//     for(int i =0;i<size;i++)
//     {
//         if(arr[i]>largest)
//         {
//             largest = arr[i];
//         }
//     }
// int secondlargest = -1;
// for(int i=0;i<size;i++)
// {
//     if(arr[i]>secondlargest && arr[i]!=largest)
//     {
//         secondlargest = arr[i];
//     }
// }

// return secondlargest;



//approach 2 ::
int size = arr.Length;
int largest = arr[0];
int secondlargest = -1;
for(int i=1;i<size;i++)
{
    if(arr[i]>largest)
    {
   secondlargest = largest;
   largest = arr[i];
    }
    else if(arr[i]<largest && arr[i]>secondlargest)
    {
        secondlargest = arr[i];
    }
}
return secondlargest;

}





public int[] RotateArrayToLeftOnePlace(int[] arr)
{
    int size = arr.Length;
    int temp = arr[0];
    for(int i=0;i<size-1;i++)
    {
        arr[i] = arr[i+1];
    }
    arr[size-1] = temp;
    return arr;
}


public int[] LeftRotateArrayWithDPlaces(int[] arr,int d)
{
    int[] temp = new int[d];
    int size = arr.Length;
    for(int i=0;i<d;i++)
    {
        temp[i] = arr[i];
    }

    for(int i=0;i<size-d;i++)
    {
        arr[i] = arr[i+d];
    }

    for(int i=0;i<d;i++)
    {
        arr[i+size-d] = temp[i];
    }

    return arr;
}


public int[] ReverseAnArray(int[] arr)
{
  
    int i = 0;
int j = arr.Length - 1;
while (i < j)
{
    var temp = arr[i];
    arr[i] = arr[j];
    arr[j] = temp;
    i++;
    j--;
}
return arr;
}

//iput 1,2,3,4, 5,6,7     d = 3 output = 5,6,7,1,2,3,4
public int[] RotatePlacesDtoRight(int[] arr, int d)
{
    int[] temp= new int[d] ;
    int size = arr.Length;
    for(int i=0;i<d;i++)
    {
            temp[i] = arr[i+d+1];
    }

    for(int i =0;i<size-d-1;i++)
    {
        arr[i+size-d-1]= arr[i];
    }

    for(int i=0;i<size-d-2;i++)
    {
        arr[i] = temp[i];
    }

    return arr;
}


public int[] MoveAllZeroesToEndOFArray(int[] arr)
{
    int size = arr.Length;
    List<int> l = new List<int>();
    for(int i =0;i<size;i++)
    {
        if(arr[i] != 0)
        {
            l.Add(arr[i]);
            
        }
    }
    int listsize = l.Count;
    for(int i=0;i<listsize;i++)
    {
        arr[i] = l[i];
    }

    for(int i = listsize;i<size;i++)
    {
        arr[i]=0;
    }
return arr;
    // for(int i =0;i<size;i++)
    // {
    //     if(arr[i]>0)
    // }
}


//both arrsya are sorted 
//[1,1,3,3,4,5] [2,3,4,4,5,8]
public int[] GetOnlyUniqueValuesinTwoArraysofUnion(int[] arr1,int[] arr2)
{   
    int len1 = arr1.Length;
    int len2 = arr2.Length;
    int[] unique = new int[len1+len2];

    for(int i =0;i<len1+len2-2;i++)
    {
        if(unique[i]!= arr1[i] && unique[i] != arr2[i])
        {
        unique[i] = arr1[i];
        }
        
    }

    return unique;
}



public int ArrayFindMissingvalue(int[] arr, int n)
{
    int size = arr.Length;
    for(int i =0;i<n;i++)
    {
        // if(arr[i+1]>arr[i])
        // {
           if(arr[i+1] != (arr[i] + 1))
           {
                return (arr[i] + 1);
           }
        // }
    }
    return 0;
}




//Count the number of times a number comes and check which number comes only once

// public int CheckNumberComesOnceInArray(int[] arr)
// {
//     int size = arr.Length;
//     int largest = arr[0];
//     for(int i=1;i<size;i++)
//     {
//         if(arr[i]>largest)
//         {
//             largest = arr[i];
//         }
//     }



// }


//Longest substring and how many length take it to sum inide array
//input =[1,2,4,5,2,5,3] k = 7 so longest continous array which will add to k is ::

// Input: arr[] = { 10, 5, 2, 7, 1, 9 }, k = 15
// Output: 4
// Explanation: The sub-array is {5, 2, 7, 1}.


public int LongestSubArrayWhichAddstoKValue(int[] arr, int k)
{
    int size = arr.Length;
    int sum = 0;
    int maxlen =0;
     Dictionary<int,
               int> map = new Dictionary<int,
                                         int>();

    for(int i =0;i<size;i++)
    {
        sum += arr[i];
        if(sum == k)
        {
            
            maxlen = i+1;
        }
         // make an entry for 'sum' if it is
        // not present in 'map'
        if (!map.ContainsKey(sum))
        {
            map.Add(sum, i);
        }
 
        // check if 'sum-k' is present in 'map'
        // or not
        if (map.ContainsKey(sum - k))
        {
                 
            // update maxLength
            if (maxlen < (i - map[sum - k]))
            
                maxlen = i - map[sum - k];
        }
    }
     
    return maxlen;  
    
}




//find the 2 any no which will give us the reult or equal to result 

public List<int> TwoSumProblem(int[] arr, int k)
{
    int size = arr.Length;
    //int sum =0;
    Dictionary<int,int> dict = new Dictionary<int, int>();
    List<int> list = new List<int>();
    for(int i =0;i<size;i++)
    {
        //sum+= arr[i];
        if(!dict.ContainsKey(arr[i]))
        {
            dict.Add(arr[i],i);
        }

            if (dict.ContainsKey(k - arr[i])|| dict.ContainsKey(k))
            {
                list.Add(arr[i]);
                list.Add(k-arr[i]);
                return list;
                //list.Add(k);
                //return true;
            }

        
    }
    return list;





}



public int BestTimeToBuyAndSellStock(int[] arr)
{
    int size = arr.Length;
   
   int min=arr[0]; int profit =0;int cost;
   for(int i =1;i<size;i++)
   {
    cost = arr[i]-min;
    profit = Math.Max(profit,cost);
    min = Math.Min(min,arr[i]);

   }
   return profit;
}




//String problems
public string LongestSubstringPalindrome(string s)
{
    int len = s.Length;
    char[] ch = new char[len];
    ch = s.ToCharArray();
        char[] ch2 = new char[len];
        int count =0;
    for(int i=0;i<ch.Length-3;i++)
    {
        for(int j=i+2;j<=i+2;j++)
        {
            if(ch[i]==ch[j])
            {
                ch2[i] = ch[i];
                ch2[i+1]= ch[i+1];
                ch2[i+2] = ch[i+2];
                count++;
            }
        }
    }
string res = new string(ch2);
return res;

}


//find duplicate values in array

public int[] DuplicateValuesinArry(int[] arr)
{
    int len = arr.Length;
    Dictionary<int,int> dic = new Dictionary<int, int>();

    for(int i=0;i<len;i++)
    {
        if(dic.ContainsKey(arr[i]))
        {
            dic.Add(arr[i],1);
        }
        else
        {
            dic.Add(arr[i],1);
        }
    }

    int[] temp = new int[len];
    
    temp = dic.Keys.ToArray();
    
    return temp;
}


//using 2 pointer approach
public int[] MoveAllZeroeesENDofArray(int[] arr)
{
    int len = arr.Length;
   
    int j = -1;
    for(int i =0;i<len;i++)
    {
        if(arr[i]==0)
        {
            
           j = i;
            break;
        }
    }
    for(int i = j+1;i<len;i++)
    {
        if(arr[i]!=0)
        {
            //here need to swap value i and j 
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
            j++;
        }
        
    }
    return arr;
}







}