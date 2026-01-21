// See https://aka.ms/new-console-template for more information
using Studying.Week_2.Day_1;

class Program
{
    static void Main(string[] args)
    {
        //var sensor = new TemperatureSensor(30);

        //EventHandler<TemperatureChangedEventArgs> subscriber1 = (sender, args) => {
        //    Console.WriteLine($"[Subscriber 1] Temperature crossed threshold: {args.NewTemperature}°C");
        //};

        //EventHandler<TemperatureChangedEventArgs> subscriber2 = (sender, args) => {
        //    Console.WriteLine($"[Subscriber 2] ALERT! Current temp: {args.NewTemperature}°C (Old: {args.OldTemperature}°C)");
        //};

        //EventHandler<TemperatureChangedEventArgs> subscriber3 = (sender, args) => {
        //    Console.WriteLine($"[Subscriber 3] Logging event... New temp: {args.NewTemperature}");
        //};

        //sensor.TemperatureExceeded += subscriber1;
        //sensor.TemperatureExceeded += subscriber2;
        //sensor.TemperatureExceeded += subscriber3;

        //Console.WriteLine("Updating temperatures...\n");

        //sensor.UpdateTemperature(25);
        //sensor.UpdateTemperature(30);
        //sensor.UpdateTemperature(35);
        //sensor.UpdateTemperature(40);

        ////Safe unsubscribe
        //Console.WriteLine("\nUnsubscribing Subscriber 2 ...\n");
        //sensor.TemperatureExceeded -= subscriber2;

        //sensor.UpdateTemperature(45);
        //Console.WriteLine("\nDone.");

        AllocateMemory.Execute();
    }
}

//Console.WriteLine("Studying ...");
//int[] array = { 1, 4, 5, 7, 3, 10, 3, 7 };
//var max = GeneralClasses.GetMaxInArray(array);
//Console.WriteLine($"Max number in array is: {max}");
//var reversed = GeneralClasses.ReverseAnArray(array);
//Console.WriteLine($"Reversed array is: {string.Join(",", reversed)}");
//var secondMax = GeneralClasses.Get2ndLargestNumber(array);
//Console.WriteLine($"Second largest number in array is: {secondMax}");
//var duplicateRemovedArray = GeneralClasses.RemoveDuplicateArray(array);
//Console.WriteLine($"Removed duplicate array is: {string.Join(",", duplicateRemovedArray)}");

//string s = "racecar";
//bool result = GeneralClasses.IsPalindromeString(s);
//Console.WriteLine(result ? $"{s} is palindrome." : $"{s} is not palindrome.");

//int[] arr1 = { 1, 3, 5, 7 };
//int[] arr2 = { 2, 4, 6, 8 };
//int[] merged = GeneralClasses.MergeSortedArrays(arr1, arr2);
//Console.WriteLine($"Merged array: {string.Join(", ", merged)}");

//int number = 10;
//bool exist = GeneralClasses.NumberInArray(number, array);
//Console.WriteLine(exist ? $"{number} is in array." : $"{s} is not in array.");

//int[] testArray = { 2, 4 };
//int[] rs = GeneralClasses.ProductArray(testArray);
//Console.WriteLine($"Result is: {string.Join(", ", rs)}");

//int[] testArray2 = { 1, 3, 5, 7, 9 };
//int[] rs2 = GeneralClasses.RotateLeft(2, testArray2.ToList());
//Console.WriteLine($"Result is: {string.Join(", ", rs2)}");

//int[] array = {1, 2, 3, 4, 1};
//int rs2 = GeneralClasses.RemoveDuplicates(array);
//Console.WriteLine($"Result is: {string.Join(", ", rs2)}");

//int[] vector = { 1, 2 };
//GeneralClasses.calc_mov_avg(2, vector, 1);