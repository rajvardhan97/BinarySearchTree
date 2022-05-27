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
            binaryTree.Display();
        }
    }
   
}

