using System;

namespace lista_aula
{
   public class DNode
   {
      private object data;
      private DNode next;
      private DNode previous;
      public DNode(object data, DNode next, DNode previous)
      {
         this.data = data;
         this.next = next;
         this.previous = previous;
      }
      public object Data
      {
         get { return data; }
         set { this.data = value; }
      }
      public DNode Next
      {
         get { return this.next; }
         set { this.next = value; }
      }

      public DNode Previous
      {
         get { return this.previous; }
         set { this.previous = value; }
      }
   }
}
