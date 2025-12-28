using System.Collections;
using DSA;
using DSA.Tree;


int[] array = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];
Console.WriteLine(string.Join(",", array));
Console.WriteLine();

Console.WriteLine("Linear Search:");
Console.WriteLine($"5 exists in array: {LinearSearch.Run(array, 5)}");
Console.WriteLine($"11 exists in array: {LinearSearch.Run(array, 11)}");
Console.WriteLine();

Console.WriteLine("Binary Search:");
Console.WriteLine($"2 Exists in array: {BinarySearch.Run(array, 2)}");
Console.WriteLine($"6 Exists in array: {BinarySearch.Run(array, 6)}");
Console.WriteLine($"11 Exists in array: {BinarySearch.Run(array, 11)}");
Console.WriteLine();

int[] sequantialArray = [0, 0, 0, 0, 1, 1];
Console.WriteLine(string.Join(",", sequantialArray));
Console.WriteLine("Jump Search:");
Console.WriteLine($"1 Starts at index: {JumpSearch.Run(sequantialArray)}");
Console.WriteLine();

int[] unorderedArray = [5, 9, 3, 5, 1, 6, 10];
Console.WriteLine(string.Join(",", unorderedArray));
Console.WriteLine("Bouble Sort:");
Console.WriteLine($"Sorted array: {string.Join(",", BoubleSort.Run(unorderedArray))}");
Console.WriteLine();

Console.WriteLine("Queue:");
DSA.Queue<int> _IntQueue = new();
Console.WriteLine($"Peek empty queue {_IntQueue.Peek()}");
_IntQueue.Enqueue(1);
_IntQueue.Enqueue(2);
_IntQueue.Enqueue(3);
Console.WriteLine($"Deque after queuing: {_IntQueue.Deque()}");
Console.WriteLine($"Deque after queuing: {_IntQueue.Deque()}");
Console.WriteLine($"Deque after queuing: {_IntQueue.Deque()}");
Console.WriteLine($"Deque after queuing: {_IntQueue.Deque()}");
Console.WriteLine();

Console.WriteLine("Stack:");
DSA.Stack<int> _Stack = new();
Console.WriteLine($"Peek empty stack {_Stack.Peek()}");
_Stack.Push(1);
_Stack.Push(2);
_Stack.Push(3);
Console.WriteLine($"Pop after pushing {_Stack.Pop()}");
Console.WriteLine($"Pop after pushing {_Stack.Pop()}");
Console.WriteLine($"Pop after pushing {_Stack.Pop()}");
Console.WriteLine($"Pop after pushing {_Stack.Pop()}");
Console.WriteLine();

Console.WriteLine("Quick Sort:");
int[] quickSortArray = [ 1, 5, 2, 8, 4, 9, 10 ];
Console.WriteLine($"Unsorted array {string.Join(",", quickSortArray)}");
QuickSort.Run(quickSortArray, 0, quickSortArray.Length - 1);
Console.WriteLine($"Sorted array {string.Join(",", quickSortArray)}");
Console.WriteLine();

Console.WriteLine("Tree Traversal:");
TreeNode<int> levelTwoRight = new TreeNode<int>(){ Value = 38};
TreeNode<int> levelTwoLeft = new TreeNode<int>(){ Value = 57};
TreeNode<int> levelOneRight = new TreeNode<int>(){ Value = 11};
TreeNode<int> levelOneLeft = new TreeNode<int>(){ Value = 10, Left = levelTwoLeft, Right = levelTwoRight};
TreeNode<int> root = new TreeNode<int>(){ Value = 5, Left = levelOneLeft, Right = levelOneRight};
Console.WriteLine(string.Join(",", DepthFirstTreeTraversal<int>.Traverse(root)));
Console.WriteLine();

Console.WriteLine("Tree Search:");
Console.WriteLine(BreadthFirstTreeSearch<int>.Find(38, root));
Console.WriteLine();

Console.WriteLine("Tree Compare");
TreeNode<int> levelTwoRightb = new TreeNode<int>(){ Value = 38};
TreeNode<int> levelTwoLeftb = new TreeNode<int>(){ Value = 57};
TreeNode<int> levelOneRightb = new TreeNode<int>(){ Value = 11};
TreeNode<int> levelOneLeftb = new TreeNode<int>(){ Value = 10, Left = levelTwoLeftb, Right = levelTwoRightb};
TreeNode<int> rootb = new TreeNode<int>(){ Value = 5, Left = levelOneLeftb, Right = levelOneRightb};
Console.WriteLine(BinaryTreeComparison<int>.Compare(root, rootb));
levelOneLeftb.Left = null;
Console.WriteLine(BinaryTreeComparison<int>.Compare(root, rootb));