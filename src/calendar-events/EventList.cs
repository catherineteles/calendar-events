namespace calendar_events;
#pragma warning disable CS8602

public class EventList
{
    private class Node
    {
        public Event Value;
        public Node? Next;

        public Node(Event t)
        {
            Value = t;
            Next = null;
        }
    }

    private Node? Head;

    public void GenericList()
    {
        Head = null;
    }

    public void Add(Event input) 
    {
        if (Head == null)
        {
            Head = new Node(input);            
        }
        else
        {
            //Encontra onde inserir o próximo nó na lista.
            Node? lastNode = Head;
            while(lastNode.Next != null)   lastNode = lastNode.Next;

            lastNode.Next = new Node(input);                        
        }
    }

    public void Print(string format)
    {
        Node? printNode = Head;
        while(printNode.Next != null)
        {
            Console.Write(printNode.Value.PrintEvent(format));
        }
        
    }

    public Event Index(int index)
    {
        Node? searchNode = Head;
        for(int i = 0; i < index; i++)
        {
            if(searchNode.Next != null)
            {
                searchNode = searchNode.Next;
                continue;
            }
            else
            {
                throw new InvalidOperationException("Não há elementos suficientes na lista");
            }
        }
        return searchNode.Value;
    }

    public int SearchByTitle(string title)
    {
        Node? currentNode = Head;
        int index = 0;
        while(currentNode != null)
        {
            if (currentNode.Value.Title == title)
            {
                return index;
            }

            currentNode = currentNode.Next;

            index += 1;
        }
        throw new InvalidOperationException("Elemento não encontrado");      
    }

    public int SearchByDate(string dateSearch)
    {
        Node? currentNode = Head;
        int index = 0;
        while(currentNode != null)
        {
            if (currentNode.Value.EventDate == DateTime.Parse(dateSearch))
            {
                return index;
            }

            currentNode = currentNode.Next;

            index += 1;
        }
        throw new InvalidOperationException("Elemento não encontrado");
    }
    
}