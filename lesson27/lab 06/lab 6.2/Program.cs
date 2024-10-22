namespace lab_6._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
           //tao sortedlist generic
           SortedList<string, string> listEm = new SortedList<string, string>();
            //dua du lieu vao
            listEm.Add("E01", "Tran Thi Thuy");
            listEm.Add("E02", "Le Hai Ha");
            listEm.Add("E03", "Nguyen Van Hung");
            listEm.Add("E04", "Hoang Thi Thom");
            listEm.Add("E05", "Trinh Van Chien");
            //in ra danh sach
            Console.WriteLine("Danh sach nhan vien");
            foreach (var key in listEm.Keys)
            {
                Console.WriteLine(key + ":" + listEm[key]);
            }
            //tim kiem tat ca cac nhan vien co ten bat dau bang chu Th
            Console.WriteLine("Danh sach nhan vien bat dau bang chu Th");
            foreach (var key in listEm.Keys)
            {
                if (listEm[key].StartsWith("Th"))
                    Console.WriteLine(key + ":" +listEm[key]);
            }
            //xoa nhan vien co ma E04
            listEm.Remove("E04");
            //kiem tra neu chua co nhan vien E06 thi them vao
            if (!listEm.ContainsKey("E06"))
                listEm.Add("E06", "Nguyen Hoai Linh");
            //in danh sach sau khi xoa, them
            Console.WriteLine("Danh sach nhan vien sau khi xoa, them");
            foreach (var key in listEm.Keys)
            {
                Console.WriteLine(key +":"+listEm[key]);
            }
        }
    }
}
