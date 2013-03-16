using System.Collections.Generic;
using System.Linq;
using Microsoft.FSharp.Collections;

namespace ObjectiveShell.UnitTests
{
    public class FSharpListHelper
    {
        public FSharpList<T> ConvertList<T>(List<T> inputlist)
        {
            FSharpList<T> sharplist = FSharpList<T>.Empty;
            for (int i = inputlist.Count - 1; i >= 0; i--)
            {
                sharplist = new FSharpList<T>(inputlist[i], sharplist);
            }
            return sharplist;
        }

        public List<T> ConvertList<T>(FSharpList<T> sharplist)
        {
            return sharplist.ToList();
        }
    }
}