using System;

namespace Studying.Week_2.Day_4
{
    internal class LargeObjectHeap
    {
        byte[] large = new byte[100_000]; // LOH allocation
        //LOH objects are not compacted (by default)
        //Frequent LOH allocations cause memory fragmentation
    }
}
