using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace automata1
{
    class Program
    {
        static void Main(string[] args)
        { int temp = 1;
            bool valid = true, validAplha = true;
            while (temp == 1) { 
                Console.WriteLine("enter string");//string is entered in braces
                String s = Console.ReadLine();
                String[] s1 = s.Split(',', '{', '}');//spilit the string
                if (s1.Length < 3)
                    Console.WriteLine("INVALID ALPHABET");
                else
                {
                    for (int j = 1; j < s1.Length - 1; j++)
                    {
                        for (int k = j + 1; k < s1.Length - 1; k++)
                        {
                            valid = false;
                            int i = 0;
                            if (s1[j].Length < s1[k].Length)//compare each character of the required string
                                i = s1[j].Length;
                            else
                                i = s1[k].Length;
                            for (int l = 0; l < i; l++)
                            {
                                if (s1[j][l] != s1[k][l])
                                {
                                    valid = true;//if comparision success valid becomes true
                                    break;
                                }
                            }
                            if (!valid)
                            {
                                validAplha = false;
                                break;
                            }
                        }
                    }
                    if (validAplha)
                        Console.WriteLine("VALID ALPHABET");
                    else
                        Console.WriteLine("INVALID ALPHABET");
                }
                Console.ReadLine();
            
        }
            }
    }
}
    
