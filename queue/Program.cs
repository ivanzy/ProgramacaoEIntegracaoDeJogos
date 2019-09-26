using System;

namespace queue
{
   class Program
   {
      static void Main(string[] args)
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
