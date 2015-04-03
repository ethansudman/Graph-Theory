using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Graph_Implementations
{
    public class BSTNode
    {
        public int Root { get; set; }

        public BSTNode Left { get; set; }

        public BSTNode Right { get; set; }

        public BSTNode(int root)
        {
            this.Root = root;
            Left = null;
            Right = null;
        }
    }
}
