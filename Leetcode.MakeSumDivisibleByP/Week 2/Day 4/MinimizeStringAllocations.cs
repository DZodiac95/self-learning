using System.Text;

namespace Studying.Week_2.Day_4
{
    public class MinimizeStringAllocations
    {
        public MinimizeStringAllocations() {
            //Bad code
            string s = "";
            for (int i = 0; i < 1000; i++)
                s += i;

            //Good code
            var sb = new StringBuilder();
            for (int i = 0; i < 1000; i++)
                sb.Append(i);

            string result = sb.ToString();
        }
    }
}
