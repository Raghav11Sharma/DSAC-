public class FirstProgram
{
    public FirstProgram()
    {
    }

    public void ArrayTest()
    {
        Console.WriteLine("Enter the length of array:");
             //Use conversion functions to convert string to int
            int num =Convert.ToInt32( Console.ReadLine());
            int [] array= new int[num];

            for(int i=0;i<num;i++)
            {
                Console.WriteLine("Enter value in array");
                array[i] = Convert.ToInt32( Console.ReadLine());
            }

            Console.WriteLine("Enter value to be delete from array");
            int value =Convert.ToInt32( Console.ReadLine());
            List<int> list = new List<int>(array);
            // foreach(var v in list)
            // {
            //     if (v == value)
            //     {
            //        list.Remove(v);
            //     }
            // }
            foreach(var v in list)
            {
             //Console.WriteLine("List values"+v);
             if(v == value)
             {
                list.Remove(v);
             }

            }
            foreach(var vv in list)
            {
                Console.WriteLine("list data"+vv);
            }



    }

    public void TwoDArray()
    {
       Console.WriteLine("Enter the 2d array row ");
             int row =Convert.ToInt32( Console.ReadLine());
             Console.WriteLine("Enter the 2d array column");
            int col =Convert.ToInt32( Console.ReadLine());
            int[,] twodarry = new int [row,col];


    }
}