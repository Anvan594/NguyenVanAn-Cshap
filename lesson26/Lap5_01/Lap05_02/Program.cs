namespace Lap05_02
{
    /// <summary>
    /// mảng 2 chiều
    /// khởi tạo mảng 2 chiều 4x3
    /// duyệt mảng và in theo ma trận
    /// in ra các phần tử có chỉ số hàng bằng chỉ số cột
    /// in ra phần tử lớn nhất của mỗi hàng
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding=System.Text.Encoding.UTF8;
            Console.WriteLine("mảng 2 chiều");
            int[,] array =
            {
                {4,6,9 },
                {2,4,5 },
                {9,2,6 },
                {1,6,3 }
            };
            //duyệt mảng và in ra
            printArray(array);
            //tìm các phần tử cố số hàng bằng cột
            printArrayXY(array);
            //tìm các phần tửu lớn nhất trên hàng
            printArrayMax(array);
        }
        static void printArray(int[,] array) {
            Console.WriteLine("các phần tử trong mảng\n");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(" {0} ",array[i,j]);
                }
                Console.WriteLine();
            }
        }
        static void printArrayXY(int[,] array)
        {
            //in ra phần tử có số hàng bằng cột
            for(int i = 0; i < array.GetLength(0); i++)
            {
                for(int j=0; j < array.GetLength(1); j++)
                {
                    if (i == j)
                    {
                        Console.Write(" {0} ", array[i,j]);
                    }
                    else
                    {
                        Console.Write("{0}", "   ");
                    }
                   
                } Console.WriteLine() ;
            }
        }
        /// <summary>
        /// Các phần tửu lớn nhất trên mỗi hàng
        /// </summary>
        /// <param name="array"></param>
        static void printArrayMax(int[,] array)
        {
            // in ra phần tử lớn nhất của hàng
            for(int i=0; i < array.GetLength(0); i++)
            {
                int max = array [i,0];
                for(int j=1 ; j < array.GetLength(1); j++)
                {
                    if(max< array[i, j])
                    {
                        max= array [i,j];
                    }
                }
                Console.WriteLine("\nPhần tử lớn nhất hàng {0} là :{1}",i,max);
            }
        }
    }
}
