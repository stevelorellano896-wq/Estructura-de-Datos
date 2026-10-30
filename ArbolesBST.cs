using System;

public class Node
{
    public int Data;
    public Node Left;
    public Node Right;

    public Node(int value)
    {
        Data = value;
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
    public bool Search(Node root, int key)
    {
        if (root == null) return false;
        if (root.Data == key) return true;

        return key < root.Data
            ? Search(root.Left, key)
            : Search(root.Right, key);
    }
}
public class Program
{
    public static void Main(string[] args)
    {
        BinarySearchTree bst = new BinarySearchTree();

        int[] valores = { 45, 23, 67, 12, 34, 56, 89 };
        foreach (int val in valores)
        {
            bst.Insert(val);
        }

        Console.WriteLine("Arbol BST creado con exito");

        int buscar = 34;
        bool encontrado = bst.Search(bst.Root, buscar);

        if (encontrado)
            Console.WriteLine($"el numero {buscar} si esta en el arbol");
        else
            Console.WriteLine($"el número {buscar} no se encuentra en el arbol");
    }
}