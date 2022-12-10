using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class BinTree<T> where T : IComparable
{
    //variables
    protected Node<T> root;

    public BinTree()  //creates an empty tree
    {
        root = null;
    }
    public BinTree(Node<T> node)  //creates a tree with node as the root
    {
        root = node;
    }

    //preorder root taking in a reference to buffer
    public void PreOrder(ref string buffer)
    {
        preorder(root, ref buffer);
    }

    //inorder root taking in a reference to buffer
    public void InOrder(ref string buffer)
    {
        inorder(root, ref buffer);
    }

    //postorder root taking in a reference to buffer
    public void PostOrder(ref string buffer)
    {
        postorder(root, ref buffer);
    }

    //recurssive preorder method, taking in node tree and ref buffer
    private void preorder(Node<T> tree, ref string buffer)
    {
        //if tree is not null
        if (tree != null)
        {
            //add tree.data to the string with a comma between
            buffer += tree.Data.ToString() + ", ";

            //preorder the left side
            preorder(tree.Left, ref buffer);

            //preorder the right side
            preorder(tree.Right, ref buffer);
        }
    }

    //recurssive preorder method, taking in node tree and ref buffe
    private void inorder(Node<T> tree, ref string buffer)
    {
        //traverse the tree in order
        if (tree != null)
        {
            //inorder the right side
            inorder(tree.Left, ref buffer);

            //add tree.data to the string with a comma between
            buffer += tree.Data.ToString() + ", ";

            //inorder the right side
            inorder(tree.Right, ref buffer);
        }
    }

    //recurssive postorder method, taking in node tree and ref buffer
    private void postorder(Node<T> tree, ref string buffer)
    {
        if (tree != null)
        {
            //postorder the right side
            postorder(tree.Left, ref buffer);

            //postorder the right side
            postorder(tree.Right, ref buffer);

            //add tree.data to the string with a comma between
            buffer += tree.Data.ToString() + ", ";
        }
    }
}