public class DictionaryClass{
    
    public DictionaryClass()
    {

    }
    public void KeyValueData()
    {
        Console.WriteLine("Enter the Values");
        int value =Convert.ToInt32( Console.ReadLine());

        int[] arr = new int[3];
        arr[0]=value/10;
        arr[1]=value%10;
        // Dictionary<int,string> dict = new Dictionary<int, string>();
        // dict.Add(1,"abc");
        // dict.Add(2,"def");
        // dict.Add(3,"ghi");
        Console.WriteLine("values are "+ arr[0]);
                Console.WriteLine("values are "+ arr[1]);

    }
}