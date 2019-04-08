using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApp5
{ class Program
    {
        public static string generatestring(string i, string j)
        {   string b = "";
            string[] a = new string[10000];
            a[0] = "^";
            a[1] = i;
            a[2] = j;
            int y = 1;
            for (int x = 3; x <a.Length-1; x++)//generate string upto array length
            {
                a[x] = a[y] + i;
                x++;
                a[x] = a[y] + j;
                y++;
            }
            for (int k = 0; k <a.Length-1; k++)
                b += a[k] + ",";
                return b;
        }
        public static void comparelength(string i, string j)//compare the element in generatestring array
        { 
            Console.WriteLine("\nEnter Length of The String ");
            int m = Convert.ToInt32(Console.ReadLine());
            string c = "";
            c += generatestring(i, j);
            string[] c1 = new string[10000];
               c1= c.Split(',');
            if (m == 0)
            {
                Console.WriteLine("\nThe Strings Having Length={0} Is:\n", m);
                Console.WriteLine(c1[0]);
            }
            else 
            {
                Console.WriteLine("\nThe Strings Having Length={0} Are:\n", m);
                int s = 1;
                for (int d = 1; d <10000; d++)
                {
                    if (m==c1[d].Length)
                    {
                        Console.Write("{0}-", s);
                        Console.WriteLine(c1[d]);
                        s++;
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            {
                Console.WriteLine("Enter String of Two Words in Curly Brackets");
                string s = Console.ReadLine();
                string[] s1 = s.Split(',', '{', '}');
                int n;
                string c = "";
                Console.WriteLine("\nChoose Your Choice\n");
                Console.WriteLine("1 For All Possible Strings");
                Console.WriteLine("2 For Strings Having Your Desired Length");
                n = Convert.ToInt32(Console.ReadLine());
                if (n == 1)
                {
                    string i, j;
                    i = s1[1];
                    j = s1[2];
                    c += generatestring(s1[1], s1[2]);
                    string[] c2 = c.Split(',');
                    Console.WriteLine("\nThe Collection of All Possible Strings:\n");
                    for (int l=1;l<=62;l++)
                    {
                        Console.WriteLine(l+"{0},",c2[l]);
                    }
                    Console.WriteLine("............");
                    Console.ReadLine();
                }
                if (n == 2)
                {
                    comparelength(s1[1], s1[2]);
                    }
                Console.ReadLine();
                 }
        }
    }
}