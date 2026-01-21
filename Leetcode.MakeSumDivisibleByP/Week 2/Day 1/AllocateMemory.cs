namespace Studying.Week_2.Day_1
{
    public class AllocateMemory
    {
        public static void Execute()
        {
            for (int i = 0; i < 1_000_000; i++)
            {
                var data = new byte[1024]; // forces Gen0 collections
            }
        }
    }
}
