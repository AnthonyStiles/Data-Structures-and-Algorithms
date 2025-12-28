namespace DSA;

public static class TreeTraversal<T>
{
    public static List<T> Traverse(TreeNode<T> root)
    {
        List<T> values = new List<T>();
        Walk(root, values);
        return values;
    }

    private static void Walk(TreeNode<T> node, List<T> values)
    {
        if(node == null)
        {
            return;
        }

        values.Add(node.Value);
        Walk(node.Left, values);
        Walk(node.Right, values);
    }
}

public class TreeNode<T>
{
    public required T Value { get; set; }
    public TreeNode<T>? Left { get; set; }
    public TreeNode<T>? Right { get; set; }
}