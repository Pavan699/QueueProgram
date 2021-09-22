using System;
using System.Collections.Generic;
using System.Text;

namespace QueueProgram
{
    class QueueLList<Qtype>
    {
        public QueueNode<Qtype> head;
        public QueueLList()
        {
            this.head = null;
        }
        /// <summary>
        /// Enqueue() method to add element in queue
        /// </summary>
        /// <param name="data"></param>
        public void Enqueue(Qtype data)
        {
            QueueNode<Qtype> node = new QueueNode<Qtype>(data);
            if(head == null)
            {
                head = node;
            }
            else
            {
                QueueNode<Qtype> temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;               
            }
            //Console.WriteLine("Element {0} is Added in Queue", node.data);
        }
        /// <summary>
        /// Dequeue() to empty the queue
        /// </summary>
        public void Dequeue()
        {
            if (head == null)
            {
                Console.WriteLine("Queue is Empty");
            }
            else
            {
                while(head != null)
                {
                    Console.WriteLine("Element " + head.data + " Dequeued ");
                    head = head.next;
                }
            }
        }

        /// <summary>
        /// Print() method to print the Queue
        /// </summary>
        public void Print()
        {
            QueueNode<Qtype> node = head;
            if(head == null)
            {
                Console.WriteLine("Queue is Empty");
            }
            while(node != null)
            {
                Console.WriteLine(node.data + " ");
                node = node.next;
            }
        }
    }
}
