using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Threading.Tasks;
using BenchmarkDotNet.Engines;

namespace ForCodingChallenges.LeetCode
{
    public class LeetCode_LinkedList
    {
        /*** Definition for singly-linked list.*/
        public class ListNode 
        {
            public int val;
            public ListNode next;
            public ListNode(int val=0, ListNode next=null) {
                this.val = val;
                this.next = next;
             }
        }


       private string getStringFromNode ( ListNode node)
        {
            string NodeToString = "";
            while( node is not null)
            {
                NodeToString += node.val;
                node = node.next;
            }
            return NodeToString;

        }


        //2. Add Two Numbers
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            string firstNode = getStringFromNode(l1);
            string secondNode = getStringFromNode(l2);            
            char[] reverse1 = firstNode.ToArray();
            char[] reverse2 = secondNode.ToArray();            
            Array.Reverse(reverse1);
            Array.Reverse(reverse2);  
            BigInteger a= BigInteger.Parse(new string(reverse1));
            BigInteger b= BigInteger.Parse(new string(reverse2));
            BigInteger total =a+b;
            char[] ctotal =  total.ToString().ToArray();
            Array.Reverse(ctotal);               
            ListNode result = new ListNode(int.Parse(ctotal[0].ToString()));
            ListNode child = result;
            for ( int i=1; i< ctotal.Length; i++)
            {
               ListNode tempNode = new ListNode(int.Parse(ctotal[i].ToString()));
               child.next = tempNode;
               child = tempNode;
            }
            return result;
        }
    }
}