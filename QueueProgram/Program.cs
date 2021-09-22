using System;

namespace QueueProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Queue Program");
            QueueLList<int> queue = new QueueLList<int>();
            queue.Enqueue(56);
            queue.Enqueue(30);
            queue.Enqueue(70);
            queue.Print();
            queue.Dequeue();
        }
    }
}
