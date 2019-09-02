using System;

namespace lista_aula
{
   public class DoublyLinkedList
   {
      private DNode head;

      public DoublyLinkedList()
      {
         this.head = null;
      }

      public bool Empty
      {
         get
         {
            return (this.head == null);
         }
      }

      public int Count
      {
         get
         {
            DNode n = head;
            if (n == null) return 0;
            int i = 1;
            while (n.Next != null)
            {
               n = n.Next;
               i++;
            }
            return i;
         }
      }
      public void printList()
      {
         DNode n = this.head;
         while (n != null)
         {
            Console.WriteLine(n.Data);
            n = n.Next;
         }
         Console.WriteLine();
      }
      public void Clear()
      {
         this.head = null;
      }
      public bool Contains(object obj)
      {
         DNode n = this.head;
         while (n != null)
         {
            if (n.Data.Equals(obj)) return true;
            n = n.Next;
         }
         return false;
      }

      public int IndexOf(object obj)
      {
         DNode n = this.head;
         int i = 0;
         while (n != null)
         {
            if (n.Data.Equals(obj)) return i;
            n = n.Next;
            i++;
         }
         return -1;
      }
      public object this[int index]
      {
         get { return this.ElementAt(index); }
      }
      public object ElementAt(int index)
      {
         if (index < 0)
            throw new ArgumentOutOfRangeException("negative index: " + index);
         else if (index >= this.Count)
            throw new ArgumentOutOfRangeException("Out of Bounds index: " + index);
         else
         {
            DNode n = this.head;
            for (int i = 0; i < index; i++)
            {
               n = n.Next;
            }
            return n.Data;
         }
      }
      public void AddFirst(object data)
      {
         DNode newHead = new DNode(data, this.head, null);
         if (this.head != null)
            this.head.Previous = newHead;
         this.head = newHead;
      }
      public void Add(int index, object data)
      {
         if (index < 0)
            throw new ArgumentOutOfRangeException("negative index: " + index);
         else if (index >= this.Count)
            throw new ArgumentOutOfRangeException("Out of Bounds index: " + index);
         else
         {
            DNode n = this.head;
            if (index == 0)
            {
               this.head = new DNode(data, this.head, null);
            }
            else
            {
               for (int i = 0; i < index - 1; i++)
               {
                  n = n.Next;
               }
               n.Next = new DNode(data, n.Next, n);
            }
         }
      }

      public void Add(object data)
      {
         if (this.head == null)
         {
            this.head = new DNode(data, null, null);
         }
         else
         {
            DNode n = this.head;
            while (n.Next != null)
               n = n.Next;
            n.Next = new DNode(data, n.Next, n);
         }
      }

      public void Remove(int index)
      {
         if (index < 0)
            throw new ArgumentOutOfRangeException("negative - index: " + index);
         else if (index >= this.Count)
            throw new ArgumentOutOfRangeException("Out of Bounds - index: " + index);
         else
         {
            if (index == 0)
            {
               this.head = this.head.Next;
               this.head.Previous = null;
            }
            else
            {
               DNode n = this.head;
               for (int i = 0; i < index - 1; i++)
               {
                  n = n.Next;
               }
               DNode jumpNode = n.Next.Next;
               if (jumpNode != null)
                  jumpNode.Previous = n;
               n.Next = jumpNode;

            }
         }

      }
   }
}

