using System.Collections;

namespace lab_ex6._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hashtable daysOfWeek = new Hashtable
        {
            { 1, "Sunday" },
            { 2, "Monday" },
            { 3, "Tuesday" },
            { 4, "Wednesday" },
            { 5, "Thursday" },
            { 6, "Friday" },
            { 7, "Saturday" }
        };

            // Tìm ngày TueDay, in ra thông báo nếu tìm thấy hoặc không
            if (daysOfWeek.ContainsKey(3))
            {
                Console.WriteLine("Đã tìm thấy này TueDay.");
            }
            else
            {
                Console.WriteLine("Không tìm thấy ngày TueDay.");
            }

            // in ra các ngày trong tuần bao gồm cả key và value
            Console.WriteLine("Các ngày trong tuần:");
            foreach (DictionaryEntry entry in daysOfWeek)
            {
                Console.WriteLine($"{entry.Key}: {entry.Value}");
            }
        }
    }
}
