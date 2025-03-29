using System.Diagnostics;
using static LList;

public class DoublyLinkedList
{
    private Node head;
    private Node tail;
    private int size;
    public DoublyLinkedList()
    {
        this.head = null;
        this.tail = null;
        this.size = 0;
        
    }

    public void InsertNewNode(int val)
    {
   Node newest = new Node(val,null);

        if(size ==0)
        {
             head = newest;
            tail = newest;
            size = size +1;
        }
        else{
            tail.next = newest;
            tail = newest;
            newest.prev = head;
            size = size + 1;
        }
    }

    public bool InsertNewNodeAtGivenIndex(int value,int index)
    {
        if(size <0 || size< index) return false;

    
        Node newest = new Node(value,null);
        Node temp = head;
        Node temp2 = head;
        for(int i =1;i<index-1;i++)
        {   
            temp = temp.next;
            temp2= temp2.next;

        }
        temp2 = temp2.next;
        newest.next = temp2;
        temp2.prev = newest;
        temp.next = newest;
        newest.prev = temp;

        return true;
    }


    public void SwapFirstAndLast()
    {
        if(size < 2) return;
        // 
        int start = head.value;
        int last = tail.value;

        head.value = last;
        tail.value = start;
    }


    public void ReverseAllNodesValues()
    {
        Node temp = head;
        head   = tail;
        tail = temp;
        Node before = null;
        Node after = temp.next;
        for(int i =0;i<size;i++)
        {
            after = temp.next;
            temp.next = before;
            before = temp;
            temp = after;
        }

    }


    public bool Plaindromecheck()
    {
        Node start = head;
        Node end = tail;
        if (start.value != end.value) return false;
        for(int i =0;i<=size/2;i++)
        {
            start = start.next;
            end = end.prev.next;
            if(start.value != end.value) return false;
        }
        return true;
    }

public void DisplayAllNodes()
{Console.WriteLine($"size of Node is : {size}");

    Node start = head;
    while (start!=null)
    {
        
        Console.Write($"----->>{start.value}");
        start = start.next;
    }

    
}
















}
