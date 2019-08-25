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

      public void Add(object data)
      {
         if (this.head == null)
         {
            this.head = new Node(data, null);
         }
         else
         {
            Node n = this.head;
            while (n.Next != null)
               n = n.Next;
            n.Next = new Node(data, n.Next);
         }
      }

      public void printList()
      {
         Node n = this.head;
         while (n != null)
         {
            Console.WriteLine(n.Data);
            n = n.Next;
         }
         Console.WriteLine();
      }

      /* Implementar as seguintes funções:
         - Count - deve retornar o tamanho da lista
         - AddAtHead - adicionar um elemento da vabeça da lista
         - Add - adicionar um elemento em uma determinada posição (índice)
         - Remove - remover o elemento em uma determinada posição (índice)
         - Clear - apagar toda a lista
         - Contains - retorna se um dado elemento existe ou não na lista (true ou false)
         - ElementAt - retorna o elemento em uma determinada posição (índice)
         - IndexOf - dado um elemento, retorna a posição que ele está na lista, caso ele não esteja na lista, retorna -1 */
   }
}

