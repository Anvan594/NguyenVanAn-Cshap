using System.Diagnostics;

namespace lab_ex6._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            List<Book> books = new List<Book>()
            {
            new Book {Id = 1, Title ="Đắc nhân tâm", Author = "Dale Carnegie", Publisher = "Kim Dong", Year =1941 , Price = 50.0},
            new Book {Id = 2, Title = "Bắt trẻ đồng xanh", Author = "J.D. Salinger", Publisher = "Nhi Dong", Year = 1967, Price = 40.0},
            new Book {Id = 3, Title = "Việt Nam sử lược", Author = " Trần Trọng Kim", Publisher = "Tan Dan", Year = 1920, Price = 60.0},
            new Book {Id = 4, Title ="Dế mèn phiêu lưu ký", Author = "Tô Hoài", Publisher = "Doi Moi", Year = 1941, Price = 70.0},
            new Book {Id = 5, Title = "Truyện Kiều", Author = "Nguyễn Du", Publisher = "Nhi Dong", Year = 2005, Price = 40.0},
            new Book {Id = 6, Title = "Lão Hạc", Author = "Nam Cao", Publisher = "Van hoc", Year = 1943, Price = 60.0},
            new Book {Id = 7, Title ="Chí phèo", Author = "Nam Cao", Publisher = "Nhi Dong", Year = 2010, Price = 80.0},
            new Book {Id = 8, Title = "Số đỏ", Author = "Vũ Trọng Phụng", Publisher = "Nhi Dong", Year = 2005, Price = 40.0},
            new Book {Id = 9, Title = "Đất rừng phương nam", Author = "Đoàn Giỏi", Publisher = "Kim Dong", Year = 2014, Price = 60.0},
            new Book {Id = 10, Title ="Cánh đồng bất tận", Author = "Nguyễn Ngọc Tư", Publisher = "Tuoi Tre", Year = 2010, Price = 50.0}
           
            };
            //in ra danh sach quyen sach tang dan theo gia
            var sortedBooks = books.OrderBy(b => b.Price).ToList();
            Console.WriteLine("Sách tăng dần theo giá:");
            sortedBooks.ForEach(b => Console.WriteLine(b.Title));

            // Tìm sách có giá trùng với giá nhập từ bàn phím
            Console.WriteLine("sách có giá trùng với giá nhập từ bàn phím:");
            double inputPrice = Convert.ToDouble(Console.ReadLine());
            var matchedBooks = books.Where(b => b.Price == inputPrice).ToList();
            matchedBooks.ForEach(b => Console.WriteLine($"tên sách: {b.Title}"));

            // Sách xuất bản năm 2014
            var books2014 = books.Where(b => b.Year == 2014).ToList();
            Console.WriteLine("Sách xuất bản năm 2014:");
            books2014.ForEach(b => Console.WriteLine(b.Title));

            // Xóa sách có Publisher là "Nhi Dong"
            books.RemoveAll(b => b.Publisher == "Nhi Dong");
            Console.WriteLine("Xóa sách có Publisher là 'Nhi Dong':");
            books.ForEach(b => Console.WriteLine(b.Title));
        }
    }
}
