

public class TwoPointer
{
    public int MaximumConsecutiveKValue(int k, int[] arr)
    {
        int result = 0;
        int size = arr.Length;
        int left = 0;
        int right = size - k;
        for (int i = 0; i <= size - k; i++)
        {
            result += arr[i];
        }
        while (right < size - 1)
        {
            result = result - arr[left];
            right++;
            left++;
            result = result + arr[right];
        }

        int max = Math.Max(result, result);

        return result;
    }


    public List<int> LongestSubArraySizeToK(int k, int[] arr)
    {

        int size = arr.Length;
        List<int> res = new();
        int right = 0;
        int left = 0;
        int sum = 0;
        int maxlength = 0;
        while (right < size)
        {
            sum = sum + arr[right];
            while (sum > k)
            {
                sum = sum - arr[right];
                left = left + 1;
            }

            if (sum <= k)
            {
                maxlength = Math.Max(maxlength, right - left + 1);
                res.Add(arr[right]);
                res.Add(arr[left]);
                right = right + 1;
            }
        }
        return res;




    }






    public int MaximumConsecutiveValueAdduptoK(int k, int[] arr)
    {
        int size = arr.Length;
        int left = 0; int right = 0;
        int result = 0;
        int maxlen = 0;
        while (right < size)
        {
            if (result < k)
            {
                result += arr[right];
                right++;
            }
            else if (result > k)
            {
                result -= arr[left];
                left++;

            }
            else
            {
                break;
            }

        }
        maxlen = Math.Max(maxlen, right - left);
        return maxlen;
    }





}