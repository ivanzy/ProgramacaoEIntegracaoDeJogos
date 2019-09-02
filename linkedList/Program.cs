using System;
using System.Collections.Generic;

namespace lista_aula
{
   class Program
   {
      static void Main(string[] args)
      {
         //DoublyLinkedListTest();
         CircularListTest();
      }
      static void ArrayTest()
      {
         int[] teste = { 1, 2, 3, 4 };
         teste = removeElement(teste, 3);
         printArray<int>(teste);
         teste = addElement(teste, 2, 4);
         printArray<int>(teste);
      }
      static void CircularListTest()
      {
         CircularLinkedList circularList = new CircularLinkedList();
         circularList.Add(1);
         circularList.Add(2);
         Console.WriteLine("contem: " + circularList.Contains(1));
         Console.WriteLine("contem: " + circularList.IndexOf(1));
         circularList.Add(3);
         Console.WriteLine("index: " + circularList.ElementAt(2));
         circularList.Add(4);
         Console.WriteLine("Tamanho: " + circularList.Count);
         circularList.printList();
         circularList.Add(3, -1);
         circularList.printList();
         Console.WriteLine("contem: " + circularList.Contains(1));
         Console.WriteLine("contem: " + circularList.Contains(4));
         Console.WriteLine("contem: " + circularList.Contains(2));
         Console.WriteLine("contem: " + circularList.Contains(-2));
      }
      static void DoublyLinkedListTest()
      {
         DoublyLinkedList doublyList = new DoublyLinkedList();
         doublyList.Add(1);
         doublyList.Add(2);
         Console.WriteLine("contem: " + doublyList.Contains(1));
         Console.WriteLine("contem: " + doublyList.IndexOf(1));
         doublyList.Add(3);
         Console.WriteLine("index: " + doublyList.ElementAt(2));
         doublyList.Add(4);
         Console.WriteLine("Tamanho: " + doublyList.Count);
         doublyList.printList();
         doublyList.Add(3, -1);
         doublyList.printList();
         doublyList.Remove(3);
         doublyList.printList();
      }
      static void LinkedListTest()
      {

         LinkedList list = new LinkedList();
         list.Add("texto 1");
         list.Add("texto 2");
         list.Add("texto 3");
         list.Add(1, "texto 1.5");
         Console.WriteLine("Está vazia? " + list.Empty);
         Console.WriteLine("Tamanho: " + list.Count);

         list.printList();
         list.Remove(1);
         list.printList();
         list.Remove(0);
         list.printList();

         Console.WriteLine(list.Contains("texto 1"));
         Console.WriteLine(list.Contains("texto 3"));
         Console.WriteLine(list.Contains(1));

         Console.WriteLine(list.IndexOf("texto 3"));

         for (int i = 0; i < list.Count; i++)
            Console.Write(list[i] + " ");
         Console.WriteLine();
      }
      static void printArray<T>(IEnumerable<T> vetor)
      {
         foreach (var element in vetor)
         {
            Console.Write(element + " ");
         }
         Console.WriteLine();
      }
      static int[] removeElement(int[] vetor, int index)
      {
         int[] novoVetor = new int[vetor.Length - 1];
         int novoIndex = 0;
         for (int i = 0; i < novoVetor.Length; i++)
         {
            if (index == i)
               novoIndex++;
            novoVetor[i] = vetor[novoIndex];
            novoIndex++;
         }
         return novoVetor;
      }

      static int[] addElement(int[] vetor, int index, int data)
      {
         int[] novoVetor = new int[vetor.Length + 1];
         int novoIndex = 0;
         for (int i = 0; i < novoVetor.Length; i++)
         {
            if (i == index)
            {
               novoVetor[index] = data;
            }
            else
            {
               novoVetor[i] = vetor[novoIndex++];
            }

         }
         return novoVetor;
      }
   }
}

