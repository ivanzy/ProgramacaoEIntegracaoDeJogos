using System;
using System.Collections;
namespace queue
{
   class Program
   {
      static void Main(string[] args)
      {
         Queue fila = new Queue();
         fila.Enqueue("elemento 1");
         fila.Enqueue("elemento 2");
         fila.Enqueue("elemento 3");
         fila.Enqueue("elemento 4");
         Console.WriteLine(fila.Dequeue());
         Console.WriteLine(fila.Dequeue());
         fila.Enqueue("elemento 5");
         Console.WriteLine(fila.Dequeue());
         fila.Enqueue("elemento 6");
         fila.Enqueue("elemento 7");
         fila.Enqueue("elemento 8");
         Console.WriteLine(fila.Dequeue());
         Console.WriteLine(fila.Dequeue());
         Console.WriteLine(fila.Dequeue());
         Console.WriteLine(fila.Dequeue());
      }

















      static void ArrayQueueFunction()
      {
         QueueArray fila = new QueueArray(5);
         fila.Enqueue(1);
         fila.Enqueue(2);
         fila.Enqueue(3);
         fila.Enqueue(4);
         fila.Enqueue(5);
         Console.WriteLine(fila.Dequeue());
         Console.WriteLine(fila.Dequeue());
         Console.WriteLine(fila.Dequeue());
         Console.WriteLine(fila.Dequeue());
         Console.WriteLine(fila.Dequeue());

         fila.Enqueue(6);

         Console.WriteLine(fila.Dequeue());
      }
   }

}
