public class LongestSubstring {
    //longest substring without repeating characters
    public int LengthOfLongestSubstring(string s) {
       
    var letters = new Dictionary<char, int>(); // key:letter, val: latest index
	int maxCount = 0, left = 0, right;

	for (right = 0; right < s?.Length; right++) {
		char letter = s[right];

		if (letters.ContainsKey(letter)) { // End the window
			left = Math.Max(left, letters[letter] + 1); // Update left of window
		}

		letters[letter] = right; //Update index of letter on map

		maxCount = Math.Max(maxCount, right - left + 1); // Get the longest window length 
	}

	return maxCount;
    }


	public int LongestSubstringWithoutRepeatingCharacters(string s)
	{
		int size = s.Length;
		Dictionary<char,int> dict = new Dictionary<char, int>();
		
		int left=0,right=0;
		int maxlen=0;

		while(right<size)
		{
			if(dict.ContainsKey(s[right]))
			{
				if(dict[s[right]]>=left)
				{
				left = dict[s[right]] +1;
				}
			}
			maxlen = Math.Max(maxlen,right-left+1);
			dict[s[right]] = right;
			right ++;
		}
		return maxlen;
	}



public int LongestSubstringwithKAtMostValues(int k, string s)
{
	int left=0,right=0;
	int size = s.Length;
	Dictionary<char,int> dict = new Dictionary<char, int>();
	int maxlen=0;

	while(right<size-1)
	{
		if(dict.ContainsKey(s[right]))
		{
			dict[s[right]]++;
			right++;
		}

		if(!dict.ContainsKey(s[right]))
		{
			dict.Add(s[right],0);
		}
		
		if(dict.Count>k)
		{
			dict[s[left]]--;
			if(dict[s[left]] == 0)
			{
				dict.Remove(s[left]);
			}
			left++;			
		}
	}

	maxlen = Math.Max(maxlen,right-left+1);

	return maxlen;

}


}