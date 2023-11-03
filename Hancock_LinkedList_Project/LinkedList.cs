namespace Hancock_LinkedList_Project
{
    internal class LinkedList
    {
        private Node _head;

        public string Add(string itemToAdd)
        {
            Node newNode = new Node(itemToAdd);
            if (_head == null)
            {
                _head = newNode;
                return itemToAdd + " added to list.";
            }
            Node current = _head;
            if (ShouldInsertBefore(itemToAdd, current.Data))
            {
                newNode.Next = _head;
                _head = newNode;
            }
            else
            {
                while (current.Next != null && !ShouldInsertBefore(itemToAdd, current.Next.Data))
                {
                    current = current.Next;
                }
                newNode.Next = current.Next;
                current.Next = newNode;
            }
            return itemToAdd + " added to list.";
        }

        public string Remove(string itemToRemove)
        {
            if (_head.Data == itemToRemove)
            {
                _head = _head.Next;
                return itemToRemove + " removed from list";
            }
            Node current = _head;
            Node previous = null;
            while (current != null)
            {
                if (current.Data == itemToRemove)
                {
                    if (current.Next != null)
                    {
                        previous.Next = current.Next;
                    }
                    return itemToRemove + " removed from list";
                }
                previous = current;
                current = current.Next;
            }
            return itemToRemove + " not on list";
        }

        public bool Contains(string itemToSearch)
        {
            Node current = _head;
            while (current != null)
            {
                if (current.Data == itemToSearch)
                {
                    return true;
                }
                current = current.Next;
            }
            return false;
        }

        public void PrintAllNodes()
        {
            Node current = _head;
            while (current != null)
            {
                Console.WriteLine(current.Data);
                current = current.Next;
            }
        }

        public bool ValidList()
        {
            if (_head == null)
            {
                return false;
            }
            return true;
        }

        public bool ShouldInsertBefore(string newItem, string existing)
        {
            int minLength = Math.Min(newItem.Length, existing.Length);
            int a, b;
            for (int i = 0; i < minLength; i++)
            {
                a = newItem.ToLower()[i];
                b = existing.ToLower()[i];
                if (a > b)
                {
                    return false;
                }
                else if (a < b)
                {
                    return true;
                }
            }
            if ((int)newItem[0] > (int)existing[0] || newItem.Length < existing.Length)
            {
                return true;
            }
            return false;
        }
    }
}