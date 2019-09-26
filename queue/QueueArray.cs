using System;

namespace queue
{
   public class QueueArray
   {
      private int _head; //adicionar aqui
      private int _tail; //remover daqui
      private int _count;
      private object[] _queue;

      public QueueArray(int size)
      {
         this._queue = new object[size];
         this._head = 0;
         this._tail = 0;
         this._count = 0;
      }

      public QueueArray()
      {
         this._queue = new object[1024];
         this._head = 0;
         this._tail = 0;
         this._count = 0;
      }
      public bool IsEmpty()
      {
         return (this._count == 0);
      }
      public object Peek()
      {
         if (this.IsEmpty())
            throw new ArgumentOutOfRangeException("Queue is empty");
         else
            return this._queue[this._head];
      }

      public void Enqueue(object data)
      {
         if (this._count == this._queue.Length)
            throw new ArgumentOutOfRangeException("Queue is full");
         else
         {
            this._queue[this._tail] = data;
            this._tail = (this._tail + 1) % this._queue.Length;
            this._count++;
         }
      }

      public object Dequeue()
      {
         if (this.IsEmpty())
            throw new ArgumentOutOfRangeException("Queue is empty");
         else
         {
            object element = this._queue[this._head];
            this._head = (this._head + 1) % this._queue.Length;
            this._count--;
            return element;
         }
      }
      public int Count
      {
         get
         {
            return this._count;
         }
      }
   }
}
