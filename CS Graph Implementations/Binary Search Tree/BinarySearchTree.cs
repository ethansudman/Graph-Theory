using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace CS_Graph_Implementations
{
    public class BinarySearchTree
    {
        public BSTNode Root { get; set; }

        public void Insert(int value)
        {
            if (Root == null)
                Root = new BSTNode(value);
            else
                InsertNode(Root, new BSTNode(value));
        }

        private void InsertNode(BSTNode curr, BSTNode value)
        {
            if (value.Root < curr.Root)
            {
                if (curr.Left == null)
                {
                    curr.Left = value;
                    Trace.TraceInformation("Chose left, base case");
                }
                else
                {
                    Trace.TraceInformation("Chose right");
                    InsertNode(curr.Left, value);
                }
            }
            else
            {
                if (curr.Right == null)
                    curr.Right = value;
                else
                    InsertNode(curr.Right, value);
            }
        }

        public bool MyContains(BSTNode root, int value)
        {
            if (root.Root == value)
                return true;
            else if (value < root.Root)
                return MyContains(root.Left, value);
            else
                return MyContains(root.Right, value);
        }

        public void DFS()
        {
            DFS(Root);
        }

        private void DFS(BSTNode root)
        {
            Trace.TraceInformation("-----------------------------------------------------");
            var queue = new Queue<BSTNode>();

            while (true)
            {
                Trace.TraceInformation(root.Root.ToString());

                if (root.Left != null)
                    queue.Enqueue(root.Left);

                if (root.Right != null)
                    queue.Enqueue(root.Right);

                if (queue.Any())
                    root = queue.Dequeue();
                else break;
            }

            Trace.TraceInformation("-----------------------------------------------------");
        }
    }
}
