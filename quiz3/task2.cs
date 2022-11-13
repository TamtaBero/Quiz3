using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace quiz3
{
    internal class task2
    {
        class MyQueue
        {
            class Node
            {
                public object val { get; set; }
                public Node prev { get; set; }

                public Node(object val)
                {
                    this.val = val;
                    this.prev = null;
                }

                public Node(object val, Node prev)
                {
                    this.val = val;
                    this.prev = prev;
                }
            }

            Node head { get; set; }
            Node tail { get; set; }

            bool isEmpty { get
                {
                    return head == null;
                } }

            int Count
            {
                get
                {
                    if (isEmpty) return 0;
                    int counter = 1;
                    Node curr = head;
                    do
                    {
                        counter++;
                        curr = curr.prev;
                    } while (curr.prev != null);

                    return counter;
                }
            }

            public void addValue(object val)
            {
                if (head == null)
                {
                    head = new Node(val);
                    tail = new Node(val);
                }
                else
                {
                    Node newNode = new Node(val);
                    tail.prev = newNode;
                    tail = newNode;
                }
            }

            public object popValue()
            {
                object returnVal = head.val;
                head = head.prev;
                if (head == null)
                {
                    tail = null;
                }

                return returnVal;
            }
        }
    }
}
