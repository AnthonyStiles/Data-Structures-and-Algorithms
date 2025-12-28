namespace DSA.Tree;

public static class DepthFirstTreeTraversal<T>
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