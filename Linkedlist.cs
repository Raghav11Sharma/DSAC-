
// public class Node
//     {
//         public int element;
//         public Node next;
//         public Node(int e, Node n)
//         {
//             element = e;
//             next = n;
//         }

    
// }

// public class Linkedlist{
//      private Node head;
//         private Node tail;
//         private int size;

//         public Linkedlist()
//         {
//             head = null;
//             tail = null;
//             size = 0;
//         }

//         public int length()
//         {
//             return size;
//         }

//         public bool isEmpty()
//         {
//             return size == 0;
//         }

//         public void addLast(int e)
//         {
//             Node newest = new Node(e, null);
//             if (isEmpty())
//                 head = newest;
//             else
//             tail.next = newest;
//             tail = newest;
//             size = size + 1;
//         }

//         public void addAnyPosition(int e,int position)
//         {
//             Node newest = new Node(e,null);
//             Node start = head;
//             int i=1;
//             while(i<position-1)
//             {
//                 start = start.next;
//                 i=i+1;
//             }
//             newest.next = start.next;
//             start.next= newest; 

//         }

//         public int deleteAnyPosition(int pos)
//         {
//             if (pos>=size)
//             {
//                 Console.WriteLine("Position is invalid");
//             }
//             Node start = head;
//             int i=1;
//             while(i<pos-1)
//             {
//                 start= start.next;
//                 i=i+1;
//             }
//             int e = start.next.element;
//             start.next = start.next.next;
//             size = size -1;

//             return e;        }

//         public void display()
//         {
//             Node p = head;
//             while (p != null)
//             {
//                 Console.Write(p.element + " --> ");
//                 p = p.next;
//             }
//             Console.WriteLine();
//         }

// }