
using System.Linq;

public class Recursion{



public int factorial(int n)
{
     if (n == 0) return 1;
  
    return n * factorial(n - 1);
}



public String ReverseString(string s)
{
    int len = s.Length;
    char[] ch = s.ToCharArray();
    char[] ch2 = new char[len];
    for(int i=len-1;i>=0;i--)
    {
        ch2[len - i-1] = ch[i];
    }
     string result = string.Join("", ch2);
     return result;
}

public string ReverseStringUsingTwoPinter(string s)
{
    int len = s.Length;
    string  res="";
    int left =0;int right = len-1;
    while(right>=left)
    {
        res += s[right];
        right--;
    }
    return res;
}



public string ReverseEachWordOFString(string s)
{ 
    string[] arr = s.Split(" ");
    string result ="";

    for(int i=0;i<arr.Length;i++)
    {
        if(i!= arr.Length - 1)
        {
            result += ReverseString(arr[i]) + " ";
        }
        else
        {
            result += ReverseString(arr[i]);
        }   
        
     }
    return result;
}
// Welcome to CSharp
//output Csharp to Welcome
public string ReverseOnlyWordofString(string s)
{
    string[] arr = s.Split(" ");
    string result = "";
    for(int i =arr.Length -1; i>=0;i--)
    {
        result += arr[i] + " ";
    }
    return result;

}




public string ReverseEachWordOFStringUsing2Pointer(string s)
{ 
    string[] arr = s.Split(" ");
    string result ="";

    for(int i=0;i<arr.Length;i++)
    {
        
            int len = arr[i].Length;
            int right = len-1;
            int left = 0;
            while(right>=left)
            {
                result += arr[i][right];
                right --;
            }
            result += " ";
        
     }
    return result;
}


public string CountStringCharactersintoNumeric(string s)
{
    int len = s.Length;
    string res="";
    Dictionary<char,int> dict = new Dictionary<char, int>();
    for(int i =0;i<len;i++)
    {
        if(!dict.ContainsKey(s[i]))
        {
         dict.Add(s[i],1);    
        }
        else{
        dict[s[i]]++;
        }
    }
    foreach(var i in dict)
    {
    res = (string)res.Append(i.Key);
    int val = i.Value;
    //res = res.Append(val.ToString());
    }

return "";
}


public void MakeAllPermutationsofString(string input)
{
    int len = input.Length;
    for(int i =0;i<len;i++)
    {
        for (int j = 0;j<=len;j++)
        {
            Console.WriteLine(input.Substring(i,j));
        }
    }
}


public long MinimumLossofHouseselling(int[] arr)
{
    Dictionary<int,int> dic = new Dictionary<int,int>();
    int len = arr.Length;
    for(int i =0;i<len;i++)
    {
        dic.Add(i,arr[i]);
    }
    int temp =0;int j,k;
    for( j =0;j<len;j++)
    {
        for( k = j+ 1;k<len;k++)
        {
            if(arr[j]>arr[k])
            {
                temp = arr[j];
                arr[j] = arr[k];
                arr[k] = temp;
            }
        }
    }

    long minimumloss= long.MaxValue;

    for(int i = len-1; i>0 ;i--)
    {
        if(dic.ElementAt(i).Value > dic.ElementAt(i-1).Value)
        {
            long dayloss = arr[i] - arr[i-1];
            minimumloss = Math.Min(dayloss,minimumloss);
        }
    }
 return minimumloss;


}


public void DictionaryTest(int[] arr)

{
    int len = arr.Length;
    Dictionary<int,int> dic = new Dictionary<int, int>();
    foreach(var i in arr)
    {
        dic.Add(i,i*5);
    
    Console.WriteLine("Dictionary key is "+ dic);

      Console.WriteLine("Dictionary value is "+ dic.GetValueOrDefault(i));

    }
}



}