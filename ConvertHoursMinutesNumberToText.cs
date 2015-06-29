using System;
using System.Collections.Generic;
using System.IO;
class Solution
{
    static bool ConvertNumberToText(int num, out string buf)
    {
        string[] strones = {
            "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight",
            "Nine", "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen",
            "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen",
          };

        string[] tens = { "Ten", "Twenty", "Thirty", "Fourty", "Fifty" };


        string result = "";
        buf = "";
        int single, tens;

        if (num > 59)
            return false;


        if (num < 20)
        {
            tens = 0; // special case
            single = num;
        }
        else
        {
            tens = num / 10;
            num = num - tens * 10;
            single = num;
        }

        result = "";


        if (tens > 0)
        {
            result += strtens[tens - 1];
            result += " ";
        }
        if (single > 0)
        {
            result += strones[single - 1];
            result += " ";
        }

        buf = result;
        return true;
    }
    static void Main(String[] args)
    {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        // leitura das horas
        int horas = Convert.ToInt16(Console.ReadLine());
        int minutos = Convert.ToInt16(Console.ReadLine());
        int mode = 1;
        string result = "";
        string minStr = "";
        string horasStr = "";
        if (minutos > 30)
        {
            horas++;
            minutos = 60 - minutos;
            mode = 2;
        }
        if (ConvertNumberToText(horas, out horasStr) == true)
        {
            switch (minutos)
            {

                case 0:
                    horasStr += " o'Clock";
                    break;
                case 15:
                    minStr = "quarter";
                    break;
                default:
                    if (ConvertNumberToText(minutos, out minStr) == true)
                    {
                        minStr += "minutes";
                    }
                    {
                        //numero invalido
                    }
                    break;
            }
            if (minutos != 0)
            {
                if (mode == 2)
                {
                    result = minStr + " to " + horasStr;
                }
                else
                {
                    result = minStr + " past " + horasStr;
                }
            }
            else
            {
                result = horasStr;
            }
            result = result.ToLower();
            Console.WriteLine(result);
        }
    }
}
