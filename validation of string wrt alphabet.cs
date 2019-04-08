using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string alphabetString;
            Console.WriteLine("Enter String in Curly Brackets:");
            alphabetString = Console.ReadLine();
            char[] charArray = alphabetString.ToCharArray();
            string[] alphabets = getAlphabetArray(charArray);
            bool flag = checkValidity(alphabets);
            if (flag)
            {
                Console.WriteLine("\nEnter Alphabets You Wanna Check: ");
                string myString = Console.ReadLine();
                checkStringValidity(alphabets, myString);
            }
        }



        static string[] getAlphabetArray(char[] charArray)
        {
            string[] alphabetArray = new string[100];
            int arrayPointer = 0;
            string temp = null;
            for (int i = 0; i < charArray.Length; i++)
            {

                if (charArray[i] == ',' && temp != null)
                {
                    alphabetArray[arrayPointer] = temp;
                    temp = null;
                    arrayPointer++;
                }

                else if (charArray[i] != ',')
                {
                    if (charArray[i] != '{')
                    {
                        if (charArray[i] != '}')
                        {
                            temp = temp + charArray[i];
                        }
                    }

                }

            }
            if (temp != null)
            {
                alphabetArray[arrayPointer] = temp;
            }
            return arrayFormatter(alphabetArray, arrayPointer);

        }


        static string[] arrayFormatter(string[] array, int arrayPointer)
        {
            string[] finalArray = new string[arrayPointer + 1];
            for (int i = 0; i <= arrayPointer; i++)
                finalArray[i] = array[i];

            return finalArray;
        }

        static bool checkValidity(string[] alphabets)
        {
            bool flag = true;
            if (alphabets[0] == null)
                flag = false;
            for (int i = 0; i < alphabets.Length; i++)
            {
                if (flag == false)
                    break;
                string tempA = alphabets[i];
                string tempB = null;
                for (int j = 0; j < alphabets.Length; j++)
                {
                    if (flag == false)
                        break;
                    tempB = alphabets[j];
                    if (j != i)
                    {
                        if (tempA.Length <= tempB.Length)
                        {
                            if (subString(tempA, 0, tempA.Length) == subString(tempB, 0, tempA.Length))
                            {
                                flag = false;
                                break;
                            }
                        }
                        else
                        {
                            if (subString(tempA,0, tempB.Length) == subString(tempB,0, tempB.Length))
                            {
                                flag = false;
                                break;
                            }
                        }

                    }
                }
            }

            if (flag)
            {
                Console.WriteLine("\nYour Given Alphabet is Valid");
            }
            else if (!flag)
            {
                Console.WriteLine("\nYour Given Alphabet is Not Valid");
            }

            return flag;
        }

        static void checkStringValidity(string[] alphabetArray, string myString)
        {

            string temp = "";
            int arrIndex = 0;
            bool flag = true;
            bool check = false;
            string[] reverseStr = new string[100];
            int stringLength = 0;
            if (myString == "")
            {
                flag = false;
            }
            while (flag)
            {
                if (!flag)
                
                    break;
                
                temp = temp + myString[arrIndex];

                for (int i = 0; i < alphabetArray.Length; i++)
                {
                    if (temp.Length == alphabetArray[i].Length)
                    {
                        if (temp == alphabetArray[i])
                        {
                            reverseStr[stringLength] = subString(myString, 0, arrIndex+1);
                            myString = subString(myString,arrIndex + 1,myString.Length);
                            stringLength++;

                            if (myString == "" || myString == null)
                            {
                                check = true;
                                flag = false;
                                break;
                            }
                            temp = "";
                            arrIndex = -1;
                            break;

                        }
                    }
                }
                if (temp == myString)
                {
                    break;
                }
                arrIndex++;

            }

            if (check)
            {
                Console.WriteLine("\nString is Valid");
                Console.WriteLine("The Length of the Strings is:");
                Console.Write(stringLength);
                Console.WriteLine();
                Console.WriteLine("The Reverse of a String is:");
                for (int i = stringLength-1; i >= 0; i--)
                {
                    Console.Write(reverseStr[i]);

                }
                //Console.WriteLine();
            }
            if (!check)
            {
                Console.WriteLine("\nString is invalid");
            }
            Console.ReadLine();

        }
        static string subString(string str,int startIndex,int stopIndex)
        {
            string subString="";
            for(int i=startIndex; i < stopIndex; i++)
            {
                subString = subString + str[i];

            }
            return subString;
        }
    }
}
