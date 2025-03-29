
public class Unique
{
    public Unique()
    {
        
    }
   // aabc unique are :: b c :: to give back unique characters
   //Hashset doesn't store repitive characters so we need to check the same.

    public char[] UniqueCharacter ( string str)
    {
        int len = str.Length;
        HashSet<char> hset = new HashSet<char>();
        char[] ch = new char[len];

        for(int i =0;i<len;i++)
        {
            if(hset.Contains(str[i]))
            {
                ch[i] = str[i];
            }
            else{
            hset.Add(str[i]);
            }
        }
        
        // if(hset.Count == len)
        // {
        //     return null;
        // }
        return ch;
        
       
    }

// Input: nums = [1,3,5,6], target = 7
// Output: 4
// Input: nums = [1,3,5,6], target = 5
// Output: 2
// Input: nums = [1,3,5,6], target = 2
// Output: 1
    public int Positionfound(int[] num, int numfound)
    {
        int size = num.Length;
        for(int i =0;i<size;i++)
        {
           
            if(num[i]==numfound)
            {
                return i;
            }

            if(num[i]>numfound)
            {
             return i;
            }
           
        }
        return size;
    }

// 121/10 = 12 or 121%10 = 1 12/10 =2 and 12%10 =1
  public bool Palindrome(int x)
  {
    int rem =0 ,  c = x;
    while (c>0)
    {
        rem = rem *10+c%10;
        c/=10;

    }
    return rem == x;
  }

//MADAM
public bool PalindromString (string s)
{
    int len = s.Length;
    char[] ch = new char[len];
    ch = s.ToCharArray();
    int left = 0; int right = len-1;
    while(left<=right)
    {
        if(ch[left] == ch[right])
        {
            left++;
            right--;
        }
        else{
            return false;
        }
        //return false;
    }

    return true;
    
}



















































































}