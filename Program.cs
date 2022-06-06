namespace DataStructuresDemo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Heyyy do u know what is linked list");

            //LinkedList list = new LinkedList();
            //list.AddLast(56);                               //UC1
            //list.AddLast(30);
            //list.AddLast(70);
            //list.Display();

            //list.AddFirst(70);                          //UC2
            //list.AddFirst(30);
            //list.AddFirst(56);
            //list.Display();

            //list.Append(56);                              //UC3
            //list.Append(30);
            //list.Append(70);
            //list.Display();

            //LinkedList list = new LinkedList();             //UC4
            //list.Append(56);
            //list.Append(70);
            //list.Display();
            //list.InsertAtPosition(3, 30);
            //list.Display();
            //list.DeleteFirst();                             //UC5
            //list.Display();
            //list.DeleteLast();                             //UC6
            //list.Display();
            //list.SearchNode(30);                           //UC7
            //list.InsertAfter(15, 30);                      //UC8
            //list.Display();
            //list.Size();                                   //UC9

            SortedLinkedList<int> sortedLinkedList = new SortedLinkedList<int>();
            sortedLinkedList.Add(new SortedNode<int>(70));
            sortedLinkedList.Add(new SortedNode<int>(40));
            sortedLinkedList.Add(new SortedNode<int>(30));
            sortedLinkedList.Add(new SortedNode<int>(56));
            Console.WriteLine("LinkedList before sorting");
            sortedLinkedList.Display();
            sortedLinkedList.SortedList();
            Console.WriteLine("LinkedList after sorting");
            sortedLinkedList.Display();
        }
    }
}
