using System.Collections.Generic;
using System.Linq;
using System.Text;
using leetCode.Common;
using leetCode._133_CloneGraphSolution;
using Xunit;
using Xunit.Should;

namespace leetCode.test
{
    public class CloneGraphFacts
    {
        private readonly CloneGraphSolution solution = new CloneGraphSolution();

        [Fact]
        public void should_return_null_when_graph_is_null()
        {
            solution.CloneGraph(null).ShouldBeNull();
        }

        [Fact]
        public void should_return_1_when_graph_is_1()
        {
            var node = new UndirectedGraphNode(1);
            var result = solution.CloneGraph(node);
            VerifyGraph(result, "1#");
        }

        [Fact]
        public void should_return_result_for_graph_is_12_2()
        {
//            1 ----- 2
            var node = new UndirectedGraphNode(1)
            {
                neighbors = new List<UndirectedGraphNode>
                {
                    new UndirectedGraphNode(2)
                }
            };
            var result = solution.CloneGraph(node);
            VerifyGraph(result, "1, 2#2#");
        }

        [Fact]
        public void should_return_result_for_graph_123_23_3()
        {
//            1 ----- 2
//             \     /
//              \   /
//               \ /
//                3
            var node1 = new UndirectedGraphNode(1);
            var node2 = new UndirectedGraphNode(2);
            var node3 = new UndirectedGraphNode(3);
            node1.neighbors = new List<UndirectedGraphNode> {node2, node3};
            node2.neighbors = new List<UndirectedGraphNode> {node3};

            var result = solution.CloneGraph(node1);
            VerifyGraph(result, "1, 2, 3#2, 3#3#");
        }

        [Fact]
        public void should_return_result_for_graph_11()
        {
//            1
//            /\
//            \/
            var node1 = new UndirectedGraphNode(1);
            node1.neighbors = new List<UndirectedGraphNode> {node1};

            var result = solution.CloneGraph(node1);
            VerifyGraph(result, "1, 1#");
        }

        [Fact]
        public void should_return_result_for_graph_123_23_33()
        {
//            1 ----- 2
//             \     /
//              \   /
//               \ /
//                3
//                /\
//                \/
            var node1 = new UndirectedGraphNode(1);
            var node2 = new UndirectedGraphNode(2);
            var node3 = new UndirectedGraphNode(3);
            node1.neighbors = new List<UndirectedGraphNode> {node2, node3};
            node2.neighbors = new List<UndirectedGraphNode> {node3};
            node3.neighbors = new List<UndirectedGraphNode> {node3};

            var result = solution.CloneGraph(node1);
            VerifyGraph(result, "1, 2, 3#2, 3#3, 3#");
        }

        private static void VerifyGraph(UndirectedGraphNode result, string expectedResult)
        {
            TransferResultToString(result).ShouldBe(expectedResult);
        }

        private static string TransferResultToString(UndirectedGraphNode node)
        {
            var set = new HashSet<int>();
            var nodeQ = new Queue<UndirectedGraphNode>();
            var resultStr = new StringBuilder();

            nodeQ.Enqueue(node);
            nodeQ.Enqueue(null);

            while (nodeQ.Count != 0)
            {
                var layer = new Queue<UndirectedGraphNode>();

                var tmpNode = nodeQ.Dequeue();
                while (tmpNode != null)
                {
                    layer.Enqueue(tmpNode);
                    tmpNode = nodeQ.Dequeue();
                }
                layer.Enqueue(null);

                while (layer.Count != 0)
                {
                    var layerNode = layer.Dequeue();

                    if (layerNode != null && !set.Contains(layerNode.label))
                    {
                        resultStr.Append(string.Format("{0}, ", layerNode.label));
                        set.Add(layerNode.label);

                        if (layerNode.neighbors.Count != 0)
                        {
                            layerNode.neighbors.ToList().ForEach(n =>
                            {
                                resultStr.Append(string.Format("{0}, ", n.label));
                                nodeQ.Enqueue(n);
                            });
                            nodeQ.Enqueue(null);
                        }

                        resultStr.Remove(resultStr.Length - 2, 2).Append("#");
                    }
                }
            }

            return resultStr.ToString();
        }
    }
}
