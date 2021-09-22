using System;
using System.Collections.Generic;
using System.Text;

namespace QueueProgram
{
    class QueueNode<Qtype>
    {
        public Qtype data;//class instance
        public QueueNode<Qtype> next;
        public QueueNode(Qtype data)//constructor to assing the data
        {
            this.data = data;
        }
    }
}
