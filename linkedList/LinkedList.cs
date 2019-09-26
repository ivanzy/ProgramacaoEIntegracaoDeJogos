using System;

namespace lista_aula
{
   public class LinkedList
   {
      private Node head;

      public LinkedList()
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
            Node n = head;
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
      public void Add(int index, object data)
      {
         if (index < 0)
            throw new ArgumentOutOfRangeException("negative index: " + index);
         else if (index > this.Count)
            throw new ArgumentOutOfRangeException("Out of Bounds index: " + index);
         else
         {
            Node n = this.head;
            if (index == 0)
            {
               this.head = new Node(data, this.head);
            }
            else
            {
               for (int i = 0; i < index - 1; i++)
               {
                  n = n.Next;
               }
               n.Next = new Node(data, n.Next);
            }
         }
      }

      public void Add(object data)
      {
         if (this.head == null)
         {
            this.head = new Node(data, this.head);
         }
         else
         {
            Node n = this.head;
            while (n.Next != null)
               n = n.Next;
            n.Next = new Node(data, null);
         }
      }

      public void Remove(int index)
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
               // 0 -> 1-> 2 ->3
               n.Next = n.Next.Next;
            }
         }

      }

      public void PrintList()
      {
         Node n = this.head;
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
         Node n = this.head;
         while (n != null)
         {
            if (n.Data.Equals(obj)) return true;
            n = n.Next;
         }
         return false;
      }

      public int IndexOf(object obj)
      {
         Node n = this.head;
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
            Node n = this.head;
            for (int i = 0; i < index; i++)     
               n = n.Next;
            return n.Data;
         }
      }

      

      public bool HasCicle(){
         if(this.Empty) return false;
         Node fast = head.Next;
         Node slow = this.head;
         while(fast !=null && fast.Next!=null && slow!=null){
            if(fast.Equals(slow)) return true;
            fast = fast.Next.Next;
            slow = slow.Next;
         }
         return false;
         
      }
   }
}

