using System.Security.Principal;
public class LList{

public Node head;
public Node tail;
public int size;

public LList()
{
    head = null;
    tail = null;
    size =0;
}

public void AddNewNode(int value)
{
        Node nn = new Node(value, null);
   if(size == 0)
   {
    head = nn;
    tail = nn;
        size = size +1;

   }
   else
   {
            tail.next = nn;
            tail = nn;
    size = size +1;
   }

}

public void AddNewNodeAtFirst(int v)
{
  Node firstnode = new Node(v,null);
  if(size ==0)
  {
    head = firstnode;
    tail = firstnode;
  }
  else{
    firstnode.next = head;
    head = firstnode;
    size = size +1;
  }
}

public void RemoveLast()
{
  Node start = head;
  Node temp = head;

  while (start.next != null)
  {
    start = start.next;
    if(start.next != null)
    {
    temp = temp.next;
    }
  }
  start = temp;
  start.next = null;

}


public void RemoveFirstNode()
{
  Node start = head;
  head = head.next;
  size --;

}

public void RemoveElement(int v)
{
  Node start = head;
  Node temp = head;
  Node last = tail;

  while (start.next != null)
  {
    start = start.next;
    if(start.value == v)
    {
      start.next = null;
      start.next.next = start.next.next;
    }
  }
}

public void RemoveNodeAtGivenIndex(int index)
{
  Node start = head;
  Node prev = head;
 for(int i =1;i<index-1;i++)
 {
  prev = prev.next;
 }
 start = prev.next;
 prev.next = start.next;
 size --;

}




public int SizeofNode()
{
    return size;
}

    public class Node
    {
        public int value;
        public Node? next;
        public Node? prev;

        public Node(int v,Node n)
        {
            this.value = v;
            this.next = n;
            this.prev = null;
        }
    }
   
   public int GetNodeByIndex(int index)
   {
    if(index <0 || index > size)
    {
      return 0;
    }
    Node temp = head;
    for(int i =0;i<index;i++)
    {
      temp = temp.next;
    }
    return temp.value;
   }


   public void AddNodeAtGivenindex(int v,int index)
   {
    Node nwt = new Node(v,null);
            Node start = head;
    if(size ==0)
    {
      head = nwt;
      tail = nwt;
    }
    else
    {
      int i = 1;
      while (i<index-1)
      {
        start = start.next;
        i = i+1;
      }
      nwt.next = start.next;
      start.next = nwt;
      
    }
   }


  public void ReverseLinkedList()
  {
   Node temp = head;
   head  = tail;
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




  public int FindMiddleNodevalue()
  {
    if(size == 0 )return 0;
    Node start = head;
    int middlevalue = size%2==0?(size/2):(size/2)+1;
    for(int i =0;i<middlevalue-1;i++)
    {
      start = start.next;

    }
    return start.value;
  }


//has loop means that any node is traversing or have linked to any other node apart from its immediate neighbour
  public bool HasLoopInLinkedList()
  {
    HashSet<Node> hset = new HashSet<Node>();
    Node start = head;
    for(int i =0;i<size;i++)
    {
      
      hset.Add(start);
      start = start.next;
      if(hset.Contains(start))
      {
        return true;
      }
    }
    return false;
  }


  public int DuplicatCharactersInLinkedlist()
  {
    //first approach using Hashsets::
    HashSet<int> hset = new HashSet<int>();
    Node start = head;
    int duplicatevalue=0;
    for(int i =0;i<size;i++)
    {
      hset.Add(start.value);
      start = start.next;
       if(hset.Contains(start.value))
      {
        duplicatevalue = start.value;
        return duplicatevalue;
      }
      
     
    }
    return 0;
  }




   public void Display()
   {
    Node p = head;
    while (p!=null)
    {
        Console.Write(p.value +  " ------ >>>>>");
        
        p = p.next;
    }
    Console.WriteLine("Size of Node is  "+  size);
   }

   
}