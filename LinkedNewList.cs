using System.Collections.Generic;
using System.Drawing;

public class LinkedNewList
{
    public NodeList Head;
    public NodeList Tail;
    public int size;

    public LinkedNewList()
    {   
        Head = null;
        Tail =null;
        size = 0;
        
    }

    public void AddFirstElementtoLL(int v)
{   
    NodeList n = new NodeList(v,null);
   if(Head == null)
   {
    Head = n;
    Tail = n;
    size = size +1;
   }
   else {
    Tail._next = n;
    Tail= n;
    size =size+1;



    
   }
  
   
    
   

}

//program to add 2 numbers so input 2 linkedlist and need to add both and send back ll in reverse number order


public NodeList AddTwoList(NodeList l1, NodeList l2)
{
    // List<int> list = new List<int>();
    // List<int> list2 = new List<int>();
    // NodeList start;
    // start = l1;
    // while(start != null)
    // {
       
    //     list.Add(start.value);
    //      start = start._next;
         
    // }
    // NodeList startl2;
    // start = l2;
    // while(start != null)
    // {
       
    //     list2.Add(start.value);
    //      start = start._next;
         
    // }
    
    // var combinedlist = string.Concat(list);
    // var combinedlist2 = string.Concat(list2);
    // int result = int.Parse(combinedlist) + int.Parse(combinedlist2);



  //Alternate solution
  NodeList result = new NodeList(0,null);
        NodeList head = result;
        int sum = 0;
        while (l1 != null || l2 != null || sum > 0) // to keep running if we hava a value in l1, l2 or carry
        {
            // two if statments because l1 and l2 can be of different sizes
            if (l1 != null)
            {
                sum += l1.value;
                l1 = l1._next;
            }
            if (l2 != null)
            {
                sum += l2.value;
                l2 = l2._next;
            }
            result._next=new NodeList(sum % 10,null); //digit
            sum /= 10; //carry
            result = result._next;
        }
        return head._next; //we don't want to return head as it will add a node=0 at the start so -> wrong answer
    }  


    public void ReverseLinkedlIst()
    {
        LinkedNewList ll = new LinkedNewList();
        NodeList temp = Head;
        Head = Tail;
        Tail = temp;
        NodeList before = null;
        NodeList after = temp._next;

        for(int i=0;i<size;i++)
        {
            after = temp._next;
            temp._next = before;
            before = temp;
            temp = after; 
        }
    }






 public void display()
        {
            NodeList p = Head;
            while (p != null)
            {
                Console.Write(p.value + " --> ");
                p = p._next;
            }
            Console.WriteLine();
        }

         public void displayafterReverse()
        {
            NodeList p = Head;
            while (p != null)
            {
                Console.Write(p.value + " --> ");
                p = p._next;
            }
            Console.WriteLine();
        }

}

















public class NodeList
{
    public int value;
    public NodeList _next;

    public NodeList(int v , NodeList n)
    {
        value = v;
        _next = n;
    }





}