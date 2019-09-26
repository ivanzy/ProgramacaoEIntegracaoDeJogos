using System;

namespace queue
{
   public class Node
   {
      private object data;
      private Node next;
      public Node(object data, Node next)
      {
         this.data = data;
         this.next = next;
      }
      public object Data
      {
         get { return data; }
         set { this.data = value; }
      }
      public Node Next
      {
         get { return next; }
         set { this.next = value; }
      }
   }
}
