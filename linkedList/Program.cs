using System;
using System.Collections.Generic;

namespace lista_aula
{
   class Program
   {
      static void Main(string[] args)
      {
         LinkedList list = new LinkedList();
         list.Add("texto 1");
         list.Add("texto 2");
         list.Add("texto 3");
         list.printList();


         int[] teste = { 1, 2, 3, 4 };
         teste = removeElement(teste, 3);
         printArray<int>(teste);
         teste = addElement(teste, 2, 4);
         printArray<int>(teste);

      }

      // imprime um array genérico
      static void printArray<T>(IEnumerable<T> vetor)
      {
         foreach (var element in vetor)
         {
            Console.Write(element + " ");
         }
         Console.WriteLine();
      }

      // função que remove o elemento de posição index
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

      // função que adiciona um novo elemento a um vetor na posição index  
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

