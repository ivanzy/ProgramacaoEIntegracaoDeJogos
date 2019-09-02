using System;

namespace lista_aula
{
   public class CircularLinkedList
   {
      private Node tail;
      public CircularLinkedList()
      {
         this.tail = null;
      }

      public bool Empty
      {
         get
         {
            return (this.tail == null);
         }
      }
      public int Count
      {
         get
         {
            if (this.tail == null) return 0;
            Node n = this.tail.Next;

            int i = 1;
            while (n.Next != this.tail.Next)
            {
               n = n.Next;
               i++;
            }
            return i;
         }
      }
      public void Add(int index, object data)
      {
         if (index < 0)
            throw new ArgumentOutOfRangeException("negative index: " + index);
         else if (index > this.Count)
            throw new ArgumentOutOfRangeException("Out of Bounds index: " + index);
         else
         {
            Node n = this.tail;
            if (index == this.Count)
            {
               this.Add(data);
            }
            else
            {
               for (int i = 0; i <= index - 1; i++)
               {
                  n = n.Next;
               }
               n.Next = new Node(data, n.Next);
            }
         }
      }

      public void Add(object data)
      {
         if (this.tail == null)
         {
            Node firstNode = new Node(data, null);
            firstNode.Next = firstNode;
            this.tail = firstNode;
         }
         else
         {
            Node newTail = new Node(data, this.tail.Next);
            this.tail.Next = newTail;
            this.tail = newTail;

         }
      }
// Exercício
 /*      public void Remove(int index)
      {
         if (index < 0)
            throw new ArgumentOutOfRangeException("negative index: " + index);
         else if (index >= this.Count)
            throw new ArgumentOutOfRangeException("Out of Bounds index: " + index);
         else
         {
            if (index == 0)
               this.head = this.head.Next;
            else
            {
               Node n = this.head;
               for (int i = 0; i < index - 1; i++)
               {
                  n = n.Next;
               }
               n.Next = n.Next.Next;
            }
         }

      } */

      public void printList()
      {
         if (this.tail != null)
         {
            Node n = this.tail.Next;
            do
            {
               Console.WriteLine(n.Data);
               n = n.Next;
            } while (n != this.tail.Next);
            Console.WriteLine();
         }
      }

      public void Clear()
      {
         this.tail = null;
      }

      public bool Contains(object obj)
      {
         if (this.tail == null) return false;
         Node n = this.tail.Next;
         do
         {
            if (n.Data.Equals(obj)) return true;
            n = n.Next;
         } while (n != this.tail.Next);
         return false;
      }

      public int IndexOf(object obj)
      {
         Node n = this.tail.Next;
         int i = 0;
         if (n == null) return -1;

         do
         {
            if (n.Data.Equals(obj)) return i;
            n = n.Next;
            i++;
         } while (n != this.tail.Next);
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
            Node n = this.tail.Next;
            for (int i = 0; i < index; i++)
            {
               n = n.Next;
            }
            return n.Data;
         }
      }
   }
}

