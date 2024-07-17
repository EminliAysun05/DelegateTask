namespace DelegateTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
           CustomList<int> list = new CustomList<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            int foundItem = list.Find(x => x == 3);
            Console.WriteLine($"Found item: {foundItem}");

            CustomList<int> evenNumbers = list.FindAll(x => x % 2 == 0);
            Console.WriteLine("Even numbers:");
           Console.WriteLine( evenNumbers );

            bool removed = list.Remove(2);
            Console.WriteLine($"Is '2' removed?: {removed}");

            Console.WriteLine("List after removal:");
          //  PrintList(list);




        }
    }
}
