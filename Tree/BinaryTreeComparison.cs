namespace DSA.Tree;

public static class BinaryTreeComparison<T>
{
    public static bool Compare(TreeNode<T> a, TreeNode<T> b)
    {
        if(a == null && b == null)
        {
            return true;
        }

        if(a == null || b == null)
        {
            return false;
        }

        if(!a.Value.Equals(b.Value))
        {
            return false;
        }

        return Compare(a.Left, b.Left) && Compare(a.Right, b.Right);
    }
}