using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    internal class BinaryTree<T> where T : IComparable<T>
    {
        public T NodeData { get; set; }
        public BinaryTree<T> LeftNode { get; set; }
        public BinaryTree<T> RightNode { get; set; }
        int count = 0;

        public BinaryTree(T nodeData)
        {
            this.NodeData = nodeData;
            this.LeftNode = null;
            this.RightNode = null;
        }

        public void Insert(T item)
        {
            T currentNodeValue = this.NodeData;
            if ((currentNodeValue.CompareTo(item)) > 0)
            {
                count++;
                if (this.LeftNode == null)
                    this.LeftNode = new BinaryTree<T>(item);
                else
                    this.LeftNode.Insert(item);
            }
            else
            {
                count++;
                if (this.RightNode == null)
                    this.RightNode = new BinaryTree<T>(item);
                else
                    this.RightNode.Insert(item);
            }
        }

        public void Display()
        {
            if (this.LeftNode != null)
            {
                this.LeftNode.Display();
            }
            Console.WriteLine(this.NodeData.ToString());
            if (this.RightNode != null)
            {
                this.RightNode.Display();
            }
        }
        public void Size()
        {
            Console.WriteLine("\nSize of Binary Search Tree is " + (count + 1));
        }
    }
}
