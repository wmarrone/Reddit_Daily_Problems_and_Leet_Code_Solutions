﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    class BinaryTree
    {
        public Node root;
        public Node returnRoot()
        {
            return root;
        }
        public class Node
        {
            public Node left, right;
            public int val;

            public Node(int input)
            {
                this.val = input;
            }
        }

        public void AddNodePrototype(int value)
        {
            Node newNode = new Node(value);
            if (root == null) { root = newNode; }
            else
            {
                Node current = root;
                Node parent;
                while (true)
                {
                    parent = current;
                    if (value < current.val)
                    {
                        current = current.left;
                        if(current == null)
                        {
                            parent.left = newNode;
                            return;
                        }
                    }
                    else if(value > current.val)
                    {
                        current = current.right;
                        if(current == null)
                        {
                            parent.right = newNode;
                            return;
                        }
                    }
                }
            }
        }
        public void AddNode(int value)
        {
            Node newNode = new Node(value);
            if (root == null) { root = newNode; }
            else {
                Node current = root;
                Node parent;
                while (true)
                {
                    parent = current; 
                    if(value < current.val)
                    {
                        current = current.left;
                        if(current == null)
                        {
                            parent.left = newNode;
                            return;
                        }
                    }
                    else
                    {
                        current = current.right;
                        if(current == null)
                        {
                            parent.right = newNode;
                            return;
                        }
                    }
                }
            }
        }

        public BinaryTree()
        {
            root = null;
        }

        public void InOrderTraversal(Node root)
        {
            if (root != null)
            {
                InOrderTraversal(root.left);
                Console.Write(root.val);
                InOrderTraversal(root.right);
            }            
        }
        public void PreOrderTraversal(Node root)
        {
            if(root != null)
            {
                Console.Write(root.val);
                PreOrderTraversal(root.left);
                PreOrderTraversal(root.right);
            }
        }
        public void PostOrderTraversal(Node root)
        {
            if (root != null)
            {
                PreOrderTraversal(root.left);
                PreOrderTraversal(root.right);
                Console.Write(root.val);

            }
        }

        static void Main()
        {
            BinaryTree bt = new BinaryTree();

            bt.AddNodePrototype(7);
            bt.AddNodePrototype(6);
            bt.AddNodePrototype(5);
            bt.AddNodePrototype(4);
            bt.AddNodePrototype(3);
            bt.AddNodePrototype(2);
            bt.AddNodePrototype(1);

            bt.InOrderTraversal(bt.returnRoot());
            Console.WriteLine();
            bt.PreOrderTraversal(bt.returnRoot());
            Console.WriteLine();
            bt.PostOrderTraversal(bt.returnRoot());
            Console.ReadKey();
        }
    }
}
