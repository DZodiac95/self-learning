using System.Text;
using Microsoft.Extensions.ObjectPool;

namespace Studying.Week_2.Day_3
{
    public static class ObjectPooling
    {
        public static void Main()
        {
            var pool = new DefaultObjectPool<StringBuilder>(new StringBuilderPooledObjectPolicy());

            var sb = pool.Get();
            sb.Append("Hello World");

            Console.WriteLine(sb.ToString());

            sb.Clear();
            pool.Return(sb);

            //Object pooling is critical in high-throughput APIs.
        }
    }
}
