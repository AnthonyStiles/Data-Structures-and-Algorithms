namespace DSA.Graph;

public static class DepthFirstSearchAdjacancyList
{
    private static bool Walk(List<List<GraphEdge>> graph, int current, int needle, List<bool> seen, List<int> path)
    {
        if (seen[current])
        {
            return false;
        }

        seen[current] = true;

        path.Add(current);

                if(current == needle)
        {
            return true;
        }

        List<GraphEdge> edges = graph[current];
        for(int i = 0; i < edges.Count; i++)
        {
            GraphEdge edge = edges[i];

            if(Walk(graph, edge.To, needle, seen, path))
            {
                return true;
            }
        }

        path.RemoveAt(path.Count - 1);

        return false;
    }

    public static List<int> Search(List<List<GraphEdge>> graph, int source, int needle)
    {
        List<bool> seen = Enumerable.Repeat(false, graph.Count).ToList();
        List<int> path = [];

        Walk(graph, source, needle, seen, path);

        return path;
    }
}