using System;

interface IOperation
{
    void Insert(string str);
    string Delete();
    bool Search(string str);
    string GetCurrentElt();
    int NumOfElements();
}
class Stack : IOperation
{
    String[] stack;
    int sp = -1;
    int size = 100;
    public Stack()
    {
        stack = new string[size];
    }
    public Stack(int num)
    {
        size = num;
        stack = new string[size];
    }
    public void Insert(string str) // 매개변수로 받은 str을 스택에 푸시한다. 1-1
    {
        if (sp < size)
        {
            stack[++sp] = str;
            Console.WriteLine(str + " Insert");
        }
        else
        {
            Console.WriteLine("Stack is full"); // 스택이 다 찼음을 의미
        }
    }

    public string Delete() // 스택에서 팝한 후 반환한다 1-2
    {
        if (sp != -1)
        {
            Console.WriteLine("Delete");
            return stack[sp--];
        }
        else
        {
            Console.WriteLine("Stack is empty");
            return null;
        }
    }

    public bool Search(string str) // 스택에서 주어진 원소의 존재여부를 반환한다. 1-3
    {
        if (sp == -1)
        {
            Console.WriteLine("Stack is empty");
            return false;
        }
        else
        {
            for (int i = 0; i <= sp; i++)
            {
                if (stack[i].Equals(str)) return true; // 원소가 있을시에 true 반환
            }
            return false; // 원소가 없을시에 false 반환
        }
    }

    public string GetCurrentElt() // 현재 스택 탑에 있는 원소를 반환한다. 1-4
    {
        if (sp == -1)
        {
            Console.WriteLine("Stack is empty");
            return null;
        }
        else
        {
            return stack[sp];
        }
    }
    public int NumOfElements() // 스택에 존재하는 원소의 개수를 반환한다. 1-5
    {
        if (sp == -1) return 0;
        else return sp + 1;
    }
}

class Queue : IOperation
{
    int front = 0;
    int rear = 0;
    int size = 100;
    string[] queue;

    public Queue()
    {
        queue = new string[size];
    }

    public Queue(int num)
    {
        size = num;
        queue = new string[size];
    }

    public void Insert(string str) // 매개변수로 받은 str을 큐의 rear에 삽입한다. 2-1
    {
        if (rear < size)
        {
            queue[rear++] = str;
            Console.WriteLine(str + " Insert");
        }
        else
        {
            Console.WriteLine("Queue is full"); // 큐가 다 찼음을 의미
        }
    }

    public string Delete() // 큐의 front에서 제거한 후 반환한다. 2-2
    {
        if (rear == front)
        {
            Console.WriteLine("Queue if empty");
            return null;
        }
        else
        {
            Console.WriteLine("Delete");
            return queue[front++];
        }
    }

    public bool Search(string str) // 큐에서 주어진 원소의 존재여부를 확인한다. 2-3
    {
        if (rear == front)
        {
            Console.WriteLine("Queue is Empty");
            return false;
        }
        else
        {
            for (int i = front; i < rear; i++)
            {
                if (queue[i].Equals(str)) return true; // 원소가 존재할 경우 true 반환
            }
            return false; // 원소가 존재하지 않을 경우 false 반환
        }
    }

    public string GetCurrentElt() // 현재 큐의 front에 있는 원소를 반환한다. 2-4
    {
        if (front == rear) return null;
        else return queue[front];
    }

    public int NumOfElements() // 큐에 존재하는 원소의 개수를 반환 2-5
    {
        return rear - front;
    }
}
class Program
{
    public static void Main()
    {
        Stack s = new Stack();
        Queue q = new Queue();

        Console.WriteLine("Stack");
        s.Insert("a");
        s.Insert("b");
        s.Delete();
        Console.WriteLine("Search(a) = " + s.Search("a"));
        Console.WriteLine("GetCurrenElt = " + s.GetCurrentElt());
        Console.WriteLine("NumOfElements = " + s.NumOfElements());
        Console.WriteLine("");
        Console.WriteLine("Queue");
        q.Insert("a");
        q.Insert("b");
        q.Delete();
        Console.WriteLine("Search(a) = " + q.Search("a"));
        Console.WriteLine("GetCurrenElt = " + q.GetCurrentElt());
        Console.WriteLine("NumOfElements = " + q.NumOfElements());
    }
}

