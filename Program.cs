using System;

namespace LinkedList
{
   
    class Program
    {
        static void PrintList(ListNode head)
        {
            while (head != null)
            {
                Console.Write(head.val + " -> ");
                head = head.next;
            }
            Console.WriteLine("NULL");
        }

        static ListNode CreateLinkedList()
        {
            ListNode head = null;
            ListNode tail = null;

            Console.WriteLine("Enter the values for the linked list (enter -1 to end input): ");
            while (true)
            {
                int value = int.Parse(Console.ReadLine());
                if (value == -1) break;

                ListNode newNode = new ListNode(value);
                if (head == null)
                {
                    head = newNode;
                    tail = head;
                }
                else
                {
                    tail.next = newNode;
                    tail = tail.next;
                }
            }
            return head;
        }

        static void Main()
        {
            ListNode head = CreateLinkedList();

            Console.WriteLine("Enter the position n to remove from the end: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Original List: ");
            PrintList(head);

            RemoveNode solution = new RemoveNode();
            head = solution.RemoveNthFromEnd(head, n);

            Console.WriteLine("Modified List after removing {0}th node from the end: ", n);
            PrintList(head);
        }
    }
}