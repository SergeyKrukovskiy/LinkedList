
using System;

namespace LinkedList
{

    public class SinglyLinkedListWithTail
    {
        public Node Head;
        private int count = 0;
        public Node Tail;

        public int GetCount()
        {
            return count;
        }
        public string Print()
        {
            string result = "";
            Node current = Head;
            while (current != null)
            {
                result += current.Value + " ";
                current = current.Next;
            }
            return result;
        }
        public Node Find(int key)
        {
            if (count == 0)
            {
                return null;
            }
            Node current = Head;
            while (current.Value != key)
            {
                current = current.Next;
                if (current == null)
                {
                    return null;
                }
            }
            return current;
        }
        public Node FindByIndex(int index)
        {
            if (count == 0) return null;
            if (index > count || index < 0) return null;
            Node current = Head;
            for (int i = 0; i < index; i++)
            {
                current = current.Next;
                if (current == null) return null;
            }
            return current;
        }
        public Node FindLast(int key)
        {
            if (count == 0) return null;
            Node current = Head;
            int j = -1;
            for (int i = 0; i < count; i++)
            {
                if (current.Value == key)
                {
                    j = i;
                }
                current = current.Next;
                if (j != -1 && i == count -1) return FindByIndex(j);
            }
            return null;
        }
        public void PushBack(int item)
        {
            Node newNode = new Node(item);
            if (count == 0)
            {
                Head = newNode;
            }
            else
            {
                Tail.Next = newNode;
            }

            count++;
            Tail = newNode;
        }
        public void PushFront(int item)
        {
            Node newNode = new Node(item);

            if (count != 0)
            {
                newNode.Next = Head;
            }
            Head = newNode;
            count++;
        }
        public void AddAfter(Node node, int item)
        {
            if (node == null)
            {
                return;
            }
            Node newNode = new Node(item);

            newNode.Next = node.Next;
            node.Next = newNode;
            if (node == Tail)
            {
                Tail = newNode;
            }

            count++;
        }
        public void AddBefore(Node node, int item)
        {
            if (node == null) return;
            Node res = new Node(item);
            if (node == Head)
            {
                Head = res;
                res.Next = node;
                count++;
                return;
            }
            Node current = Head;
            while (current.Next != node)
            {
                current = current.Next;
            }
            current.Next = res;
            res.Next = node;
            count++;
        }
        public void PushBackRange(int[] array)
        {
            Node current = Tail;
            if (current == null)
            {
                Node res = new Node(array[0]);
                Head = res;
                current = res;
                for (int i = 1; i < array.Length; i++)
                {
                    res = new Node(array[i]);
                    current.Next = res;
                    current = res;
                    count++;
                }
            }
            else
            {
                for (int i = 0; i < array.Length; i++)
                {
                    Node res = new Node(array[i]);
                    current.Next = res;
                    current = res;
                    count++;
                }
            }
        }
        public void RemoveFirst()
        {
            if (count == 0)
            {
                throw new Exception("Список пуст");
            }

            if (count == 1)
            {
                Head = null;
                Tail = null;
            }
            else
            {
                Head = Head.Next;
            }

            count--;
        }
        public void RemoveLast()
        {
            if (count == 0)
            {
                throw new Exception("Список пуст");
            }

            if (count == 1)
            {
                Head = null;
                Tail = null;
            }
            else
            {
                Node current = Head;
                while (current.Next.Next != null)
                {
                    current = current.Next;
                }

                current.Next = null;
                Tail = current;
            }

            count--;
        }
        public void RemoveNode(Node node)
        {
            if (node == Head)
            {
                RemoveFirst();
            }
            else
            {
                Node current = Head;
                while (current.Next != null)
                {
                    if (current.Next == node)
                    {
                        break;
                    }

                    current = current.Next;
                }

                current.Next = node.Next;

                if (node == Tail)
                {
                    Tail = current;
                }

                count--;
            }
        }
        public bool Remove(int item)
        {
            Node del = Find(item);
            if (del == null) return false;
            else
            {
                RemoveNode(del);
                return true;
            }
        }
        public bool RemoveLast(int item)
        {
            Node del = FindLast(item);
            if (del == null) return false;
            else
            {
                RemoveNode(del);
                return true;
            }
        }
        public int RemoveAll(int item)
        {
            int COIN = 0;
            Node del = Find(item);
            if (del == null) return COIN;
            if (count == 0) return COIN;
            else
            {
                while (del != null)
                {
                    RemoveNode(del);
                    COIN++;
                    count--;
                    del = Find(item);
                }
                return COIN;
            }
        }
        public void Reverse()
        {
            if (count == 0)
            {
                throw new Exception("Список пуст");
            }
            if (count == 1)
            {
                return;
            }
        }
    }
}
