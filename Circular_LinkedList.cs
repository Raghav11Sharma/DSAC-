

// public class Circular_LinkedList{
//     public Node Head;
//     public Node Tail ;
//     public int size { get; set; }=0;

//     public Circular_LinkedList()
//     {
        
//     }

//     public void addElement(int e)
//     {
//         Node newest = new Node(e,null);
//         if(isEmpty()){
//             Head = newest;
//             newest.next = newest;
//             size = size +1;
//         }
//         else{
//             //Head = newest.next;
//             Head = newest.next;
//             newest = Head;

//             size = size + 1;
//         }
//     }

//     public bool isEmpty()
//     {
//         if (size == 0)
//         {
//             return true;
//         }
//         return false;
//     }

//     public void display()
//         {
//             Node p = Head;
//             while (p != null)
//             {
//                 Console.Write(p.element + " --> ");
//                 p = p.next;
//             }
//             Console.WriteLine();
//         }
// }