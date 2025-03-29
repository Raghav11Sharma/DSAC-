using System.Text;

public class StringClassProb
{
    public void GetPossibleSubStringFromString(string s)
    {
        char[] arr ;
        string res ="";
        int len = s.Length;
        for(int i =0;i<len;i++)
        {
            for(int j = i;j<len;j++)
            {
               Console.WriteLine("Value is " +  s.Substring(i,j-i+1));
            }
        }
    }



    public string GetIntegerNumberReverseandOriginalNumber(int num)
    {
        string input = num.ToString();
        char[] ch = input.ToCharArray();
        string res="";
        int left=ch[0];int right = ch.Length-1;
        while(right>=0)
        {
            res += ch[right];
            right--;
        }
        res += input;
        return res;

    }



    public bool SmoothSentenceorNot(string s)
    {
        string[] arr = s.Split(" ");
        for(int i =0;i<arr.Length;i++)
        {
            for(int j=i+1;j<arr.Length;j++)
            {
                if(arr[i].Last() != arr[j].First())
                {
                    return false;
                }
                break;
            }
        }
        return true;
    }

  
  public void AsciiCodeValue(string value)
  {
    byte[] asciiBytes = Encoding.ASCII.GetBytes(value);
    foreach(var val in asciiBytes)
    {
       //int a = BitConverter.ToInt32(val);
        



    }
  }


//Anagram if letters in one string is similar to other means a if comes in s1 one times if 
//2 times in s2 then false not a anagram else tryue and a anagram

public bool AnagramCheck(string s1, string s2)
{
    if(s1.Length != s2.Length)
    {
        return false;
    }
    Dictionary<char,int> dict = new Dictionary<char, int>();
    for(int i =0;i<s1.Length;i++)
    {
        if(!dict.ContainsKey(s1[i]))
        {
            dict.Add(s1[i],1);
        }
        else
        {

            dict[s1[i]]++;
        }
    }

    for(int i =0;i<s2.Length;i++)
    {
        if(dict.ContainsKey(s2[i]))
        {
            dict[s2[i]]--;
        }
        else{
            dict[s2[i]]++;
        }
    }

    foreach(var value in dict.Values)
    {
        if(value !=0)
        {
            return false;
        }
    }

    return true;
}










}