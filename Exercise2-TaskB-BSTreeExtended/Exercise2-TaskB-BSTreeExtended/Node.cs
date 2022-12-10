using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Node<T> where T : IComparable
{
    //variables
    public T data; //generic data
    public Node<T> Left, Right; //left and right node

    //constructor, generic parameter item
    public Node(T item)
    {
        data = item; //set data to item

        //set left and right to null
        Left = null;
        Right = null;
    }

    //getter and setter for data
    public T Data
    {
        set { data = value; }
        get { return data; }
    }
}
