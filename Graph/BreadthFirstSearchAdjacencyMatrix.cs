namespace DSA.Graph;

public static class BreadthFirstSearchAdjacencyMatrix
{
    public static List<int> Search(List<List<int>> graph, int source, int needle)
    {
        bool[] seen = Enumerable.Repeat(false, graph.Count).ToArray();
        int[] previous = Enumerable.Repeat(-1, graph.Count).ToArray();

        seen[source] = true;

        System.Collections.Generic.Queue<int> queue = new();
        queue.Enqueue(source);

        do
        {
            int curr = queue.Dequeue();
            if(curr == needle)
            {
                break;
            }

            List<int> adjacencies = graph[curr];

            for (int i = 0; i < adjacencies.Count; i++)
            {
                if(adjacencies[i] == 0)
                {
                    continue;
                }

                if (seen[i])
                {
                    continue;
                }

                seen[i] = true;
                previous[i] = curr;
                queue.Enqueue(i);
            }
        }
        while (queue.Count > 0);

        int current = needle;
        List<int> output = [];

        while(previous[current] != -1)
        {
            output.Add(current);
            current = previous[current];
        }

        if(output.Count > 0)
        {
            output.Reverse();
            return output.Prepend(source).ToList();
        }

        return [];
    }
}