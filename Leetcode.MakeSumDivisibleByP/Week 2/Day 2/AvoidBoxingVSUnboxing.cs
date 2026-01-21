using System.Collections;

namespace Studying.Week_2.Day_2
{
    internal class AvoidBoxingVSUnboxing
    {
        public void Execute()
        {
            //Bad Code
            ArrayList list = new();
            list.Add(10); // boxing

            //Good Code
            List<int> list2 = new();
            list2.Add(10); // no boxing

            //Boxing causes heap allocation and GC pressure.
        }
    }
}
