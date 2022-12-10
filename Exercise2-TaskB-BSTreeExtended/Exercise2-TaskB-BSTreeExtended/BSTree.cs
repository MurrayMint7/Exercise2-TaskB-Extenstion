using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class BSTree<T> : BinTree<T> where T : IComparable

{  //root declared as protected in Parent Class – Binary Tree
    public BSTree()
    {
        root = null;
    }

    //method to insert an item into the tree
    public void InsertItem(T item)
    {
        insertItem(item, ref root); //insert item into root. ref is used so that root is changed at the source
    }

    //return the max level of the tree
    public int Height()
    {
        return height(root); //find height of root
    }

    //return the number of nodes in the tree
    public int Count()
    {
        return Count(root); //find count of root
    }

    //return true if the item is contained in the BSTree, false otherwise.
    public Boolean Contains(T item)
    {
        return Contains(root, item); //find item in root
    }

    //insert item method, takes in generic item and reference to the tree so it can be changed
    private void insertItem(T item, ref Node<T> tree)
    {
        //if there is no tree, make the ite to new root
        if (tree == null)
        {
            tree = new Node<T>(item);

        }

        //if item precedes tree.data in the sort order
        else if (item.CompareTo(tree.Data) < 0)
        {
            //insert it into the left of the tree
            insertItem(item, ref tree.Left); //recurssive method to keep going as far down the tree as possible
        }

        //if item follow tree.data in the sort order
        else if (item.CompareTo(tree.Data) > 0)
        {
            //insert it into the right of the tree
            insertItem(item, ref tree.Right);  //recurssive method to keep going as far down the tree as possible
        }
    }

    //method to find the height of a tree
    private int height(Node<T> tree)
    {
        //if there is no tree
        if (tree == null)
        {
            return -1; //height is -1
        }

        //find height of the left side of the tree
        int leftHeight = height(tree.Left);

        //find height of the right side of the tree
        int rightHeight = height(tree.Right);

        //if left height is the max height
        if (leftHeight > rightHeight)
        {
            return leftHeight + 1;
        }
        else //if left height is the max height
        {
            return rightHeight + 1;
        } //+1 as root on its own as null tree is -1 and root is 0
    }

    //method to find the count of a tree
    private int Count(Node<T> tree)
    {
        //if theres nothing in the tree
        if (tree == null)
        {
            return 0; //return nothing
        }

        return 1 + Count(tree.Left) + Count(tree.Right); //return count of left and right plus root
    }

    //method to find out if a generic item is contained in the tree
    private bool Contains(Node<T> tree, T item)
    {
        //if theres nothing in the tree
        if (tree == null)
        {
            return false;
        }

        //if the item matches the data its being compared to
        if (tree.Data.CompareTo(item) == 0)
        {
            return true;
        }

        //if the item precedes the data in the sort order
        if (item.CompareTo(tree.Data) < 0)
        {
            return Contains(tree.Left, item); //go through the left side
        }

        //if the item follows the data in the sort order
        if (item.CompareTo(tree.Data) > 0)
        {
            return Contains(tree.Right, item); //go through the right side
        }

        //otherwise
        return false;
    }
}

