using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class LinkNode
    {
        public LinkNode left = null;
        public LinkNode right = null;
        public int value = -1;

        public LinkNode(int value = -1)
        {
            this.value = value;
        }
    }

    public class MyLinkedList
    {
        public LinkNode head;
        public int size = 0;

        public MyLinkedList()
        {
        }

        public void PrintNodes() 
        {
            LinkNode node = this.head;
            Console.Write($"[start] -> ");

            while (node != null)
            {
                Console.Write($"{node.value} -> ");
                node = node.right;
            }

            Console.Write($"[end] size {this.size}");
        }

        private LinkNode GetNodeAtIndex(int index)
        {
            if (index < 0) return null;

            if (this.head == null) return null;

            LinkNode lastnode = head;

            if (index == 0) return this.head;

            for (int i = 1; i <= index; i++)
            {
                lastnode = lastnode.right;

                if (lastnode == null) return null;
            }

            return lastnode;
        }

        public int Get(int index)
        {
            LinkNode mynode = this.GetNodeAtIndex(index);

            if (mynode == null) return -1;

            return mynode.value;
        }

        public void AddAtHead(int val)
        {
            LinkNode newheadnode = new LinkNode(val);

            newheadnode.right = this.head;

            this.head = newheadnode;

            size++;
        }

        public void AddAtTail(int val)
        {
            if (this.head == null)
            {
                this.head = new LinkNode(val);

                size++;

                return;
            }

            LinkNode currnode = head;
            LinkNode lastnode;

            while (currnode != null)
            {
                lastnode = currnode;
                currnode = lastnode.right;

                if (currnode == null)
                {
                    lastnode.right = new LinkNode(val);
                    size++;
                    return;
                }
            }
        }

        public void AddAtIndex(int index, int val)
        {
            if (index > size) return;

            if (index == size) 
            {
                this.AddAtTail(val);

                return;
            }

            LinkNode mynode = this.GetNodeAtIndex(index);
            LinkNode prevnode = this.GetNodeAtIndex(index - 1);

            LinkNode newinsertednode = new LinkNode(val);
            newinsertednode.right = mynode;            

            if (prevnode == null)
            {
                newinsertednode.right = this.head;
                this.head = newinsertednode;

                size++;

                return;
            }

            prevnode.right = newinsertednode;

            size++;
        }

        public void DeleteAtIndex(int index)
        {
            LinkNode mynode = this.GetNodeAtIndex(index);

            if (mynode == null) return;

            LinkNode nextnode = mynode.right;

            LinkNode prevnode = this.GetNodeAtIndex(index - 1);

            if (prevnode == null)
            {
                this.head = nextnode;
                return;
            }

            prevnode.right = nextnode;

            size--;
        }
    }
}
