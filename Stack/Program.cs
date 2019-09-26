using System;

namespace aulaStack
{
   class Program
   {
      static void Main(string[] args)
      {
         Stack();
      }
      static void Stack()
      {
         Console.WriteLine(IsExpBalanced("<Lothar (atacar<><>(aaa>) <Klunk>)>"));
         Console.WriteLine(IsExpBalanced("<Nargot (atacar <Lothar> <Klunk> <Missandi>)>"));
         Console.WriteLine(IsExpBalanced("<Nargot (atacar <Lothar> <Klunk> <Missandi>))>"));
         Console.WriteLine(IsExpBalanced("< Arthur LaVey  (dar item < Jaime ( atacar < orc >)>) >"));
         Console.WriteLine(IsExpBalanced("< Arthur LaVey  (dar item  Jaime ( atacar < orc >)>) >"));

      }

      static Boolean IsMatchingPair(char character1, char character2)
      {
         if (character1 == '<' && character2 == '>')
            return true;
         else if (character1 == '(' && character2 == ')')
            return true;
         else
            return false;
      }
      static bool IsExpBalanced(string exp)
      {
         Stack st = new Stack();
         foreach (char ch in exp.ToCharArray())
         {
            if (ch == '<' || ch == '(')
               st.Push(ch);
            else if (ch == '>' || ch == ')')
            {
               if (st.Empty())
                  return false;
               else if (!IsMatchingPair((char)st.Pop(), ch))
                  return false;
            }
         }
         if (st.Empty())
            return true;
         else
            return false;
      }
   }
}
