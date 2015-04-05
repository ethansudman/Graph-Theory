using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace CS_Graph_Implementations
{
    /// <summary>
    /// This can be run "on its own" as a console application by making this project the starting project. This class is the entry point.
    /// </summary>
    public sealed class Program
    {
        public static void Main(string[] args)
        {
            BinarySearchTree tree = new BinarySearchTree();
            tree.Insert(10);
            tree.Insert(5);
            tree.Insert(15);
            tree.Insert(20);
            tree.Insert(30);
            tree.Insert(4);
            tree.Insert(6);

            // This can be replaced with Console.WriteLine if being run outside of the Visual Studio IDE
            Trace.TraceInformation(tree.Contains(tree.Root, 30).ToString());

            tree.BFS();

            Trace.TraceInformation("--------------------------------------------");
            Trace.TraceInformation("Inorder traversal:");
            tree.Inorder();
        }
    }
}
