using System.Collections;

namespace lab_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
          // tao ArrayList
          ArrayList inv = new ArrayList();
            //them phan tu vao danh sach
            inv.Add(new Product("A", 5.9, 3));
            inv.Add(new Product("B", 8.2, 2));
            inv.Add(new Product("C", 3.5, 4));
            inv.Add(new Product("D", 1.8, 8));
            //in ra danh sach phan tu
            Console.WriteLine("Product list:");
            foreach (Product i in inv)
            {
                Console.WriteLine("" + i);
            }
        }
    }
}
