// See https://aka.ms/new-console-template for more information
using System.Runtime.CompilerServices;

//variables
string buffer = " ";
bool finish = false;
bool nameChecked = false;
BSTree<string> bstree = new BSTree<string>();  //create a BSTree of strings

//start of the program
Console.WriteLine("Welcome to the BSTree Creator");

//while the user isnt finished adding to the BSTree
while (!finish)
{
    //let the user add a word
    AddWord();

    //ask if they want to add another or not
    GoAgain();
}

//ask the user which traversal they would like to choose
Traversal();

//while the user wants to check for names
while (!nameChecked)
{
    NameCheck(); //ask them for a name to check for in the BSTree
}

//method to check if a name is present in the BSTree
void NameCheck()
{
    //ask user for name to be checked
    Console.Write("Name Check: ");

    //check if name inputted is contained in the BSTree
    Contains(Console.ReadLine());

    //ask the user if they would like to check again
    Console.Write("Check for another? (y/n)");

    //depending on user input
    switch (Console.ReadLine())
    {
        case "y": //if y
            break; //loop back through namecheck

        case "n": //if n
            nameChecked = true; //end loop
            break;
    }
}

//method to find a word in the BSTree, takes in a string parameter
void Contains(string word)
{
    Console.WriteLine(bstree.Contains(word)); //print result of if bstree contains 'word'
}

//method to update the bstree height and count
void Update()
{
    Console.WriteLine("Height: " + bstree.Height());
    Console.WriteLine("Count: " + bstree.Count());
}

//method to let the user choose a tree traversal
void Traversal()
{
    //ask the user which tree traversal they would like to do
    Console.WriteLine("Choose Tree Traversal \nIN-ORDER(1) \nPRE-ORDER(2) \nPOST-ORDER(3)");

    //depending on user input
    switch (Console.ReadLine())
    {
        //if they pick 1
        case "1":
            //traverse the tree in order
            bstree.InOrder(ref buffer);
            Console.WriteLine("in-order visit of BSTree " + buffer);
            buffer = " ";
            break;

        //if they pick 2
        case "2":
            //traverse the tree pre order
            bstree.PreOrder(ref buffer);
            Console.WriteLine("pre-order visit of BSTree " + buffer);
            buffer = " ";
            break;

        //if they pick 3
        case "3":
            //traverse the tree post order
            bstree.PostOrder(ref buffer);
            Console.WriteLine("post-order visit of BSTree " + buffer);
            break;
    }

    //update the height and count
    Update();
}

//method to let the user add a word
void AddWord()
{
    //take an input
    Console.WriteLine("Enter a string");

    //insert the input into the BSTree
    bstree.InsertItem(Console.ReadLine());

    //update the height and count
    Update();
}

//method to ask the user if they would like to add another word
void GoAgain()
{
    //take an input
    Console.WriteLine("Would you like to enter another?(y/n)");
    string ans = Console.ReadLine();

    //if input is y
    if (ans == "y")
    {
        return; //break out of GoAgain code
    }

    //if ans is n
    else if (ans == "n")
    {
        //notify user of tree creation
        Console.WriteLine("Your tree has been created.");
        finish = true; //break out of finish loop
    }
    else //if and is neither of those
    {
        //ask the user to answer correctly
        Console.WriteLine("Answer correctly please.");
        GoAgain(); //run the loop again
    }
}

