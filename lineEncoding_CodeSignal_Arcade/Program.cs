using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lineEncoding_CodeSignal_Arcade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "aabbaabc";
            string c = lineEncoding(s);
            Console.WriteLine(c);
        }

        static string lineEncoding(string s)
        {
            int count = 0;
            List<string> st = new List<string>();
            HashSet<char> hash = new HashSet<char>();
            List<char> list = new List<char>();
            string str = "";
            for (int i = 0; i < s.Length; i++)
            {
                hash.Add(s[i]);
            }
            for (int i = 0; i < s.Length - 1; i++)
            {
                foreach (var item in hash)
                {
                    if (item == s[i])
                    {
                        list.Add(s[i]);
                    }
                }
                if (s[i] != s[i+1])
                {
                    list.Add(' ');
                }
            }
            list.Add(s[s.Length - 1]);
            string g = "";
            for (int i = 0; i < list.Count; i++)
            {
                g += list[i];
            }
            string[] vs = g.Split(' ');
            for (int i = 0; i < vs.Length; i++)
            {
                if (vs[i].Length > 1)
                {
                    st.Add(vs[i].Length.ToString());
                }
                st.Add(vs[i][0].ToString());
            }
            foreach (var item in st)
            {
                str += item;
            }
            return str;

        }
    }
}
