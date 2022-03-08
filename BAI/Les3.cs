using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI
{
    static class Les3
    {
      static  Stack<char> stack;
      static  String sentance = "(({)})";
        static char[] OpeningBrackets = { '(', '{', '[' };
        static char[] CloseBrackets = { ')', '}', ']' };
        static void init()
        {
            stack = new Stack<char>();
        }
        public static void run()
        {
            init();


            foreach (char l in sentance)
            {
                if (OpeningBrackets.Contains(l))
                {
                    stack.Push(l);
                }

                else if (CloseBrackets.Contains(l))
                {
                    if (stack.Count > 0)
                    {
                        if (stack.Peek() == OpeningBrackets[Array.IndexOf(CloseBrackets, l)])
                        {
                            stack.Pop();
                        }
                        else
                        {
                            Console.WriteLine("BAD");
                        }
                    }
                    else
                    {
                        Console.WriteLine("BAd");
                    }
                }
            }
            if (stack.Count != 0)
            {
                Console.WriteLine("BAD");
            }
            else
            {
                Console.WriteLine("Good");
            }
        }
    }
}
