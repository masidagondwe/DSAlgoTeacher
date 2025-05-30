using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAlgoTeacher.Models
{
    public class QueueModel
    {
        public class Node
        {
            public int Data { get; set; }
            public Node Next { get; set; }
            public Node(int data)
            {
                Data = data;
                Next = null;
            }
        }
        private Node front;
        private Node rear;
        public QueueModel()
        {
            front = null;
            rear = null;
        }
        public void Enqueue(int data)
        {
            Node newNode = new Node(data);
            if (rear == null)
            {
                front = rear = newNode;
                return;
            }
            rear.Next = newNode;
            rear = newNode;
        }
        public int Dequeue()
        {
            if (front == null)
                throw new InvalidOperationException("Queue is empty.");
            
            int data = front.Data;
            front = front.Next;
            if (front == null)
                rear = null;
            return data;
        }
        public bool IsEmpty()
        {
            return front == null;
        }
    }
}
