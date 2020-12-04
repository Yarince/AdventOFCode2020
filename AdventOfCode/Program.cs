namespace AdventOFCode
{
    class Program
    {
        static void Main(string[] args)
        {
            // var day1 = new Day1();
            // var inputDay1 = ReadInput.ReadInt("/home/yarince/RiderProjects/AdventOFCode/AdventOfCode/input-day1");
            // day1.Execute1(inputDay1);
            // day1.Execute2(inputDay1);

            var day2 = new Day2();
            var inputDay2 = ReadInput.ReadStr("/home/yarince/RiderProjects/AdventOFCode/AdventOfCode/input-day2");
            // day2.Execute1(inputDay2);
            day2.Execute2(inputDay2);
        }
    }
}