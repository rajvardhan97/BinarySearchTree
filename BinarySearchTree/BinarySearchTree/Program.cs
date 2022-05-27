using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class Program
    {
        public static void Main(string[] args)
        {
            BinaryTree<int> binaryTree = new BinaryTree<int>(56);

            binaryTree.Insert(30);
            binaryTree.Insert(70);
            binaryTree.Insert(22);
            binaryTree.Insert(40);
            binaryTree.Insert(60);
            binaryTree.Insert(95);
            binaryTree.Insert(11);
            binaryTree.Insert(65);
            binaryTree.Insert(3);
            binaryTree.Insert(16);
            binaryTree.Insert(63);
            binaryTree.Insert(67);
            binaryTree.Display();
            binaryTree.Size();
            bool Find = binaryTree.Search(63, binaryTree);
            if (Find == true)
                Console.WriteLine("The element 63 is found in Binary Search Tree");
            else
                Console.WriteLine("The element 63 is not found in Binary Search Tree");
        }
    }
   
}

