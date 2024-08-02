using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    internal class RemoveNode
    {
      
            internal ListNode RemoveNthFromEnd(ListNode head, int n)
            {
                if (head == null)
                {
                    return null;
                }

                int length = 0;
                ListNode curr = head;
                while (curr != null)
                {
                    length++;
                    curr = curr.next;
                }

                int count = 0;
                curr = head;
                ListNode prev = null;
                while (count < length - n)
                {
                    prev = curr;
                    curr = curr.next;
                    count++;
                }

                if (prev == null)
                {
                    head = head.next;
                }
                else
                {
                    prev.next = curr.next;
                }

                return head;
           }
        

    }
}
