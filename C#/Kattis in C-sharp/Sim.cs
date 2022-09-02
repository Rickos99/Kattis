using System;
using System.Collections.Generic;
using System.Text;

namespace Kattis_in_C_sharp
{
    // https://open.kattis.com/problems/sim
    class Sim
    {
        //public static void Main() => Solution();

        static void Solution()
        {
           int testCases = int.Parse(Console.ReadLine());
           while (testCases-- > 0)
           {
               string input = Console.ReadLine();
               Console.WriteLine(Parse(input));
           }
           Console.ReadLine();
        }

        static string Parse(string str)
        {
            LinkedList<char> output = new LinkedList<char>();
            LinkedListNode<char> previousNode = null;

            for (int i = 0; i < str.Length; i++)
            {
                char c = str[i];
                switch (c)
                {
                    case '<':
                        if (previousNode == null) break;

                        var pn = previousNode.Previous;
                        output.Remove(previousNode);
                        previousNode = pn;
                        break;

                    case '[':
                        previousNode = null;
                        break;

                    case ']':
                        previousNode = output.Last;
                        break;

                    default:
                        var node = new LinkedListNode<char>(c);
                        if (previousNode == null)
                            output.AddFirst(node);
                        else
                            output.AddAfter(previousNode, node);

                        previousNode = node;
                        break;
                }
            }

            return LinkedListToString(output);
        }

        private static string LinkedListToString(LinkedList<char> ts)
        {
            var currentNode = ts.First;
            var sb = new StringBuilder(ts.Count);
            while (currentNode != null)
            {
                sb.Append(currentNode.Value);
                currentNode = currentNode.Next;
            }
            return sb.ToString();
        }

    }
}
