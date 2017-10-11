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

            string s = " apple   pie";
            string s2 = "abcacba";
            int count = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (isvowel(s[i])) count++;
            }

            Console.WriteLine(count);
            Console.WriteLine(delspaces(s));
            Console.WriteLine(compstartend(s2));
            Console.WriteLine(compreverse(s2));
            Console.ReadKey();
        }
        static bool compreverse(string s)
        {
            if (s.Length < 2) return false;

            string reverse = "";
            for (int i = s.Length-1; i > -1; i--)
            {
                if(char.IsLetter(s[i])) reverse += char.ToLower(s[i]);

            }

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] != reverse[i]) return false;
            }
            return true;
        }
        static bool compstartend(string s)
        {
            if (s.Length < 2) return false;
            int i = 0;
            int j = s.Length-1;
            while(i<j)
            {
                if(s[i]!=s[j])
                { return false; }
                i++;
                j--;
            }
            return true;
        }

        static string delspaces(string s)
        {
            string news = "";

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] != ' ') news += s[i];
            }

            return news;
        }

       static bool isvowel(char c)
        {
            string vowels = "aeiou";

            for (int i = 0; i < vowels.Length; i++)
            {

                if (vowels[i] == c) return true;

            }

            return false;
        }
    }
}
