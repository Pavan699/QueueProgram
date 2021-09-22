using System;

namespace QueueProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Queue Program");
            QueueLList<int> queue = new QueueLList<int>();
            int defcount = 0;
            while (defcount == 0)
            {
                Console.WriteLine("Choice : \n  1.Enqueu(Add) \t 2.Print \t 3.Dequeue(Delete) \t 4.Exit ");
                Console.Write("Enetr Choice : ");
                int choice = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("-----------------------------------------------------------------------------");
                switch (choice)
                {
                    case 1:
                        Console.Write("How Many elements do You want to Enter : ");
                        int elements = Convert.ToInt32(Console.ReadLine());
                        for (int i = 0; i < elements; i++)
                        {
                            Console.Write("Enter element : ");
                            int ele = Convert.ToInt32(Console.ReadLine());
                            queue.Enqueue(ele);
                        }
                        break;
                    case 2:
                        queue.Print();
                        break;
                    case 3:
                        queue.Dequeue();
                        break;
                    default:
                        Console.WriteLine("Thank You :)");
                        defcount++;
                        break;
                }
                Console.WriteLine("-----------------------------------------------------------------------------");
            }
        }
    }
}
