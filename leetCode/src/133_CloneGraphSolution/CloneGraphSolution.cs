using System.Collections.Generic;
using System.Linq;
using leetCode.Common;

namespace leetCode._133_CloneGraphSolution
{
    internal class CloneGraphSolution
    {
        public Dictionary<UndirectedGraphNode, UndirectedGraphNode> Mapping = 
            new Dictionary<UndirectedGraphNode, UndirectedGraphNode>(); 

        public UndirectedGraphNode CloneGraph(UndirectedGraphNode undirectedGraphNode)
        {
            if(undirectedGraphNode == null) return null;

            var copyedNode = new UndirectedGraphNode(undirectedGraphNode.label);
            undirectedGraphNode.neighbors.ToList().ForEach(n =>
            {
                if (n == undirectedGraphNode)
                {
                    copyedNode.neighbors.Add(copyedNode);
                }
                else if (Mapping.ContainsKey(n))
                {
                    copyedNode.neighbors.Add(Mapping[n]);
                }
                else
                {
                    var node = CloneGraph(n);
                    Mapping.Add(n, node);
                    copyedNode.neighbors.Add(node);
                }
            });

            return copyedNode;

//            var clonedNode = new UndirectedGraphNode(undirectedGraphNode.label);
//            
//            var neighborsQ = new Queue<UndirectedGraphNode>();
//            neighborsQ.Enqueue(undirectedGraphNode);
//            neighborsQ.Enqueue(null);
//
//            while (neighborsQ.Count != 0)
//            {
//                var layer = new Queue<UndirectedGraphNode>();
//
//                var tmpNode = neighborsQ.Dequeue();
//                while (tmpNode != null)
//                {
//                    layer.Enqueue(tmpNode);
//                    tmpNode = neighborsQ.Dequeue();
//                }
//
//                while (layer.Count != 0)
//                {
//                    
//                }
//            }
        }
    }
}