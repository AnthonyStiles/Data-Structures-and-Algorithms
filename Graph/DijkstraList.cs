namespace DSA.Graph;

public static class DijkstraList
{
    public static List<int> GetShortestPath(int source, int sink, List<List<GraphEdge>> graph)
    {
        List<bool> seen = Enumerable.Repeat(false, graph.Count).ToList();
        List<int> prev = Enumerable.Repeat(-1, graph.Count).ToList();
        List<int> dists = Enumerable.Repeat(int.MaxValue, graph.Count).ToList();

        dists[source] = 0;

        while(HasUnvisited(seen, dists))
        {
            int curr = GetLowestUnvisited(seen, dists);
            seen[curr] = true;

            List<GraphEdge> adjs = graph[curr];

            for (int i = 0; i < adjs.Count; i++)
            {
                GraphEdge edge = adjs[i];
                if (seen[edge.To])
                {
                    continue;
                }

                int dist = dists[curr] + edge.Weight;
                if(dist < dists[edge.To])
                {
                    dists[edge.To] = dist;
                    prev[edge.To] = curr;
                }
            }
        }

        List<int> output = [];
        int current = sink;

        while(prev[current] != -1)
        {
            output.Add(current);
            current = prev[current];
        }

        output.Add(source);
        output.Reverse();
        return output;
    }

    private static bool HasUnvisited(List<bool> seen, List<int> dists)
    {
        for(int i = 0; i < seen.Count; i++)
        {
            if (!seen[i] && dists[i] < int.MaxValue)
            {
                return true;
            }
        }
        return false;
    }

    private static int GetLowestUnvisited(List<bool> seen, List<int> dists)
    {
        int idx = -1;
        int lowestDistance = int.MaxValue;

        for (int i = 0; i < seen.Count; i++)
        {
            if (seen[i])
            {
                continue;
            }

            if(lowestDistance > dists[i])
            {
                lowestDistance = dists[i];
                idx = i;
            }
        }
        return idx;
    }
}