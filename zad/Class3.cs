using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace zad
{
   class PersonageComparer : IComparer
    {
         public int Compare (object x, object y)    
        {
            person p1 = x as person;
            person p2 = y as person;

            if (p1 != null && p2 != null)
            {
                if (p1.age < p2.age) return 1;
                else if (p1.age > p2.age) return -1;
                else return 0;
            }
            return 0;
        }
    }
    

}
