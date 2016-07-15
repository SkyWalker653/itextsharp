using System;
using System.Collections.Generic;
using System.Text;

namespace iTextSharp.text.pdf.languages
{
    public class IndicCompositeCharacterComparator : IComparer<String>
    {
        public int Compare(String o1, String o2)
        {
            if (o2.Length > o1.Length)
            {
                return 1;
            }
            else if (o1.Length > o2.Length)
            {
                return -1;
            }
            else
            {
                return o1.CompareTo(o2);
            }
        }
    }
}
