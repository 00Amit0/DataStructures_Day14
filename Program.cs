namespace DataStructuresDemo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Heyyy do u know what is linked list");

            LinkedList list = new LinkedList();
            list.Add(56);                               //UC1
            list.Add(30);
            list.Add(70);
            list.Display();

            list.AddFirst(70);                          //UC2
            list.AddFirst(30);
            list.AddFirst(56);
            list.Display();
        }
    }
}
