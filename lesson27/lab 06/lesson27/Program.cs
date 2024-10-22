using System.Collections;

namespace lesson27
{
    internal class Program
    {
        /// <summary>
        /// Arraylist
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("Demo Arraylist");
            //khoi tao
            ArrayList arrayList = new ArrayList();
            //them cac phan tu
            //add
            arrayList.Add(111);
            arrayList.Add("Ngoc Bich");
            //Addrange
            string[] strs = { "Tùng", "Cúc", "Trúc", "Mai" };
            arrayList.AddRange(strs);
            //in mang
            printArray(arrayList);
            //insert
            arrayList.Insert(0, "Devmaster");
            printArray(arrayList);
            //remove
            arrayList.Remove("Devmaster");
            printArray(arrayList);
            arrayList.RemoveAt(1);
            printArray(arrayList);
            //sort
            arrayList.AddRange(strs);
            printArray(arrayList);
            arrayList.Sort();
            printArray(arrayList);

        }
        
        static void printArray(ArrayList arrayList)
        {
            Console.WriteLine("Danh sach cac phan tu");
            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("==========================");
        }
    }
}
