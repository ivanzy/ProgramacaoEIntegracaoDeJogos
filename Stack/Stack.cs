using System;

namespace aulaStack
{
   public class Stack
   {
      private Node top;

      public Stack()
      {
         top = null;
      }
      public void Push(object data)
      {
         this.top = new Node(data, this.top);
      }
      public object Pop()
      {
         if (this.top.Equals(null))
         {
            Console.WriteLine("A pilha está vazia");
            return null;
         }
         Node oldTop = this.top;
         this.top = this.top.Next;
         return oldTop.Data;
      }

      public object Peek()
      {
         return this.top.Data;
      }
      public bool Empty() { return (this.top == null); }

































      // private Node top;
      // public Stack() { 
      //       this.top = null; 
      // }
      // public void Push(object data){ 
      //       this.top = new Node(data, this.top); 
      // }
      // public object Pop()
      // {  
      //    if(this.top == null) 
      //       throw new ArgumentOutOfRangeException("Stack is empty");
      //    object data = this.top.data;
      //    this.top = this.top.Next;  
      //    return data;
      //    }
      // public object Peek(){ return this.top;}
      // public bool Empty() {return (this.top == null); }
   }
}

