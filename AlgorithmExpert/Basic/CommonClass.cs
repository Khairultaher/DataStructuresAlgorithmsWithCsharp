using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmExpert.Easy
{
    public class BinaryTree
    {
        public BinaryTree(int value)
        {
            this.Value = value;
            this.Left = null;
            this.Right = null;
        }
        public int Value { get; private set; }
        public BinaryTree Left { get; set; }
        public BinaryTree Right { get; set; }
    }

    public class Level
    {

        public Level(BinaryTree root, int depth)
        {
            this.Root = root;
            this.Depth = depth;
        }
        public BinaryTree Root { get; set; }
        public int Depth { get; set; }
    }
}
