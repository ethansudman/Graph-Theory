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
        public BSTNode Root { get; private set; }

        public BinarySearchTree() { }

        public BinarySearchTree(int root)
        {
            this.Root = new BSTNode(root);
        }

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

        public bool Contains(BSTNode root, int value)
        {
            if (root.Root == value)
                return true;
            else if (value < root.Root)
                return Contains(root.Left, value);
            else
                return Contains(root.Right, value);
        }

        #region Inorder
        public void Inorder()
        {
            Inorder(Root);
        }

        private void Inorder(BSTNode curr)
        {
            if (curr != null)
            {
                Inorder(curr.Left);
                Trace.TraceInformation(curr.Root.ToString());
                Inorder(curr.Right);
            }
        }
        #endregion

        #region Preorder
        /// <summary>
        /// Preorder tree traversal
        /// </summary>
        /// 
        /// <remarks>
        /// This is the public version so that there's a "clean" method signature for external callers.
        /// </remarks>
        public void Preorder()
        {
            Preorder(Root);
        }

        /// <summary>
        /// Preorder tree traversal
        /// </summary>
        /// <param name="curr">Current node. Used for the recursive call.</param>
        private void Preorder(BSTNode curr)
        {
            if (curr != null)
            {
                Trace.TraceInformation(curr.Root.ToString());
                Preorder(curr.Left);
                Preorder(curr.Right);
            }
        }
        #endregion

        public void BFS()
        {
            DFS(Root);
        }

        private void DFS(BSTNode curr)
        {
            Trace.TraceInformation("-----------------------------------------------------");
            var queue = new Queue<BSTNode>();

            while (true)
            {
                Trace.TraceInformation(curr.Root.ToString());

                if (curr.Left != null)
                    queue.Enqueue(curr.Left);

                if (curr.Right != null)
                    queue.Enqueue(curr.Right);

                if (queue.Any())
                    curr = queue.Dequeue();
                else break;
            }

            Trace.TraceInformation("-----------------------------------------------------");
        }
    }
}
