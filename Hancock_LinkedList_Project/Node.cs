namespace Hancock_LinkedList_Project
{
    internal class Node
    {
        public string Data { get; set; }
        public Node Next;

        public Node(string data)
        {
            Data = data;
            Next = null;
        }
    }
}