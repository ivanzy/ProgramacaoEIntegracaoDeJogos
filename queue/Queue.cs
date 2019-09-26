
using System;
namespace queue
{
   public class Queue
   {
      private Node _head; //adicionar aqui
      private Node _tail; //remover daqui
      public Queue()
      {
         this._head = null;
         this._tail = null;
      }
      public void Enqueue(object data)
      {
         Node lastElement = new Node(data, null);
         if (this._tail != null) this._tail.Next = lastElement;
         this._tail = lastElement;
         if (this._head == null) this._head = lastElement;
      }
      public object Dequeue()
      {
         if (this._head == null)
            throw new ArgumentOutOfRangeException("Queue is empty");
         else
         {
            object data = this._head.Data;
            this._head = this._head.Next;
            if (this._head == null) this._tail = null;
            return data;
         }
      }
      public bool isEmpty()
      {
         return (this._head == null);
      }
      public object Peek()
      {
         return this._head.Data;
      }
   }
}
