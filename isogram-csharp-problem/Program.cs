using System;

namespace isogram_csharp_problem
{
    public class Program
    {
        public static bool checkiso(string s)
        {
            
            s = s.Replace(" ", String.Empty);
            s = s.Replace("-", String.Empty);
            int i, j,k=0;
            for (i = 0;i<s.Length-1;i++)
            {
                for(j=i+1;j<s.Length;j++)
                {
                    if (s[i] == s[j])
                    {
                        k = 1;
                        break;
                    }
                }
                if (k == 1) break;
            }
            if (k == 1) return false;
            else return true;

        }
        public static void Main(string[] args)
        {

        }
    }
}
