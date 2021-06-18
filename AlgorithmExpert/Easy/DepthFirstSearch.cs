using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmExpert.Easy
{
    public class Node
    {

        public Node(string name)
        {
            this.Name = name;
            this.Children = new List<Node>();
        }

        public string Name { get; set; }
        public List<Node> Children { get; set; }

        // O(v + e) time | O(v) space
        public List<string> DepthFirstSearch(List<string> array)
        {
            array.Add(this.Name);
            for (int i = 0; i < Children.Count; i++)
            {
                Children[i].DepthFirstSearch(array);
            }
            return array;
        }
        public Node AddChild(string name)
        {
            Node child = new Node(name);
            Children.Add(child);
            return this;
        }
    }
}
