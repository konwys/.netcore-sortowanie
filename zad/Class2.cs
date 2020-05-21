using System;
using System.Collections.Generic;
using System.Text;

namespace zad
{
    static class Extensions
    {
        public static void DisplayArray(this person[] persons)
        {
            foreach (person p in persons)
            {
                Console.WriteLine(p.ToString());
            }
        }
    }




}
