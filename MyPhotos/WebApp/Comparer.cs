using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp
{
    public class Comparer : IComparer<Models.TagDTO>
    {
        public int Compare(Models.TagDTO a, Models.TagDTO b)
        {
            if (a.Type == b.Type)
            {
                return string.Compare(a.Name, b.Name);
            }
            return string.Compare(a.Type, b.Type);
        }
    }
}
