using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PopulatingNextRightPointers
{
    class PopulateNextRightPointer
    {
        public class Node
        {
            public int val;
            public Node left;
            public Node right;
            public Node next;

            public Node() { }
            public Node(int _val, Node _left, Node _right, Node _next)
            {
                val = _val;
                left = _left;
                right = _right;
                next = _next;
            }
        }
        public Node NodeConnect(Node root)
        {
            if (root != null)
            {
                NodeConnect(root.right);
                root.next = null;
                NodeConnect(root.left);
            }
            return root;
        }

            static void Main(string[] args)
        {

        }
    }
}
