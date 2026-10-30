using System;

public class Node
{
    public int Data;
    public Node Left;
    public Node Right;

    public Node(int val)
    {
        Data = val;
        Left = null;
        Right = null;
    }
}

public class BinarySearchTree
{
    public Node Root;

    public void Insert(int data)
    {
        Root = InsertRec(Root, data);
    }

    private Node InsertRec(Node root, int data)
    {
        if (root == null)
            return new Node(data);

        if (data < root.Data)
            root.Left = InsertRec(root.Left, data);
        else if (data > root.Data)
            root.Right = InsertRec(root.Right, data);

        return root;
    }

    public void InOrder(Node node)
    {
        if (node == null) return;
        InOrder(node.Left);
        Console.Write(node.Data + " ");
        InOrder(node.Right);
    }
}

public class BSTDeletion
{
    public Node DeleteNode(Node root, int key)
    {
        if (root == null) return root;


        if (key < root.Data)
            root.Left = DeleteNode(root.Left, key);
        else if (key > root.Data)
            root.Right = DeleteNode(root.Right, key);
        else
        {

            if (root.Left == null) return root.Right;
            else if (root.Right == null) return root.Left;


            root.Data = MinValue(root.Right);


            root.Right = DeleteNode(root.Right, root.Data);
        }
        return root;
    }

    private int MinValue(Node root)
    {
        int minv = root.Data;
        while (root.Left != null)
        {
            minv = root.Left.Data;
            root = root.Left;
        }
        return minv;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        BinarySearchTree bst = new BinarySearchTree();
        BSTDeletion deleter = new BSTDeletion();

        int[] valores = { 45, 23, 67, 12, 34, 56, 89 };
        foreach (int val in valores)
        {
            bst.Insert(val);
        }

        Console.WriteLine("||| ARBOL |||");
        bst.InOrder(bst.Root);
        Console.WriteLine();

        int aBorrar = 23;
        Console.WriteLine($"\nEliminando el nodo {aBorrar}.");
        bst.Root = deleter.DeleteNode(bst.Root, aBorrar);

        Console.WriteLine("||||| ARBOL DESPUES DE ELIMINAR |||||");
        bst.InOrder(bst.Root);
        Console.WriteLine();
    }
}