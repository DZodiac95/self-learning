namespace Studying.Week_2.Day_3
{
    public class LinqVsLoop
    {
        private readonly int[] _data = Enumerable.Range(1, 1000).ToArray();

        public int LinqSum() => _data.Where(x => x > 500).Sum();

        public int LoopSum()
        {
            int sum = 0;
            foreach (var x in _data)
                if (x > 500)
                    sum += x;
            return sum;
        }

        //LINQ trades performance for readability — loops win in hot paths(Performance-critical code).
    }
}
