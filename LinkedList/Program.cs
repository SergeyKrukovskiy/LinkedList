using System;

namespace LinkedList
{
    class Program
    {
        static void Main()
        {
            int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            SinglyLinkedListWithTail singlyLinkedListWithTail = new SinglyLinkedListWithTail();

            singlyLinkedListWithTail.PushBackRange(arr);
            Console.WriteLine(singlyLinkedListWithTail.Print());
            singlyLinkedListWithTail.Reverse();
            Console.WriteLine(singlyLinkedListWithTail.Print());
        }
    }
}
