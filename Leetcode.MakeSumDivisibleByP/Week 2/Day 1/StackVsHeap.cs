namespace Studying.Week_2.Day_1
{
    public struct PointStruct {  public int X; public int Y; }

    public class Point { public int X; public int Y; }

    public class StackVsHeap
    {
        public static void Execute()
        {
            var str = new PointStruct { X = 1, Y = 2 };
            var p = new Point { X = 1, Y = 2 };

            ModifyStruct(str);
            ModifyClass(p);

            Console.WriteLine(str.X); // 1
            Console.WriteLine(p.X);  // 99

            //Struct is copied → stack behavior. Class is referenced → heap
        }

        static void ModifyStruct(PointStruct p) => p.X = 99;
        static void ModifyClass(Point p) => p.X = 99;
    }
}
