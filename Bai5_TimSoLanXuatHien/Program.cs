using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai5_TimSoLanXuatHien
{
    class Program
    {
        static public int DemSoLanXuatHien(string a,string b)
        { 
            int count = 0;

            char[] separators = { ' ', ',', '?' };
            string[] words = a.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            
            for(int i = 0; i < words.Length; i++)
            {
                string[] temp = words[i].Split();
                foreach(string c in temp)
                {
                    Console.WriteLine(c);
                    c.Equals(b);
                    count++;
                }
            }

           
            return count;
            //sai
        }
        static int CountCharInString(string a, char b)
        {
            int cout = 0;
            char[] ch = a.ToCharArray();
            foreach(char c in ch)
            {
                
                if (c == b)
                {
                    cout++;
                }
            }
            

            return cout;

        }
        static void Main(string[] args)
        {
            string a = "Nguyen van an";
            char b = 'a';
            int i = CountCharInString(a, b);
            Console.WriteLine(i);

            Console.ReadLine();
        }
    }
}
