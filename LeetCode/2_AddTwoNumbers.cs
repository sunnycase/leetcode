using System;
using System.Collections.Generic;
using System.Text;
using ListNode = AddTwoNumbers_ListNode;

/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */

public class AddTwoNumbers_ListNode : IEquatable<ListNode>
{
    public int val;
    public ListNode next;
    public AddTwoNumbers_ListNode(int x) { val = x; }

    public override bool Equals(object obj)
    {
        return Equals(obj as ListNode);
    }

    public bool Equals(ListNode other)
    {
        return other != null &&
               val == other.val &&
               EqualityComparer<ListNode>.Default.Equals(next, other.next);
    }

    public override int GetHashCode()
    {
        var hashCode = -903652156;
        hashCode = hashCode * -1521134295 + val.GetHashCode();
        hashCode = hashCode * -1521134295 + EqualityComparer<ListNode>.Default.GetHashCode(next);
        return hashCode;
    }

    public static bool operator ==(ListNode node1, ListNode node2)
    {
        return EqualityComparer<ListNode>.Default.Equals(node1, node2);
    }

    public static bool operator !=(ListNode node1, ListNode node2)
    {
        return !(node1 == node2);
    }
}

public partial class Solution
{
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        ListNode root = null, cnt = null;

        void Concat(ListNode node)
        {
            if (root == null)
                root = cnt = node;
            else
            {
                cnt.next = node;
                cnt = node;
            }
        }

        int up = 0;
        while (true)
        {
            var value = up + (l1?.val ?? 0) + (l2?.val ?? 0);
            if (l1 == null && l2 == null && up == 0)
                break;
            else
            {
                up = 0;
                if (value >= 10)
                {
                    up = value / 10;
                    value %= 10;
                }

                Concat(new ListNode(value));
            }

            l1 = l1?.next;
            l2 = l2?.next;
        }

        return root;
    }
}