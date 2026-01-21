namespace Studying.Week_2.Day_2
{
    internal class ParseFirstNumber
    {
        public int Execute(string input)
        {
            //Parse data with allocations.
            //var parts = input.Split(',');
            //int a = int.Parse(parts[0]);

            ReadOnlySpan<char> span = input.AsSpan();
            int index = span.IndexOf(',');
            return int.Parse(span.Slice(0, index));

            //Span<T> avoids array/string allocations.
        }
    }
}
