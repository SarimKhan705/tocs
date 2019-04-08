using System;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Language defined over E=(0,1)");
            Console.WriteLine("enter no of states");//number of states a DFA can have
            int n = Convert.ToInt32(Console.ReadLine());
            bool stringAccepted = false;//a variable which will become true once the given word ends on a final state
            int[] a1 = new int[n];
            for (int a = 0; a < n; a++)
            {
                a1[a] = a;//put states in an array
            }
            int x = 2;
            int[,] a2 = new int[n, x];
            for (int b = 0; b < n; b++)
            {
                for (int c = 0; c < x; c++)  //a 2d array is used to take input that where to go when 0 or 1 comes on each state
                {
                    Console.WriteLine("choose where to go if {0} comes to state {1}", c, a1[b]+1);
                    a2[b, c] = Convert.ToInt32(Console.ReadLine()) - 1;
                }
            }
            Console.WriteLine("enter a word defined over E=(0,1)");
            string w = Console.ReadLine();//word input
            Console.WriteLine("enter number of final states");
            int m = Convert.ToInt32(Console.ReadLine());//final state input
            Console.WriteLine("which one's?");
            int[] a3 = new int[m];
            for (int d = 0; d < m; d++)
            {
                a3[d] = Convert.ToInt32(Console.ReadLine()) - 1;
            }
            int cur_state = 0;//current position of state
            for (int e = 0; e < w.Length; e++)
            {
                cur_state = a2[cur_state, Convert.ToInt32(w[e]) - 48];//compare the word 
            }
            for (int k = 0; k < m; k++)
            {
                if (cur_state == a3[k])//if word ends on a final state
                {
                    stringAccepted = true;//becomes true
                    break;
                }
            }
            if (stringAccepted == true)
            Console.WriteLine("\nString Accepted");
            else
            Console.WriteLine("\nString Not Accepted");
            Console.ReadLine();

        }
    }
}