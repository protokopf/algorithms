using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorythms.Solution.LeetCode
{
    public class ListNode
    {
      public int val;
      public ListNode next;
      public ListNode(int x) { val = x; }
    }

    public static class NodeSolution
    {
        public static ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode firstNode = null;
            ListNode currentNode = null;
            int diff = 0;
            while(!(l1 == null && l2 == null && diff != 1))
            {
                int sumOfTwo = (l1 != null ? l1.val : 0) + (l2 != null ? l2.val : 0) + diff;
                if(sumOfTwo >= 10)
                {
                    diff = 1;
                    sumOfTwo -= 10;
                }
                else
                {
                    diff = 0;
                }
                
                if (firstNode == null)
                {
                    firstNode = currentNode = new ListNode(sumOfTwo);
                }
                else
                {
                    ListNode newNode = new ListNode(sumOfTwo);
                    currentNode.next = newNode;
                    currentNode = newNode;
                }
                l1 = l1 != null ? l1.next : null;
                l2 = l2 != null ? l2.next : null;
            }
            return firstNode;
        }
    }

    public static class Helpers
    {
        public static ListNode CreateNodeFromArray(int[] array)
        {
            int length = array.Length;
            if(length == 0)
            {
                return new ListNode(0);
            }
            ListNode first = new ListNode(array[0]);
            ListNode current = first;
            for(int i = 1; i < length; ++i)
            {
                ListNode newNode = new ListNode(array[i]);
                current.next = newNode;
                current = newNode;
            }

            return first;
        }
    }
}
