using System;
using Xunit;
using ListNode = AddTwoNumbers_ListNode;

namespace LeetCode.Test
{
    public class AddTwoNumbersTest
    {
        [Fact]
        public void Test1()
        {
            var list1 = new ListNode(2)
            {
                next = new ListNode(4)
                {
                    next = new ListNode(3)
                }
            };

            var list2 = new ListNode(5)
            {
                next = new ListNode(6)
                {
                    next = new ListNode(4)
                }
            };

            var output = new ListNode(7)
            {
                next = new ListNode(0)
                {
                    next = new ListNode(8)
                }
            };

            Assert.Equal(output, new Solution().AddTwoNumbers(list1, list2));
        }

        [Fact]
        public void Test2()
        {
            var list1 = new ListNode(5);

            var list2 = new ListNode(5);

            var output = new ListNode(0)
            {
                next = new ListNode(1)
            };

            Assert.Equal(output, new Solution().AddTwoNumbers(list1, list2));
        }

        [Fact]
        public void Test3()
        {
            var list1 = new ListNode(0);

            var list2 = new ListNode(0);

            var output = new ListNode(0);

            Assert.Equal(output, new Solution().AddTwoNumbers(list1, list2));
        }
    }
}
