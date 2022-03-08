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


        static Queue<char> queue2;
        static Queue<char> queue1;


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
        public static void init2()
        {
            queue1 = new Queue<char>();
            queue2 = new Queue<char>();
            queue1.Enqueue('a');
            queue1.Enqueue('b');
            queue1.Enqueue('c');
            queue1.Enqueue('d');
            queue1.Enqueue('e');
            String a = Console.ReadLine();
            foreach (char l in a)
            {
                queue1.Enqueue(l);
            }
        }
        public static void run2()
        {
            init2();
            int queue1size = queue1.Count;
            for (int i = 0; i < queue1size; i++)
            {
                queue2.Enqueue(queue1.Dequeue());
            }
            int queue2size = queue2.Count;
            for (int i = 0;i < queue2size; i++)
            {
                Console.WriteLine(queue2.Dequeue());
            }
        }
    }
}
